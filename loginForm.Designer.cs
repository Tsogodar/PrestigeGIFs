namespace PG2
{
    partial class Logowanie
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
            this.loginBoxLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.LoginErrorLabel = new System.Windows.Forms.Label();
            this.registerLinkLabel = new System.Windows.Forms.Label();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.backToMainLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // loginBoxLabel
            // 
            this.loginBoxLabel.AutoSize = true;
            this.loginBoxLabel.Location = new System.Drawing.Point(81, 38);
            this.loginBoxLabel.Name = "loginBoxLabel";
            this.loginBoxLabel.Size = new System.Drawing.Size(33, 13);
            this.loginBoxLabel.TabIndex = 0;
            this.loginBoxLabel.Text = "Login";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(84, 54);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasło";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(84, 98);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(96, 153);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginErrorLabel
            // 
            this.LoginErrorLabel.AutoSize = true;
            this.LoginErrorLabel.Location = new System.Drawing.Point(81, 133);
            this.LoginErrorLabel.Name = "LoginErrorLabel";
            this.LoginErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.LoginErrorLabel.TabIndex = 5;
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.Location = new System.Drawing.Point(50, 196);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(86, 13);
            this.registerLinkLabel.TabIndex = 6;
            this.registerLinkLabel.Text = "Nie masz konta?";
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Location = new System.Drawing.Point(143, 196);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(72, 13);
            this.registerLink.TabIndex = 7;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Zarejestruj się";
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // backToMainLink
            // 
            this.backToMainLink.AutoSize = true;
            this.backToMainLink.Location = new System.Drawing.Point(115, 220);
            this.backToMainLink.Name = "backToMainLink";
            this.backToMainLink.Size = new System.Drawing.Size(33, 13);
            this.backToMainLink.TabIndex = 16;
            this.backToMainLink.TabStop = true;
            this.backToMainLink.Text = "Wróć";
            this.backToMainLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backToMainLink_LinkClicked);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backToMainLink);
            this.Controls.Add(this.registerLink);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.LoginErrorLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginBoxLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginBoxLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label LoginErrorLabel;
        private System.Windows.Forms.Label registerLinkLabel;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.LinkLabel backToMainLink;
    }
}