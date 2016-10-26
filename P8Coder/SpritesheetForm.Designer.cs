namespace P8Coder
{
    partial class SpritesheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpritesheetForm));
            this.selectionLabel = new System.Windows.Forms.Label();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.topCheckbox = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.zoomStatusDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.zoom2Item = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom3Item = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom4Item = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(12, 12);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(168, 13);
            this.selectionLabel.TabIndex = 0;
            this.selectionLabel.Text = "Click on the sheet to show details!";
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.AutoSize = true;
            this.canvasPanel.Location = new System.Drawing.Point(13, 34);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(262, 262);
            this.canvasPanel.TabIndex = 22;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseMove);
            // 
            // topCheckbox
            // 
            this.topCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.topCheckbox.AutoSize = true;
            this.topCheckbox.Checked = true;
            this.topCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topCheckbox.Location = new System.Drawing.Point(195, 318);
            this.topCheckbox.Name = "topCheckbox";
            this.topCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.topCheckbox.Size = new System.Drawing.Size(91, 17);
            this.topCheckbox.TabIndex = 23;
            this.topCheckbox.Text = "always on top";
            this.topCheckbox.UseVisualStyleBackColor = true;
            this.topCheckbox.CheckedChanged += new System.EventHandler(this.topCheckbox_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomStatusDropDown});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(289, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // zoomStatusDropDown
            // 
            this.zoomStatusDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zoomStatusDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoom2Item,
            this.zoom3Item,
            this.zoom4Item});
            this.zoomStatusDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomStatusDropDown.Name = "zoomStatusDropDown";
            this.zoomStatusDropDown.Size = new System.Drawing.Size(66, 20);
            this.zoomStatusDropDown.Text = "Zoom 2x";
            this.zoomStatusDropDown.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.zoomStatusDropDown_DropDownItemClicked);
            // 
            // zoom2Item
            // 
            this.zoom2Item.Name = "zoom2Item";
            this.zoom2Item.Size = new System.Drawing.Size(85, 22);
            this.zoom2Item.Text = "2x";
            // 
            // zoom3Item
            // 
            this.zoom3Item.Name = "zoom3Item";
            this.zoom3Item.Size = new System.Drawing.Size(85, 22);
            this.zoom3Item.Text = "3x";
            // 
            // zoom4Item
            // 
            this.zoom4Item.Name = "zoom4Item";
            this.zoom4Item.Size = new System.Drawing.Size(85, 22);
            this.zoom4Item.Text = "4x";
            // 
            // SpritesheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 336);
            this.Controls.Add(this.topCheckbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.selectionLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpritesheetForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartridge / Spritesheet";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.SpritesheetForm_Activated);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.CheckBox topCheckbox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton zoomStatusDropDown;
        private System.Windows.Forms.ToolStripMenuItem zoom2Item;
        private System.Windows.Forms.ToolStripMenuItem zoom3Item;
        private System.Windows.Forms.ToolStripMenuItem zoom4Item;
    }
}