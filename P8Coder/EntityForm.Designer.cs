namespace P8Coder
{
    partial class EntityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityForm));
            this.okBtn = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.functionsList = new System.Windows.Forms.CheckedListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.renameBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.funcDownBtn = new System.Windows.Forms.Button();
            this.funcUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(39, 216);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(204, 40);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(39, 36);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(204, 20);
            this.nameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entity name";
            // 
            // functionsList
            // 
            this.functionsList.FormattingEnabled = true;
            this.functionsList.Location = new System.Drawing.Point(39, 77);
            this.functionsList.Name = "functionsList";
            this.functionsList.Size = new System.Drawing.Size(174, 94);
            this.functionsList.TabIndex = 2;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(39, 177);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(44, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(89, 177);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(44, 23);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "DEL";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // renameBtn
            // 
            this.renameBtn.Location = new System.Drawing.Point(178, 177);
            this.renameBtn.Name = "renameBtn";
            this.renameBtn.Size = new System.Drawing.Size(65, 23);
            this.renameBtn.TabIndex = 5;
            this.renameBtn.Text = "RENAME";
            this.renameBtn.UseVisualStyleBackColor = true;
            this.renameBtn.Click += new System.EventHandler(this.renameBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entity functions";
            // 
            // funcDownBtn
            // 
            this.funcDownBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.funcDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcDownBtn.Location = new System.Drawing.Point(219, 127);
            this.funcDownBtn.Name = "funcDownBtn";
            this.funcDownBtn.Size = new System.Drawing.Size(24, 44);
            this.funcDownBtn.TabIndex = 20;
            this.funcDownBtn.Text = "↓";
            this.funcDownBtn.UseVisualStyleBackColor = true;
            this.funcDownBtn.Click += new System.EventHandler(this.funcDownBtn_Click);
            // 
            // funcUpBtn
            // 
            this.funcUpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.funcUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcUpBtn.Location = new System.Drawing.Point(219, 77);
            this.funcUpBtn.Name = "funcUpBtn";
            this.funcUpBtn.Size = new System.Drawing.Size(24, 44);
            this.funcUpBtn.TabIndex = 19;
            this.funcUpBtn.Text = "↑";
            this.funcUpBtn.UseVisualStyleBackColor = true;
            this.funcUpBtn.Click += new System.EventHandler(this.funcUpBtn_Click);
            // 
            // EntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.funcDownBtn);
            this.Controls.Add(this.funcUpBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.renameBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.functionsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntityForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox functionsList;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button renameBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button funcDownBtn;
        private System.Windows.Forms.Button funcUpBtn;
    }
}