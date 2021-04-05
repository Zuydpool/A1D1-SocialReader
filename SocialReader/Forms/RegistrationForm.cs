using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SocialReader.objects;

namespace SocialReader.Forms
{
    public partial class RegisterForm : Form 
    {
        private readonly Program program;
        public RegisterForm(Program program)
        {
            this.program = program;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (!program.IsValidEmail(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter a valid email, username and password.");
                return;
            }

            var newAccount = new Account { Email = email, Username = username, Password = password, Users = new List<User>() };
            //newAccount.AddUser(newUser);
            var accountId = program.AccountDao.Create(newAccount);
            var newUser = new User { Name = username, DateOfBirth = new DateTime(2000, 5, 30), Registered = DateTime.Now, Language = "Dutch", AccountId = accountId };
            program.UserDao.Create(newUser);
            MessageBox.Show($"Successfully created account {username}!");
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new LoginForm(program);
            Visible = false;
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
