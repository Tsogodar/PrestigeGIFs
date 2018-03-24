using System;
using System.Windows.Forms;

namespace PG2
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            string logged = new API().login(login, password);

            if (logged != "null")
            {
                var loggedMainForm = new loggedMainForm(login);
                loggedMainForm.Show();
                Visible = false;
            }
            else
            {
                LoginErrorLabel.Text = "Błędne dane logowania";
            }
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new Rejestracja();
            registerForm.Show();
            Visible = false;
        }

        private void backToMainLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = new mainForm();
            mainForm.Show();
            this.Dispose();
        }
    }
}
