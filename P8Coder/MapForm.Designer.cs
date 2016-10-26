namespace P8Coder
{
    partial class MapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.selectionLabel = new System.Windows.Forms.Label();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.topCheckbox = new System.Windows.Forms.CheckBox();
            this.zoomStatusDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.zoom1Item = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom2Item = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom3Item = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom4Item = new System.Windows.Forms.ToolStripMenuItem();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.zoomStatus = new System.Windows.Forms.StatusStrip();
            this.containerPanel.SuspendLayout();
            this.zoomStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectionLabel
            // 
            this.selectionLabel.AutoSize = true;
            this.selectionLabel.Location = new System.Drawing.Point(9, 10);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(250, 13);
            this.selectionLabel.TabIndex = 0;
            this.selectionLabel.Text = "Click on the map to show details about the location!";
            // 
            // canvasPanel
            // 
            this.canvasPanel.AutoSize = true;
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(974, 462);
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
            this.topCheckbox.Location = new System.Drawing.Point(926, 560);
            this.topCheckbox.Name = "topCheckbox";
            this.topCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.topCheckbox.Size = new System.Drawing.Size(91, 17);
            this.topCheckbox.TabIndex = 23;
            this.topCheckbox.Text = "always on top";
            this.topCheckbox.UseVisualStyleBackColor = true;
            this.topCheckbox.CheckedChanged += new System.EventHandler(this.topCheckbox_CheckedChanged);
            // 
            // zoomStatusDropDown
            // 
            this.zoomStatusDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zoomStatusDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoom1Item,
            this.zoom2Item,
            this.zoom3Item,
            this.zoom4Item});
            this.zoomStatusDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomStatusDropDown.Name = "zoomStatusDropDown";
            this.zoomStatusDropDown.Size = new System.Drawing.Size(66, 20);
            this.zoomStatusDropDown.Text = "Zoom 1x";
            this.zoomStatusDropDown.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.zoomStatusDropDown_DropDownItemClicked);
            // 
            // zoom1Item
            // 
            this.zoom1Item.Name = "zoom1Item";
            this.zoom1Item.Size = new System.Drawing.Size(152, 22);
            this.zoom1Item.Text = "1x";
            // 
            // zoom2Item
            // 
            this.zoom2Item.Name = "zoom2Item";
            this.zoom2Item.Size = new System.Drawing.Size(152, 22);
            this.zoom2Item.Text = "2x";
            // 
            // zoom3Item
            // 
            this.zoom3Item.Name = "zoom3Item";
            this.zoom3Item.Size = new System.Drawing.Size(152, 22);
            this.zoom3Item.Text = "3x";
            // 
            // zoom4Item
            // 
            this.zoom4Item.Name = "zoom4Item";
            this.zoom4Item.Size = new System.Drawing.Size(152, 22);
            this.zoom4Item.Text = "4x";
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.AutoScroll = true;
            this.containerPanel.Controls.Add(this.canvasPanel);
            this.containerPanel.Location = new System.Drawing.Point(0, 32);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1037, 522);
            this.containerPanel.TabIndex = 25;
            // 
            // zoomStatus
            // 
            this.zoomStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomStatusDropDown});
            this.zoomStatus.Location = new System.Drawing.Point(0, 556);
            this.zoomStatus.Name = "zoomStatus";
            this.zoomStatus.Size = new System.Drawing.Size(1037, 22);
            this.zoomStatus.TabIndex = 24;
            this.zoomStatus.Text = "statusStrip1";
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 578);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.topCheckbox);
            this.Controls.Add(this.zoomStatus);
            this.Controls.Add(this.selectionLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartridge / Map";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.SpritesheetForm_Activated);
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.zoomStatus.ResumeLayout(false);
            this.zoomStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.CheckBox topCheckbox;
        private System.Windows.Forms.ToolStripDropDownButton zoomStatusDropDown;
        private System.Windows.Forms.ToolStripMenuItem zoom2Item;
        private System.Windows.Forms.ToolStripMenuItem zoom3Item;
        private System.Windows.Forms.ToolStripMenuItem zoom4Item;
        private System.Windows.Forms.ToolStripMenuItem zoom1Item;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.StatusStrip zoomStatus;
    }
}