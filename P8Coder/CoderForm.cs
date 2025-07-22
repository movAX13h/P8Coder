﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using P8Coder.Core;
using P8Coder.Utils;

namespace P8Coder
{
    public partial class CoderForm : Form
    {
        public static UserSettings Settings;

        public Project CurrentProject { get { return currentProject; } }
        private Project currentProject;
        private Function currentFunction;
        private bool lockGUIUpdates = false;

        private string title = "P8Coder";
        private Dictionary<string, Pico8ApiHelp> pico8help;

        private SpritesheetForm spritesheetForm;
        private MapForm mapForm;

        private bool darkTheme = false;

        struct Pico8ApiHelp
        {
            public string Name;
            public string Code;
            public string Description;
        }

        public CoderForm()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            readPico8API();

            darkSyntaxColors(false);
        }

        private void darkSyntaxColors(bool state)
        {
            darkTheme = state;
            if (state)
            {
                luaCodeEditor.BackColor = Color.FromArgb(255, 30, 30, 30);
                luaCodeEditor.ForeColor = Color.White;
                luaCodeEditor.LineNumberColor = Color.FromArgb(255, 43, 145, 175);
                luaCodeEditor.IndentBackColor = Color.FromArgb(255, 30, 30, 30);
                luaCodeEditor.TextAreaBorder = FastColoredTextBoxNS.TextAreaBorderType.Single;
                luaCodeEditor.TextAreaBorderColor = Color.FromArgb(255, 63, 63, 70);
            }
            else
            {
                luaCodeEditor.BackColor = Color.White;
                luaCodeEditor.ForeColor = Color.Black;
                luaCodeEditor.LineNumberColor = Color.Teal;
                luaCodeEditor.IndentBackColor = Color.WhiteSmoke;
                luaCodeEditor.TextAreaBorder = FastColoredTextBoxNS.TextAreaBorderType.Single;
                luaCodeEditor.TextAreaBorderColor = Color.Silver;
            }
        }

        private void CoderForm_Shown(object sender, EventArgs e)
        {
            Settings = new UserSettings();
            if (Settings.Pico8exe.Length == 0 || !File.Exists(Settings.Pico8exe))
            {
                MessageBox.Show("Please select pico8.exe so P8Coder can run carts.", "pico-8 binary", MessageBoxButtons.OK);
                showPico8BinarySelectionDialog();                
            }

            if (currentProject == null) newProject();
        }

        private void showPico8BinarySelectionDialog()
        {
            if (selectPico8Dialog.ShowDialog() == DialogResult.OK)
            {
                Settings.Pico8exe = selectPico8Dialog.FileName;
                Settings.Save();
            }
        }

        private void readPico8API()
        {
            string api = Properties.Resources.pico8api;
            pico8help = new Dictionary<string, Pico8ApiHelp>();

            string[] lines = api.Split('\n');
            foreach (string line in lines)
            {
                string full = line.Trim();
                Pico8ApiHelp help = new Pico8ApiHelp();
                help.Name = full.Substring(0, full.IndexOf("("));
                help.Code = full.Substring(0, full.IndexOf("--")).Trim();
                help.Description = full.Substring(full.IndexOf("--")+2).Trim();
                pico8help.Add(help.Name, help);
            }
        }

        // project
        private void newProject()
        {
            currentProject = new Project();
            fillControls();
            entitiesList.SelectedIndex = 0;
        }

        public void LoadProject(string filename)
        {
            codeTabs.Controls.Clear();

            Project p = new Project();
            if (!p.Load(filename))
            {
                MessageBox.Show("Failed to load project file!", "Sorry!");
                return;
            }

            currentFunction = null;
            luaCodeEditor.Text = "";

            currentProject = p;

            if (currentProject.Cart != null) currentProject.Cart.OnChangeCallback = new Action<Cartridge>(reloadCartridge);

            if (spritesheetForm != null) spritesheetForm.UpdateImage();
            if (mapForm != null) mapForm.UpdateImage();

            fillControls();
            if (entitiesList.Items.Count > 0) entitiesList.SelectedIndex = 0;
        }

        private void saveProject()
        {
            if (String.IsNullOrEmpty(currentProject.Filename))
            {
                saveProjectDialog.Title = "Save P8 Coder project file";
                saveProjectDialog.RestoreDirectory = true;
                saveProjectDialog.FileName = currentProject.Name + ".p8c";
                if (saveProjectDialog.ShowDialog() == DialogResult.OK)
                {
                    currentProject.Filename = saveProjectDialog.FileName;
                }
                else return;
            }

            if (currentProject.Save())
            {
                currentProject.Changed = false;
                fillControls();
            }
            else
            {
                MessageBox.Show("Failed to save project!", "Sorry!");
            }
        }

