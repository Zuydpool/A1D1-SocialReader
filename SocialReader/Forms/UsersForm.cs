using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace SocialReader.Forms
{
    public partial class UsersForm : Form
    {
        private Program program;
        public UsersForm(Program program)
        {
            this.program = program;
            InitializeComponent();
        }

        public void LoadPictureBoxes()
        {
            var i = 1;
            var pictureX = 50;
            var labelX = 85;
            foreach (var user in program.session.GetAccount().Users)
            {
                if (i == 4) break;
                if (i == 2)
                {
                    pictureX = 170;
                    labelX = 205;
                }
                if (i == 3)
                {
                    pictureX = 290;
                    labelX = 325;
                }

                PictureBox pictureBox = new PictureBox
                {
                    Name = user.Name,
                    Location = new Point(pictureX, 30),
                    Size = new Size(100, 100),
                    Image = Image.FromFile(@"C:\unzip\profile.png")
                };
                pictureBox.Click += new EventHandler(userPictureBox_Click);

                Label label = new Label
                {
                    Parent = pictureBox,
                    Text = user.Name,
                    Font = new Font("Roboto", 10),
                    Location = new Point(labelX, 130),
                    AutoSize = true
                };

                Controls.Add(pictureBox);
                Controls.Add(label);
                i++;
            }
        }

        private void userPictureBox_Click(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            var username = pictureBox.Name;
            
            program.session.setSelectedUser(program.session.GetAccount().Users.First(user => user.Name == username));

            var homeForm = new HomeForm(program);
            Visible = false;
            homeForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (program.session.GetAccount().Users.Count >= 3)
            {
                MessageBox.Show("You've reached the maximum limit of users!");
                return;
            }

            var addUserForm = new AddUserForm(program);
            Visible = false;
            addUserForm.ShowDialog();
            this.Close();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            LoadPictureBoxes();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(program);
            Visible = false;
            loginForm.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
