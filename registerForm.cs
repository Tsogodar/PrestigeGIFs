using System;
using System.Windows.Forms;

namespace PG2
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }

        private void loginFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new Logowanie();
            loginForm.Show();
            Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            string registered=new API().register(login, password);

            if (registered != "null")
            {
                RegisterMessageLabel.Text = "Pomyślnie zarejestrowano";
            }
            else
            {
                RegisterMessageLabel.Text = "Login zajęty";
            }
        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }

        private void backToMainLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = new mainForm();
            mainForm.Show();
            this.Dispose();
        }
    }
}