        private void checkSaveChanges()
        {
            if (currentProject.Changed)
            {
                DialogResult res = MessageBox.Show("Do you want to save changes made to '" + currentProject.Name + "'?", "Save changes?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes) saveProject();
            }
        }

        private void showTabs(Entity entity)
        {
            int x = 3;
            codeTabs.Controls.Clear();

            bool found = false;
            foreach(Function func in entity.Functions)
            {
                if (func == currentFunction) found = true;
                Button button = new Button();
                button.Text = func.Name;
                button.Tag = func;
                button.Width = 80;
                button.Height = 30;
                button.FlatStyle = FlatStyle.Flat;
                button.Left = x;
                button.Click += codeTabClicked;
                codeTabs.Controls.Add(button);
                x += 84;
            }

            if (found) editFunction(currentFunction);
            else editFunction(entity.Functions[0]);
        }

        private void editFunction(Function func)
        {
            currentFunction = null;
            luaCodeEditor.Text = func.Code;
            luaCodeEditor.ClearUndo();
            currentFunction = func;

            foreach(Control c in codeTabs.Controls)
            {
                ((Button)c).ForeColor = ((Function)c.Tag == func) ? Color.Black : Color.Gray;
                ((Button)c).BackColor = ((Function)c.Tag == func) ? Color.White : BackColor;
            }

            luaCodeEditor.Focus();

            setTitle();
        }

        private void showEntityForm(Entity entity)
        {
            EntityForm form = new EntityForm(entity);
            form.ShowDialog();
            form.Dispose();
            entitiesList.Invalidate();
            showTabs((Entity)entitiesList.SelectedItem);
        }

        // display project data on GUI
        private void fillControls()
        {
            //setTitle();

            lockGUIUpdates = true;

            spritesheetBtn.Enabled = currentProject.Cart != null;
            mapButton.Enabled = spritesheetBtn.Enabled;

            saveBtn.Enabled = currentProject.Changed;
            projectNameInput.Text = currentProject.Name;
            authorInput.Text = currentProject.Author;
            cartInput.Text = currentProject.CartFilename;

            int id = entitiesList.SelectedIndex;
            entitiesList.Items.Clear();
            foreach(Entity entity in currentProject.Entities)
            {
                entitiesList.Items.Add(entity, entity.Enabled);
            }
            entitiesList.SelectedIndex = id;
            lockGUIUpdates = false;
        }

        // write to project object
        private void updateProject()
        {
            if (lockGUIUpdates) return;

            currentProject.Changed = true;
            currentProject.Name = projectNameInput.Text;
            currentProject.Author = authorInput.Text;

            if (currentProject.CartFilename != cartInput.Text)
            {
                currentProject.CartFilename = cartInput.Text;
                if (currentProject.Cart == null) MessageBox.Show("Failed to load the cartridge!", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else currentProject.Cart.OnChangeCallback = new Action<Cartridge>(reloadCartridge);
            }

            saveBtn.Enabled = true;
        }

        private void reloadCartridge(Cartridge cart)
        {
            currentProject.CartFilename = cartInput.Text;
            currentProject.Cart.OnChangeCallback = new Action<Cartridge>(reloadCartridge);
            if (spritesheetForm != null) spritesheetForm.UpdateImage();
            if (mapForm != null) mapForm.UpdateImage();
        }

        private void setTitle()
        {
            Text = title + " " + versionString();
            if (!String.IsNullOrWhiteSpace(currentProject.Filename)) Text += " - " + Path.GetFileName(currentProject.Filename);
            if (entitiesList.SelectedItem != null) Text += " - " + ((Entity)(entitiesList.SelectedItem)).Name;
            if (currentFunction != null) Text += " - " + currentFunction.Name;
        }

        private string versionString()
        {
            string[] v = Application.ProductVersion.Split(".".ToCharArray(), 3);
            return " v" + v[0] + "." + v[1];
        }

        private void runProject()
        {
            if (String.IsNullOrWhiteSpace(currentProject.CartFilename))
            {
                Clipboard.SetText(currentProject.Code);
                MessageBox.Show("No cartridge selected. Code copied to clipboard instead.", "Fallback", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentProject.WriteCart())
            {
                if (Settings.Pico8exe.Length == 0 || !File.Exists(Settings.Pico8exe))
                {
                    showPico8BinarySelectionDialog();
                    return;
                }

                runCart();
            }
            else
            {
                MessageBox.Show("Failed to inject code into P8!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region running pico-8
        /*
            NOTE: I've tried to restart the running pico-8 application by sending ctrl-r (reload cart) to the window.
                  For some reason sending characters (a-z 0-9) works but special characters (ctrl, esc, return) don't
                  and I could not find a way to get it working.
                  Pico-8 has a built-in debug/trace function (printh) that outputs to system console but I could not get the 
                  output when I'm running pico-8 from code.
        */
        private void runCart()
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = "-run " + currentProject.CartFilename;

            info.Arguments += " -width " + Settings.Width.ToString() +
                              " -height " + Settings.Height.ToString() +
                              " -windowed " + (Settings.Fullscreen ? "0" : "1") + 
                              " -sound " + Settings.SoundVolume.ToString() +
                              " -music " + Settings.MusicVolume.ToString() + 
                              " -joystick " + Settings.Joystick.ToString() + 
                              " -pixel_perfect " + (Settings.PixelPerfect ? "1" : "0") + 
                              " -screenshot_scale " + Settings.ScreenshotScale.ToString() +
                              " -gif_scale " + Settings.GIFScale.ToString() + 
                              " -gif_len " + Settings.GIFDuration.ToString() +
                              " -gui_theme " + (Settings.DarkEditor ? "1" : "0") +
                              " -frameless " + (Settings.Borderless ? "1" : "0") + 
                              " -show_fps " + (Settings.ShowFPS ? "1" : "0");

            info.FileName = Settings.Pico8exe;
            info.UseShellExecute = false;
            
            Process pico8Process = new Process();
            pico8Process.StartInfo = info;
            pico8Process.Start();
        }
        #endregion

        private void moveEntityUp()
        {
            Entity entity = (Entity)entitiesList.SelectedItem;
            int index = entitiesList.SelectedIndex;
            if (index > 0)
            {
                index--;
                currentProject.Entities.Remove(entity);
                currentProject.Entities.Insert(index, entity);
                currentProject.Changed = true;
                saveBtn.Enabled = true;
                fillControls();
                entitiesList.SelectedIndex = index;
            }
        }

        private void moveEntityDown()
        {
            Entity entity = (Entity)entitiesList.SelectedItem;
            int index = entitiesList.SelectedIndex;
            if (index < entitiesList.Items.Count - 1)
            {
                index++;
                currentProject.Entities.Remove(entity);
                currentProject.Entities.Insert(index, entity);
                currentProject.Changed = true;
                saveBtn.Enabled = true;
                fillControls();
                entitiesList.SelectedIndex = index;
            }
        }

        private void selectPrevEntity()
        {
            if (entitiesList.SelectedIndex < 1) entitiesList.SelectedIndex = entitiesList.Items.Count - 1;
            else entitiesList.SelectedIndex -= 1;
        }

        private void selectNextEntity()
        {
            if (entitiesList.SelectedIndex > entitiesList.Items.Count - 2) entitiesList.SelectedIndex = 0;
            else entitiesList.SelectedIndex += 1;
        }

        private void selectPrevFunction()
        {
            for(int i = 0; i < codeTabs.Controls.Count; i++)
            {
                Function f = (Function)codeTabs.Controls[i].Tag;
                if (f == currentFunction)
                {
                    int id = i - 1;
                    if (id < 0) id = codeTabs.Controls.Count-1;
                    editFunction((Function)codeTabs.Controls[id].Tag);
                    return;
                }
            }
        }

        private void selectNextFunction()
        {
            for (int i = codeTabs.Controls.Count - 1; i >= 0; i--)
            {
                Function f = (Function)codeTabs.Controls[i].Tag;
                if (f == currentFunction)
                {
                    int id = i + 1;
                    if (id > codeTabs.Controls.Count - 1) id = 0;
                    editFunction((Function)codeTabs.Controls[id].Tag);
                    return;
                }
            }
        }

        private void showLoadProjectDialog()
        {
            checkSaveChanges();
            if (openProjectDialog.ShowDialog() == DialogResult.OK)
            {
                LoadProject(openProjectDialog.FileName);
            }
        }


        // Event handlers

        private void codeTabClicked(object sender, EventArgs e)
        {
            editFunction((Function)((Button)sender).Tag);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveProject();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            checkSaveChanges();
            newProject();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            showLoadProjectDialog();
        }

        private void projectInputChanged(object sender, EventArgs e)
        {
            updateProject();
        }

        private void entitiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entitiesList.SelectedIndex < 0) return;

            Entity entity = (Entity)entitiesList.SelectedItem;
            showTabs(entity);
        }

        private void entitiesList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (entitiesList.SelectedIndex < 0) return;
            saveBtn.Enabled = true;
            currentProject.Changed = true;
            Entity entity = (Entity)entitiesList.SelectedItem;
            entity.Enabled = e.NewValue == CheckState.Checked;
        }

        private void addEntityBtn_Click(object sender, EventArgs e)
        {
            Entity entity = new Entity();
            entity.Add("update", "function updEntity()\nend");
            entity.Add("draw", "function drwEntity()\nend");
            currentProject.Entities.Add(entity);
            fillControls();
            entitiesList.SelectedItem = entity;
            showEntityForm(entity);
        }

        private void delEntityBtn_Click(object sender, EventArgs e)
        {
            if (entitiesList.SelectedIndex == 0)
            {
                MessageBox.Show("The PICO8 entity can not be deleted because it implements the default console functions.", "No, no, no!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Entity entity = (Entity)entitiesList.SelectedItem;

            if (MessageBox.Show("Do you really want to delete entity '" + entity.Name + "'?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                entitiesList.Items.Remove(entity);
                currentProject.Entities.Remove(entity);
            }
        }

        private void editEntityBtn_Click(object sender, EventArgs e)
        {
            if (entitiesList.SelectedIndex < 0) return;
            saveBtn.Enabled = true;
            Entity entity = (Entity)entitiesList.SelectedItem;
            showEntityForm(entity);
        }


        private void entityUpBtn_Click(object sender, EventArgs e)
        {
            moveEntityUp();
        }

        private void entityDownBtn_Click(object sender, EventArgs e)
        {
            moveEntityDown();
        }

        private void asmBtn_Click(object sender, EventArgs e)
        {
            runProject();
        }

        private void CoderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentProject.Changed) checkSaveChanges();
        }

        private void luaCodeEditor_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if (currentFunction == null) return;
            if (currentFunction.Code == luaCodeEditor.Text) return;

            currentFunction.Code = luaCodeEditor.Text;
            currentProject.Changed = true;
            saveBtn.Enabled = true;
        }

        private void cartSelBtn_Click(object sender, EventArgs e)
        {
            if (openCartDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cartInput.Text = openCartDialog.FileName;
                updateProject();
                fillControls();
            }
        }

        private void CoderForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                if (currentProject.Changed) saveProject();
            }
            if (e.KeyCode == Keys.L && e.Control)
            {
                showLoadProjectDialog();
            }
            else if (e.KeyCode == Keys.Return && e.Alt)
            {
                runProject();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F1 && e.Alt)
            {
                selectPrevFunction();
            }
            else if (e.KeyCode == Keys.F2 && e.Alt)
            {
                selectNextFunction();
            }
            else if (e.KeyCode == Keys.F1)
            {
                selectPrevEntity();
            }
            else if (e.KeyCode == Keys.F2)
            {
                selectNextEntity();
            }
        }

