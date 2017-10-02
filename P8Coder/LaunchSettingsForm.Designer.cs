namespace P8Coder
{
    partial class LaunchSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchSettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            this.fullscreenCheckbox = new System.Windows.Forms.CheckBox();
            this.soundLabel = new System.Windows.Forms.Label();
            this.musicLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.joystickInput = new System.Windows.Forms.NumericUpDown();
            this.darkEditorCheckbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gifDurationInput = new System.Windows.Forms.NumericUpDown();
            this.pixelPerfectCheckbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.screenshotScaleInput = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.gifScaleInput = new System.Windows.Forms.NumericUpDown();
            this.showFpsCheckbox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.borderlessCheckbox = new System.Windows.Forms.CheckBox();
            this.soundSlider = new System.Windows.Forms.TrackBar();
            this.musicSlider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joystickInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifDurationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotScaleInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifScaleInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "height";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(138, 41);
            this.widthInput.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(63, 20);
            this.widthInput.TabIndex = 2;
            this.widthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(138, 87);
            this.heightInput.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(63, 20);
            this.heightInput.TabIndex = 3;
            this.heightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fullscreenCheckbox
            // 
            this.fullscreenCheckbox.AutoSize = true;
            this.fullscreenCheckbox.Location = new System.Drawing.Point(19, 24);
            this.fullscreenCheckbox.Name = "fullscreenCheckbox";
            this.fullscreenCheckbox.Size = new System.Drawing.Size(71, 17);
            this.fullscreenCheckbox.TabIndex = 6;
            this.fullscreenCheckbox.Text = "fullscreen";
            this.fullscreenCheckbox.UseVisualStyleBackColor = true;
            // 
            // soundLabel
            // 
            this.soundLabel.AutoSize = true;
            this.soundLabel.Location = new System.Drawing.Point(15, 25);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(68, 13);
            this.soundLabel.TabIndex = 8;
            this.soundLabel.Text = "sound: 100%";
            // 
            // musicLabel
            // 
            this.musicLabel.AutoSize = true;
            this.musicLabel.Location = new System.Drawing.Point(15, 65);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(66, 13);
            this.musicLabel.TabIndex = 10;
            this.musicLabel.Text = "music: 100%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "joystick (0-7)";
            // 
            // joystickInput
            // 
            this.joystickInput.Location = new System.Drawing.Point(18, 119);
            this.joystickInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.joystickInput.Name = "joystickInput";
            this.joystickInput.Size = new System.Drawing.Size(80, 20);
            this.joystickInput.TabIndex = 11;
            this.joystickInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // darkEditorCheckbox
            // 
            this.darkEditorCheckbox.AutoSize = true;
            this.darkEditorCheckbox.Location = new System.Drawing.Point(19, 116);
            this.darkEditorCheckbox.Name = "darkEditorCheckbox";
            this.darkEditorCheckbox.Size = new System.Drawing.Size(99, 17);
            this.darkEditorCheckbox.TabIndex = 15;
            this.darkEditorCheckbox.Text = "dark blue editor";
            this.darkEditorCheckbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "GIF duration";
            // 
            // gifDurationInput
            // 
            this.gifDurationInput.Location = new System.Drawing.Point(18, 119);
            this.gifDurationInput.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.gifDurationInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gifDurationInput.Name = "gifDurationInput";
            this.gifDurationInput.Size = new System.Drawing.Size(54, 20);
            this.gifDurationInput.TabIndex = 16;
            this.gifDurationInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gifDurationInput.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // pixelPerfectCheckbox
            // 
            this.pixelPerfectCheckbox.AutoSize = true;
            this.pixelPerfectCheckbox.Checked = true;
            this.pixelPerfectCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pixelPerfectCheckbox.Location = new System.Drawing.Point(19, 70);
            this.pixelPerfectCheckbox.Name = "pixelPerfectCheckbox";
            this.pixelPerfectCheckbox.Size = new System.Drawing.Size(83, 17);
            this.pixelPerfectCheckbox.TabIndex = 19;
            this.pixelPerfectCheckbox.Text = "pixel perfect";
            this.pixelPerfectCheckbox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "screenshot scale";
            // 
            // screenshotScaleInput
            // 
            this.screenshotScaleInput.Location = new System.Drawing.Point(18, 41);
            this.screenshotScaleInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.screenshotScaleInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.screenshotScaleInput.Name = "screenshotScaleInput";
            this.screenshotScaleInput.Size = new System.Drawing.Size(80, 20);
            this.screenshotScaleInput.TabIndex = 20;
            this.screenshotScaleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.screenshotScaleInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "GIF scale";
            // 
            // gifScaleInput
            // 
            this.gifScaleInput.Location = new System.Drawing.Point(18, 80);
            this.gifScaleInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gifScaleInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gifScaleInput.Name = "gifScaleInput";
            this.gifScaleInput.Size = new System.Drawing.Size(80, 20);
            this.gifScaleInput.TabIndex = 22;
            this.gifScaleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gifScaleInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // showFpsCheckbox
            // 
            this.showFpsCheckbox.AutoSize = true;
            this.showFpsCheckbox.Location = new System.Drawing.Point(19, 93);
            this.showFpsCheckbox.Name = "showFpsCheckbox";
            this.showFpsCheckbox.Size = new System.Drawing.Size(68, 17);
            this.showFpsCheckbox.TabIndex = 24;
            this.showFpsCheckbox.Text = "show fps";
            this.showFpsCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(16, 178);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(468, 33);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.musicSlider);
            this.groupBox1.Controls.Add(this.soundLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.joystickInput);
            this.groupBox1.Controls.Add(this.musicLabel);
            this.groupBox1.Controls.Add(this.soundSlider);
            this.groupBox1.Location = new System.Drawing.Point(241, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 157);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio && Input";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showFpsCheckbox);
            this.groupBox3.Controls.Add(this.pixelPerfectCheckbox);
            this.groupBox3.Controls.Add(this.darkEditorCheckbox);
            this.groupBox3.Controls.Add(this.fullscreenCheckbox);
            this.groupBox3.Controls.Add(this.borderlessCheckbox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.heightInput);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.widthInput);
            this.groupBox3.Location = new System.Drawing.Point(17, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 157);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.gifDurationInput);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.screenshotScaleInput);
            this.groupBox4.Controls.Add(this.gifScaleInput);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(365, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 157);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // borderlessCheckbox
            // 
            this.borderlessCheckbox.AutoSize = true;
            this.borderlessCheckbox.Location = new System.Drawing.Point(19, 47);
            this.borderlessCheckbox.Name = "borderlessCheckbox";
            this.borderlessCheckbox.Size = new System.Drawing.Size(74, 17);
            this.borderlessCheckbox.TabIndex = 25;
            this.borderlessCheckbox.Text = "borderless";
            this.borderlessCheckbox.UseVisualStyleBackColor = true;
            // 
            // soundSlider
            // 
            this.soundSlider.AutoSize = false;
            this.soundSlider.Location = new System.Drawing.Point(6, 41);
            this.soundSlider.Maximum = 256;
            this.soundSlider.Name = "soundSlider";
            this.soundSlider.Size = new System.Drawing.Size(106, 21);
            this.soundSlider.TabIndex = 13;
            this.soundSlider.TickFrequency = 16;
            this.soundSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.soundSlider.Value = 256;
            // 
            // musicSlider
            // 
            this.musicSlider.AutoSize = false;
            this.musicSlider.Location = new System.Drawing.Point(6, 81);
            this.musicSlider.Maximum = 256;
            this.musicSlider.Name = "musicSlider";
            this.musicSlider.Size = new System.Drawing.Size(106, 21);
            this.musicSlider.TabIndex = 14;
            this.musicSlider.TickFrequency = 16;
            this.musicSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.musicSlider.Value = 256;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "sec";
            // 
            // LaunchSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 222);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaunchSettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "pico-8 launch settings";
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joystickInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifDurationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotScaleInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifScaleInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown heightInput;
        private System.Windows.Forms.CheckBox fullscreenCheckbox;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Label musicLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown joystickInput;
        private System.Windows.Forms.CheckBox darkEditorCheckbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown gifDurationInput;
        private System.Windows.Forms.CheckBox pixelPerfectCheckbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown screenshotScaleInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown gifScaleInput;
        private System.Windows.Forms.CheckBox showFpsCheckbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox borderlessCheckbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar musicSlider;
        private System.Windows.Forms.TrackBar soundSlider;
        private System.Windows.Forms.Label label3;
    }
}