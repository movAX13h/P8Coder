namespace P8Coder
{
    partial class CoderForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoderForm));
            this.saveBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.projectNameInput = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.openProjectDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveProjectDialog = new System.Windows.Forms.SaveFileDialog();
            this.entitiesList = new System.Windows.Forms.CheckedListBox();
            this.codeTabs = new System.Windows.Forms.Panel();
            this.addEntityBtn = new System.Windows.Forms.Button();
            this.delEntityBtn = new System.Windows.Forms.Button();
            this.entitiesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEntityItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delEntityItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameEntityItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEntityBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.asmBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cartInput = new System.Windows.Forms.TextBox();
            this.cartSelBtn = new System.Windows.Forms.Button();
            this.openCartDialog = new System.Windows.Forms.OpenFileDialog();
            this.entityUpBtn = new System.Windows.Forms.Button();
            this.entityDownBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selectPico8Dialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.terminalListBox = new System.Windows.Forms.ListBox();
            this.spritesheetBtn = new System.Windows.Forms.Button();
            this.mapButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.colorsButton = new System.Windows.Forms.Button();
            this.apiButton = new System.Windows.Forms.Button();
            this.githubButton = new System.Windows.Forms.Button();
            this.pico8LaunchSettingsBtn = new System.Windows.Forms.Button();
            this.themeSwitchBtn = new System.Windows.Forms.Button();
            this.colorsPicture = new System.Windows.Forms.PictureBox();
            this.luaCodeEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.entitiesContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luaCodeEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::P8Coder.Properties.Resources.bot;
            this.saveBtn.Location = new System.Drawing.Point(13, 87);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(158, 33);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = " &SAVE";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.saveBtn, "Save P8Coder Project (Ctrl+S)");
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Image = global::P8Coder.Properties.Resources.bot_inv;
            this.newBtn.Location = new System.Drawing.Point(13, 12);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(158, 34);
            this.newBtn.TabIndex = 2;
            this.newBtn.Text = "NEW";
            this.newBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.newBtn, "New P8Coder project");
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game author";
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(12, 241);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(159, 20);
            this.authorInput.TabIndex = 2;
            this.authorInput.TextChanged += new System.EventHandler(this.projectInputChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game name";
            // 
            // projectNameInput
            // 
            this.projectNameInput.Location = new System.Drawing.Point(12, 203);
            this.projectNameInput.Name = "projectNameInput";
            this.projectNameInput.Size = new System.Drawing.Size(159, 20);
            this.projectNameInput.TabIndex = 0;
            this.projectNameInput.TextChanged += new System.EventHandler(this.projectInputChanged);
            // 
            // loadBtn
            // 
            this.loadBtn.Image = global::P8Coder.Properties.Resources.components;
            this.loadBtn.Location = new System.Drawing.Point(13, 50);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(158, 33);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "&LOAD";
            this.loadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.loadBtn, "Load P8Coder project (Ctrl+L)");
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // openProjectDialog
            // 
            this.openProjectDialog.FileName = "*.p8c";
            this.openProjectDialog.Filter = "P8 Coder Project|*.p8c";
            // 
            // saveProjectDialog
            // 
            this.saveProjectDialog.Filter = "P8 Coder Project|*.p8c";
            // 
            // entitiesList
            // 
            this.entitiesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.entitiesList.FormattingEnabled = true;
            this.entitiesList.Location = new System.Drawing.Point(13, 362);
            this.entitiesList.Name = "entitiesList";
            this.entitiesList.Size = new System.Drawing.Size(108, 214);
            this.entitiesList.TabIndex = 5;
            this.entitiesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.entitiesList_ItemCheck);
            this.entitiesList.SelectedIndexChanged += new System.EventHandler(this.entitiesList_SelectedIndexChanged);
            // 
            // codeTabs
            // 
            this.codeTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTabs.Location = new System.Drawing.Point(200, 13);
            this.codeTabs.Name = "codeTabs";
            this.codeTabs.Size = new System.Drawing.Size(602, 29);
            this.codeTabs.TabIndex = 7;
            // 
            // addEntityBtn
            // 
            this.addEntityBtn.Location = new System.Drawing.Point(126, 362);
            this.addEntityBtn.Name = "addEntityBtn";
            this.addEntityBtn.Size = new System.Drawing.Size(45, 23);
            this.addEntityBtn.TabIndex = 8;
            this.addEntityBtn.Text = "ADD";
            this.addEntityBtn.UseVisualStyleBackColor = true;
            this.addEntityBtn.Click += new System.EventHandler(this.addEntityBtn_Click);
            // 
            // delEntityBtn
            // 
            this.delEntityBtn.Location = new System.Drawing.Point(126, 391);
            this.delEntityBtn.Name = "delEntityBtn";
            this.delEntityBtn.Size = new System.Drawing.Size(45, 23);
            this.delEntityBtn.TabIndex = 9;
            this.delEntityBtn.Text = "DEL";
            this.delEntityBtn.UseVisualStyleBackColor = true;
            this.delEntityBtn.Click += new System.EventHandler(this.delEntityBtn_Click);
            // 
            // entitiesContextMenu
            // 
            this.entitiesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEntityItem,
            this.delEntityItem,
            this.renameEntityItem});
            this.entitiesContextMenu.Name = "entitiesContextMenu";
            this.entitiesContextMenu.Size = new System.Drawing.Size(151, 70);
            // 
            // addEntityItem
            // 
            this.addEntityItem.Name = "addEntityItem";
            this.addEntityItem.Size = new System.Drawing.Size(150, 22);
            this.addEntityItem.Text = "Add Entity";
            // 
            // delEntityItem
            // 
            this.delEntityItem.Name = "delEntityItem";
            this.delEntityItem.Size = new System.Drawing.Size(150, 22);
            this.delEntityItem.Text = "Delete Entity";
            // 
            // renameEntityItem
            // 
            this.renameEntityItem.Name = "renameEntityItem";
            this.renameEntityItem.Size = new System.Drawing.Size(150, 22);
            this.renameEntityItem.Text = "Rename Entity";
            // 
            // editEntityBtn
            // 
            this.editEntityBtn.Location = new System.Drawing.Point(126, 420);
            this.editEntityBtn.Name = "editEntityBtn";
            this.editEntityBtn.Size = new System.Drawing.Size(45, 23);
            this.editEntityBtn.TabIndex = 11;
            this.editEntityBtn.Text = "EDIT";
            this.editEntityBtn.UseVisualStyleBackColor = true;
            this.editEntityBtn.Click += new System.EventHandler(this.editEntityBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Entities";
            // 
            // asmBtn
            // 
            this.asmBtn.Image = global::P8Coder.Properties.Resources.pico8;
            this.asmBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.asmBtn.Location = new System.Drawing.Point(13, 124);
            this.asmBtn.Name = "asmBtn";
            this.asmBtn.Size = new System.Drawing.Size(158, 46);
            this.asmBtn.TabIndex = 13;
            this.asmBtn.Text = "BUILD && RUN";
            this.asmBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.asmBtn, "Build and run cartridge in pico-8 (Alt+Return)");
            this.asmBtn.UseVisualStyleBackColor = true;
            this.asmBtn.Click += new System.EventHandler(this.asmBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cartridge";
            // 
            // cartInput
            // 
            this.cartInput.Location = new System.Drawing.Point(12, 280);
            this.cartInput.Name = "cartInput";
            this.cartInput.ReadOnly = true;
            this.cartInput.Size = new System.Drawing.Size(159, 20);
            this.cartInput.TabIndex = 14;
            this.cartInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cartInput_MouseDoubleClick);
            this.cartInput.MouseHover += new System.EventHandler(this.cartInput_MouseHover);
            // 
            // cartSelBtn
            // 
            this.cartSelBtn.Image = global::P8Coder.Properties.Resources.pico8;
            this.cartSelBtn.Location = new System.Drawing.Point(69, 306);
            this.cartSelBtn.Name = "cartSelBtn";
            this.cartSelBtn.Size = new System.Drawing.Size(30, 30);
            this.cartSelBtn.TabIndex = 16;
            this.toolTip.SetToolTip(this.cartSelBtn, "Select Cartridge (.p8)");
            this.cartSelBtn.UseVisualStyleBackColor = true;
            this.cartSelBtn.Click += new System.EventHandler(this.cartSelBtn_Click);
            // 
            // openCartDialog
            // 
            this.openCartDialog.FileName = "*.p8";
            this.openCartDialog.Filter = "pico8 carts|*.p8";
            this.openCartDialog.RestoreDirectory = true;
            this.openCartDialog.Title = "Select the cartridge you want to program with P8Coder";
            // 
            // entityUpBtn
            // 
            this.entityUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityUpBtn.Location = new System.Drawing.Point(126, 454);
            this.entityUpBtn.Name = "entityUpBtn";
            this.entityUpBtn.Size = new System.Drawing.Size(45, 40);
            this.entityUpBtn.TabIndex = 17;
            this.entityUpBtn.Text = "↑";
            this.entityUpBtn.UseVisualStyleBackColor = true;
            this.entityUpBtn.Click += new System.EventHandler(this.entityUpBtn_Click);
            // 
            // entityDownBtn
            // 
            this.entityDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entityDownBtn.Location = new System.Drawing.Point(126, 500);
            this.entityDownBtn.Name = "entityDownBtn";
            this.entityDownBtn.Size = new System.Drawing.Size(45, 40);
            this.entityDownBtn.TabIndex = 18;
            this.entityDownBtn.Text = "↓";
            this.entityDownBtn.UseVisualStyleBackColor = true;
            this.entityDownBtn.Click += new System.EventHandler(this.entityDownBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(123, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "F1/F2";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(820, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Alt+F1/F2";
            // 
            // selectPico8Dialog
            // 
            this.selectPico8Dialog.FileName = "pico8.exe";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.terminalListBox);
            this.panel1.Location = new System.Drawing.Point(177, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 49);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // terminalListBox
            // 
            this.terminalListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.terminalListBox.FormattingEnabled = true;
            this.terminalListBox.Location = new System.Drawing.Point(3, 3);
            this.terminalListBox.Name = "terminalListBox";
            this.terminalListBox.Size = new System.Drawing.Size(707, 43);
            this.terminalListBox.TabIndex = 1;
            // 
            // spritesheetBtn
            // 
            this.spritesheetBtn.Image = global::P8Coder.Properties.Resources.sprite;
            this.spritesheetBtn.Location = new System.Drawing.Point(105, 306);
            this.spritesheetBtn.Name = "spritesheetBtn";
            this.spritesheetBtn.Size = new System.Drawing.Size(30, 30);
            this.spritesheetBtn.TabIndex = 16;
            this.toolTip.SetToolTip(this.spritesheetBtn, "Show Spritesheet");
            this.spritesheetBtn.UseVisualStyleBackColor = true;
            this.spritesheetBtn.Click += new System.EventHandler(this.spritesheetBtn_Click);
            // 
            // mapButton
            // 
            this.mapButton.Image = global::P8Coder.Properties.Resources.map;
            this.mapButton.Location = new System.Drawing.Point(141, 306);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(30, 30);
            this.mapButton.TabIndex = 22;
            this.toolTip.SetToolTip(this.mapButton, "Show Map");
            this.mapButton.UseVisualStyleBackColor = true;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // colorsButton
            // 
            this.colorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorsButton.Image = global::P8Coder.Properties.Resources.colors1;
            this.colorsButton.Location = new System.Drawing.Point(880, 14);
            this.colorsButton.Name = "colorsButton";
            this.colorsButton.Size = new System.Drawing.Size(24, 24);
            this.colorsButton.TabIndex = 23;
            this.toolTip.SetToolTip(this.colorsButton, "Show pico-8 color table");
            this.colorsButton.UseVisualStyleBackColor = true;
            this.colorsButton.Click += new System.EventHandler(this.colorsButton_Click);
            // 
            // apiButton
            // 
            this.apiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apiButton.Image = global::P8Coder.Properties.Resources.pico8_api;
            this.apiButton.Location = new System.Drawing.Point(961, 14);
            this.apiButton.Name = "apiButton";
            this.apiButton.Size = new System.Drawing.Size(24, 24);
            this.apiButton.TabIndex = 25;
            this.toolTip.SetToolTip(this.apiButton, "Open API cheatsheet by neko250");
            this.apiButton.UseVisualStyleBackColor = true;
            this.apiButton.Click += new System.EventHandler(this.apiButton_Click);
            // 
            // githubButton
            // 
            this.githubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.githubButton.Image = global::P8Coder.Properties.Resources.github;
            this.githubButton.Location = new System.Drawing.Point(988, 14);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(24, 24);
            this.githubButton.TabIndex = 26;
            this.toolTip.SetToolTip(this.githubButton, "Open P8Coder GitHub page");
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // pico8LaunchSettingsBtn
            // 
            this.pico8LaunchSettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pico8LaunchSettingsBtn.Image = global::P8Coder.Properties.Resources.pico8params;
            this.pico8LaunchSettingsBtn.Location = new System.Drawing.Point(907, 14);
            this.pico8LaunchSettingsBtn.Name = "pico8LaunchSettingsBtn";
            this.pico8LaunchSettingsBtn.Size = new System.Drawing.Size(24, 24);
            this.pico8LaunchSettingsBtn.TabIndex = 27;
            this.toolTip.SetToolTip(this.pico8LaunchSettingsBtn, "pico-8 launch parameters");
            this.pico8LaunchSettingsBtn.UseVisualStyleBackColor = true;
            this.pico8LaunchSettingsBtn.Click += new System.EventHandler(this.pico8LaunchSettingsBtn_Click);
            // 
            // themeSwitchBtn
            // 
            this.themeSwitchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themeSwitchBtn.Image = global::P8Coder.Properties.Resources.theme;
            this.themeSwitchBtn.Location = new System.Drawing.Point(934, 14);
            this.themeSwitchBtn.Name = "themeSwitchBtn";
            this.themeSwitchBtn.Size = new System.Drawing.Size(24, 24);
            this.themeSwitchBtn.TabIndex = 27;
            this.toolTip.SetToolTip(this.themeSwitchBtn, "toggle dark/bright code editor");
            this.themeSwitchBtn.UseVisualStyleBackColor = true;
            this.themeSwitchBtn.Click += new System.EventHandler(this.themeSwitchBtn_Click);
            // 
            // colorsPicture
            // 
            this.colorsPicture.Image = global::P8Coder.Properties.Resources.colors;
            this.colorsPicture.Location = new System.Drawing.Point(610, 57);
            this.colorsPicture.Name = "colorsPicture";
            this.colorsPicture.Size = new System.Drawing.Size(230, 230);
            this.colorsPicture.TabIndex = 0;
            this.colorsPicture.TabStop = false;
            this.colorsPicture.Visible = false;
            this.colorsPicture.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // luaCodeEditor
            // 
            this.luaCodeEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.luaCodeEditor.AutoCompleteBrackets = true;
            this.luaCodeEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.luaCodeEditor.AutoIndentChars = false;
            this.luaCodeEditor.AutoIndentCharsPatterns = "\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\n";
            this.luaCodeEditor.AutoIndentExistingLines = false;
            this.luaCodeEditor.AutoScrollMinSize = new System.Drawing.Size(35, 14);
            this.luaCodeEditor.BackBrush = null;
            this.luaCodeEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.luaCodeEditor.CharHeight = 14;
            this.luaCodeEditor.CharWidth = 8;
            this.luaCodeEditor.CommentPrefix = "--";
            this.luaCodeEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.luaCodeEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.luaCodeEditor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.luaCodeEditor.HighlightingRangeType = FastColoredTextBoxNS.HighlightingRangeType.VisibleRange;
            this.luaCodeEditor.IsReplaceMode = false;
            this.luaCodeEditor.Language = FastColoredTextBoxNS.Language.Lua;
            this.luaCodeEditor.LeftBracket = '(';
            this.luaCodeEditor.LeftBracket2 = '{';
            this.luaCodeEditor.Location = new System.Drawing.Point(177, 42);
            this.luaCodeEditor.Name = "luaCodeEditor";
            this.luaCodeEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.luaCodeEditor.ReservedCountOfLineNumberChars = 2;
            this.luaCodeEditor.RightBracket = ')';
            this.luaCodeEditor.RightBracket2 = '}';
            this.luaCodeEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.luaCodeEditor.ServiceColors = null;
            this.luaCodeEditor.ServiceLinesColor = System.Drawing.Color.SkyBlue;
            this.luaCodeEditor.Size = new System.Drawing.Size(835, 530);
            this.luaCodeEditor.TabIndex = 0;
            this.luaCodeEditor.TabLength = 2;
            this.luaCodeEditor.TextAreaBorderColor = System.Drawing.Color.Silver;
            this.luaCodeEditor.Zoom = 100;
            this.luaCodeEditor.ToolTipNeeded += new System.EventHandler<FastColoredTextBoxNS.ToolTipNeededEventArgs>(this.luaCodeEditor_ToolTipNeeded);
            this.luaCodeEditor.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.luaCodeEditor_TextChanged);
            // 
            // CoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 586);
            this.Controls.Add(this.colorsPicture);
            this.Controls.Add(this.colorsButton);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.mapButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.entityDownBtn);
            this.Controls.Add(this.entityUpBtn);
            this.Controls.Add(this.spritesheetBtn);
            this.Controls.Add(this.cartSelBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cartInput);
            this.Controls.Add(this.asmBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editEntityBtn);
            this.Controls.Add(this.delEntityBtn);
            this.Controls.Add(this.projectNameInput);
            this.Controls.Add(this.addEntityBtn);
            this.Controls.Add(this.entitiesList);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.codeTabs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.luaCodeEditor);
            this.Controls.Add(this.apiButton);
            this.Controls.Add(this.themeSwitchBtn);
            this.Controls.Add(this.pico8LaunchSettingsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(700, 620);
            this.Name = "CoderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P8 Coder";
            this.Activated += new System.EventHandler(this.CoderForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoderForm_FormClosing);
            this.Shown += new System.EventHandler(this.CoderForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoderForm_KeyDown);
            this.entitiesContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luaCodeEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox luaCodeEditor;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox projectNameInput;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.OpenFileDialog openProjectDialog;
        private System.Windows.Forms.SaveFileDialog saveProjectDialog;
        private System.Windows.Forms.CheckedListBox entitiesList;
        private System.Windows.Forms.Panel codeTabs;
        private System.Windows.Forms.Button addEntityBtn;
        private System.Windows.Forms.Button delEntityBtn;
        private System.Windows.Forms.ContextMenuStrip entitiesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addEntityItem;
        private System.Windows.Forms.ToolStripMenuItem delEntityItem;
        private System.Windows.Forms.ToolStripMenuItem renameEntityItem;
        private System.Windows.Forms.Button editEntityBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button asmBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cartInput;
        private System.Windows.Forms.Button cartSelBtn;
        private System.Windows.Forms.OpenFileDialog openCartDialog;
        private System.Windows.Forms.Button entityUpBtn;
        private System.Windows.Forms.Button entityDownBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog selectPico8Dialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox terminalListBox;
        private System.Windows.Forms.Button spritesheetBtn;
        private System.Windows.Forms.Button mapButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button colorsButton;
        private System.Windows.Forms.PictureBox colorsPicture;
        private System.Windows.Forms.Button apiButton;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.Button pico8LaunchSettingsBtn;
        private System.Windows.Forms.Button themeSwitchBtn;
    }
}

