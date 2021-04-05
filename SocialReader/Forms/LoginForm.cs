using System;
using System.Windows.Forms;
using SocialReader.Forms;
using SocialReader.objects;

namespace SocialReader
{
	public partial class LoginForm : Form
	{
        private readonly Program program;
		public LoginForm(Program program)
		{
            this.program = program;
			InitializeComponent();
		}

        bool authenticated = false;
        int attempts = 0;

        private void buttonLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;

            CheckAuthentication(username, password);
		}

        private void CheckAuthentication(string username, string password)
        {
            if (!authenticated && attempts < 3)
            {
                var account = CheckCredentials(username, password);
                var isValid = account != null;
                if (isValid)
                {
                    authenticated = true;
                    program.session.CreateSession(account);

                    var homeForm = new UsersForm(program);
                    Visible = false;
                    homeForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    attempts++;
                    if (attempts >= 3)
                    {
                        MessageBox.Show("You've reached 3 login attempts!\nExiting now...");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password. Please try again!");
                    }
                }
            }
        }

        private Account CheckCredentials(string username, string password)
        {
            var account = this.program.IsValidEmail(username) ? this.program.AccountDao.GetByEmail(username) : this.program.AccountDao.GetByUsername(username);
            if (account == null)
            {
                //Console.WriteLine("Could not find account by that username of email!");
                return null;
            }

            if ((account.Username.Equals(username, StringComparison.OrdinalIgnoreCase) ||
                    account.Email.Equals(username, StringComparison.OrdinalIgnoreCase)) && account.Password == password)
            {
                return account;
            }
            return null;
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm(program);
            Visible = false;
            registerForm.ShowDialog();
            this.Close();
        }
    }
}