namespace PG2
{
    partial class Rejestracja
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
            this.RegisterMessageLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginBoxLabel = new System.Windows.Forms.Label();
            this.loginFormLink = new System.Windows.Forms.LinkLabel();
            this.backToMainLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // RegisterMessageLabel
            // 
            this.RegisterMessageLabel.AutoSize = true;
            this.RegisterMessageLabel.Location = new System.Drawing.Point(81, 133);
            this.RegisterMessageLabel.Name = "RegisterMessageLabel";
            this.RegisterMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.RegisterMessageLabel.TabIndex = 13;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(96, 152);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "Zarejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(84, 97);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hasło";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(84, 53);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 9;
            // 
            // loginBoxLabel
            // 
            this.loginBoxLabel.AutoSize = true;
            this.loginBoxLabel.Location = new System.Drawing.Point(81, 37);
            this.loginBoxLabel.Name = "loginBoxLabel";
            this.loginBoxLabel.Size = new System.Drawing.Size(33, 13);
            this.loginBoxLabel.TabIndex = 8;
            this.loginBoxLabel.Text = "Login";
            // 
            // loginFormLink
            // 
            this.loginFormLink.AutoSize = true;
            this.loginFormLink.Location = new System.Drawing.Point(103, 197);
            this.loginFormLink.Name = "loginFormLink";
            this.loginFormLink.Size = new System.Drawing.Size(59, 13);
            this.loginFormLink.TabIndex = 14;
            this.loginFormLink.TabStop = true;
            this.loginFormLink.Text = "Logowanie";
            this.loginFormLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginFormLink_LinkClicked);
            // 
            // backToMainLink
            // 
            this.backToMainLink.AutoSize = true;
            this.backToMainLink.Location = new System.Drawing.Point(115, 220);
            this.backToMainLink.Name = "backToMainLink";
            this.backToMainLink.Size = new System.Drawing.Size(33, 13);
            this.backToMainLink.TabIndex = 15;
            this.backToMainLink.TabStop = true;
            this.backToMainLink.Text = "Wróć";
            this.backToMainLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backToMainLink_LinkClicked);
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backToMainLink);
            this.Controls.Add(this.loginFormLink);
            this.Controls.Add(this.RegisterMessageLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginBoxLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Rejestracja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja";
            this.Load += new System.EventHandler(this.Rejestracja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RegisterMessageLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginBoxLabel;
        private System.Windows.Forms.LinkLabel loginFormLink;
        private System.Windows.Forms.LinkLabel backToMainLink;
    }
}