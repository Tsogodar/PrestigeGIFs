using System;
using System.Drawing;
using System.Windows.Forms;


namespace PG2
{
    public partial class mainForm : Form
    {
        static bool s_bFormOpened = false;

        public mainForm()
        {
            InitializeComponent();
        }

        public dynamic ImageBox(int i, dynamic json, int posX, int posY)
        {
            PictureBox[] Shapes = new PictureBox[json.Count];
            double rows = Math.Ceiling((double)json.Count / 6);
            int modulo = i % 6;
            var file = json[i];

            Shapes[i] = new PictureBox();
            Shapes[i].Name = "pictureBox" + (i + 1).ToString();
            if (i > 0 && modulo == 0)
            {
                posX = 40;
                posY += 120;
            }
            Shapes[i].Location = new System.Drawing.Point(posX, posY);
            Shapes[i].Size = new Size(100, 100);
            Shapes[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            Shapes[i].BackColor = Color.FromArgb(255, 255, 255);
            Shapes[i].BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(Shapes[i]);
            posX += 120;
            string uploadsPath = "C:\\Users\\Marcin\\Desktop\\PG2\\uploads\\" + file.filename.ToString();
            Shapes[i].Image = new Bitmap(uploadsPath);
            int[] positions = new int[2];
            positions[0] = posX;
            positions[1] = posY;

            return positions;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var json = new API().getData("/");
            if (json.Count == 0)
            {
                label1.Show();
            }
            else
            {
                label1.Hide();
                int posX = 41;
                int posY = 40;

                for (int i = 0; i < json.Count; i++)
                {
                    var positions = ImageBox(i, json, posX, posY);
                    posX = positions[0];
                    posY = positions[1];
                }
            }

        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                var loginForm = new Logowanie();
                loginForm.Show();
                loginLabel.Hide();
                Visible = false;
        }

        private void registerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new Rejestracja();
            registerForm.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
