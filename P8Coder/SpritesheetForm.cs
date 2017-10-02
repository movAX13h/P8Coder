using P8Coder.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P8Coder
{
    public partial class SpritesheetForm : Form
    {
        private CoderForm coderForm;
        private int border = 4;
        private int zoom = 2;

        private int selectedSpriteIndex = 0;
        private int selectedSpriteX = 0;
        private int selectedSpriteY = 0;

        public SpritesheetForm(CoderForm cForm)
        {
            coderForm = cForm;
            InitializeComponent();

            // enable double buffering for canvasPanel
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, canvasPanel, new object[] { true });
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.Gray);

            if (coderForm.CurrentProject == null || coderForm.CurrentProject.Cart == null) return;

            int s = 8 * zoom;

            g.SmoothingMode = SmoothingMode.None;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            // draw spritesheet
            g.DrawImage(coderForm.CurrentProject.Cart.SpriteSheet, border, border, 128 * zoom, 128 * zoom);

            // selection rectangle
            int sx = selectedSpriteX * s - 1 + border;
            int sy = selectedSpriteY * s - 1 + border;
            Pen p = new Pen(Brushes.Red, 2);
            g.DrawRectangle(p, new Rectangle(sx, sy, s, s));
        }

        private void setZoom(int z)
        {
            zoom = z;
            switch (zoom)
            {
                default:
                case 2:
                    Size = new Size(305, 375);
                    break;
                case 3:
                    Size = new Size(434, 504);
                    break;
                case 4:
                    Size = new Size(561, 631);
                    break;
                
            }

            canvasPanel.Invalidate();
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            processClick(e.X, e.Y);
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left) return;
            processClick(e.X, e.Y);
        }

        private void processClick(int mx, int my)
        {
            mx -= border;
            my -= border;

            int s = 128 * zoom;
            int x = (int)Math.Floor(128f * mx / s);
            int y = (int)Math.Floor(128f * my / s);

            int sx = (int)Math.Floor(x / 8f);
            int sy = (int)Math.Floor(y / 8f);

            if (sx > 15 || sx < 0) return;
            if (sy > 15 || sy < 0) return;

            selectedSpriteX = sx;
            selectedSpriteY = sy;
            selectedSpriteIndex = selectedSpriteX + selectedSpriteY * 16;

            selectionLabel.Text = //x.ToString() + "/" + y.ToString() + " -> " +
                "ID: " + selectedSpriteIndex.ToString() + "    " +
                "cell: " + selectedSpriteX.ToString() + "/" + selectedSpriteY.ToString() + "    " +
                "px: " + (selectedSpriteX * 8).ToString() + "/" + (selectedSpriteY * 8).ToString();

            Refresh();
        }

        public void UpdateImage()
        {
            canvasPanel.Invalidate();
        }

        private void SpritesheetForm_Activated(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void topCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = topCheckbox.Checked;
        }

        private void zoomStatusDropDown_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            zoomStatusDropDown.Text = "Zoom " + e.ClickedItem.Text;
            int id = zoomStatusDropDown.DropDownItems.IndexOf(e.ClickedItem);
            setZoom(id + 2);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "png files (*.png)|*.png";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                coderForm.CurrentProject.Cart.SpriteSheet.Save(saveFileDialog1.FileName);
            }
        }
    }
}
