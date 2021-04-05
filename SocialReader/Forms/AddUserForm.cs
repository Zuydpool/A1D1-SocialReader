using System;
using System.Threading;
using System.Windows.Forms;
using SocialReader.objects;

namespace SocialReader.Forms
{
    public partial class AddUserForm : Form
    {
        private readonly Program program;
        public AddUserForm(Program program)
        {
            this.program = program;
            InitializeComponent();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            var account = program.session.GetAccount();
            var name = nameTextBox.Text;
            var dateOfBirth = dateOfBirthLabel.Text;
            var language = languageTextBox.Text;

            if (account == null)
            {
                MessageBox.Show("Invalid session detected.");
                Thread.Sleep(2000);
                Application.Exit();
                return;
            }

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Enter a valid name and language.");
                return;
            }

            var newUser = new User { Name = name, DateOfBirth = new DateTime(2000, 5, 30), Registered = DateTime.Now, Language = language, AccountId = account.Id };
            program.UserDao.Create(newUser);
            account.AddUser(newUser);
            MessageBox.Show($"Successfully created user {name}.");

            var usersForm = new UsersForm(program);
            Visible = false;
            usersForm.ShowDialog();
            this.Close();
        }
    }
}