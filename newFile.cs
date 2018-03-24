using System;
using System.Drawing;
using System.Windows.Forms;

namespace PG2
{
    public partial class newFile : Form
    {
        Image globalImage;
        string globalImageName;
        string user;
        string scope = "private";
        public newFile(Image image,string name,string loggedUser)
        {
            InitializeComponent();
            uploadPictureBox.Image = image;
            uploadPictureBox.BorderStyle = BorderStyle.FixedSingle;
            uploadPictureBox.BackColor = Color.FromArgb(255, 255, 255);
            nameFileLabel.Text =name;
            globalImage = image;
            globalImageName = name;
            user = loggedUser;
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            string exist = new API().exists(user, globalImageName);
            if (exist == "false")
            {
                string result = new API().saveFileData(user, globalImageName, scope);
                if (result == "true")
                {
                    string uploadsPath = "C:\\Users\\Marcin\\Desktop\\PG2\\uploads\\" + globalImageName;
                    uploadPictureBox.Image.Save(uploadsPath);
                    var loggedMainForm = new loggedMainForm(user);
                    loggedMainForm.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Plik o takiej nazwie już istnieje");
            }
        }

        private void scopeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (scope == "private")
            {
                scope = "public";
            }
            else
            {
                scope = "private";
            }
        }
    }
}
