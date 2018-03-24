namespace PG2
{
    partial class newFile
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
            this.uploadPictureBox = new System.Windows.Forms.PictureBox();
            this.addFileButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameFileLabel = new System.Windows.Forms.Label();
            this.scopeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadPictureBox
            // 
            this.uploadPictureBox.Location = new System.Drawing.Point(6, 25);
            this.uploadPictureBox.Name = "uploadPictureBox";
            this.uploadPictureBox.Size = new System.Drawing.Size(372, 361);
            this.uploadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uploadPictureBox.TabIndex = 0;
            this.uploadPictureBox.TabStop = false;
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(264, 392);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(108, 30);
            this.addFileButton.TabIndex = 1;
            this.addFileButton.Text = "Dodaj";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Nazwa:";
            // 
            // nameFileLabel
            // 
            this.nameFileLabel.AutoSize = true;
            this.nameFileLabel.Location = new System.Drawing.Point(45, 9);
            this.nameFileLabel.Name = "nameFileLabel";
            this.nameFileLabel.Size = new System.Drawing.Size(61, 13);
            this.nameFileLabel.TabIndex = 3;
            this.nameFileLabel.Text = "nazwaPliku";
            // 
            // scopeCheckBox
            // 
            this.scopeCheckBox.AutoSize = true;
            this.scopeCheckBox.Location = new System.Drawing.Point(13, 393);
            this.scopeCheckBox.Name = "scopeCheckBox";
            this.scopeCheckBox.Size = new System.Drawing.Size(70, 17);
            this.scopeCheckBox.TabIndex = 4;
            this.scopeCheckBox.Text = "publiczny";
            this.scopeCheckBox.UseVisualStyleBackColor = true;
            this.scopeCheckBox.CheckedChanged += new System.EventHandler(this.scopeCheckBox_CheckedChanged);
            // 
            // newFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 434);
            this.Controls.Add(this.scopeCheckBox);
            this.Controls.Add(this.nameFileLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.uploadPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "newFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload new file";
            ((System.ComponentModel.ISupportInitialize)(this.uploadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox uploadPictureBox;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameFileLabel;
        private System.Windows.Forms.CheckBox scopeCheckBox;
    }
}