        private void luaCodeEditor_ToolTipNeeded(object sender, FastColoredTextBoxNS.ToolTipNeededEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.HoveredWord))
            {
                if (pico8help.ContainsKey(e.HoveredWord))
                {
                    Pico8ApiHelp help = pico8help[e.HoveredWord];
                    e.ToolTipTitle = help.Code;
                    e.ToolTipText = help.Description;
                }
            }
        }

        private void CoderForm_Activated(object sender, EventArgs e)
        {
            luaCodeEditor.Focus();
        }

        private void spritesheetBtn_Click(object sender, EventArgs e)
        {
            if (currentProject.Cart == null)
            {
                MessageBox.Show("The spritesheet is not available until you load a cartridge.", "It's true!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (spritesheetForm != null) spritesheetForm.BringToFront();
            else
            {
                spritesheetForm = new SpritesheetForm(this);
                spritesheetForm.FormClosed += spritesheetForm_FormClosed;
                spritesheetForm.Show();
            }
        }
        
        private void spritesheetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            spritesheetForm = null;
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            if (currentProject.Cart == null)
            {
                MessageBox.Show("The map is not available until you load a cartridge.", "Come on!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (mapForm != null) mapForm.BringToFront();
            else
            {
                mapForm = new MapForm(this);
                mapForm.FormClosed += mapForm_FormClosed;
                mapForm.Show();
            }
        }

        private void mapForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mapForm = null;
        }

        private void cartInput_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.cartInput, cartInput.Text);
        }

        private void colorsButton_Click(object sender, EventArgs e)
        {
            colorsPicture.Location = new Point(colorsButton.Location.X + colorsButton.Size.Width - colorsPicture.Width, colorsButton.Location.Y);
            colorsPicture.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            colorsPicture.Visible = false;
        }

        private void apiButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://pico-8.github.io/pico8-api/");            
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/movAX13h/P8Coder");
        }

        private void cartInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cartInput.Text != "" && File.Exists(cartInput.Text))
                Process.Start("explorer.exe", "/select, " + cartInput.Text);
        }

        private void pico8LaunchSettingsBtn_Click(object sender, EventArgs e)
        {
            LaunchSettingsForm f = new LaunchSettingsForm(Settings);
            f.ShowDialog(this);
        }

        private void themeSwitchBtn_Click(object sender, EventArgs e)
        {
            darkSyntaxColors(!darkTheme);
        }

    }
}
