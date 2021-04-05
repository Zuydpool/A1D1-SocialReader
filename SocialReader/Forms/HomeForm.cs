using System.Threading;
using System.Windows.Forms;

namespace SocialReader.Forms
{
    public partial class HomeForm : Form
    {
        private Program program;

        public HomeForm(Program program)
        {
            this.program = program;
            if (!program.session.HasSession())
            {
                MessageBox.Show("No session has been made.");
                Thread.Sleep(2000);
                Application.Exit();
                return;
            }

            InitializeComponent();
            label1.Text = program.session.GetUserName();
        }

        private void signOutButton_Click(object sender, System.EventArgs e)
        {
            program.session.TerminateSession();
            var loginForm = new LoginForm(program);
            Visible = false;
            loginForm.ShowDialog();
            this.Close();
        }

        private void TextsLabel_Click(object sender, System.EventArgs e)
        {
            var textsForm = new TextsForm(program);
            Visible = false;
            textsForm.ShowDialog();
            this.Close();
        }

        private void AuthorsLabel_Click(object sender, System.EventArgs e)
        {
            var authorsForm = new AuthorsForm(program);
            Visible = false;
            authorsForm.ShowDialog();
            this.Close();
        }

        private void genresLabel_Click(object sender, System.EventArgs e)
        {
            var genresForm = new GenresForm(program);
            Visible = false;
            genresForm.ShowDialog();
            this.Close();
        }

        private void homeTextsPictureBox_Click(object sender, System.EventArgs e)
        {
            var textsForm = new TextsForm(program);
            Visible = false;
            textsForm.ShowDialog();
            this.Close();
        }

        private void homeAuthorsPictureBox_Click(object sender, System.EventArgs e)
        {
            var authorsForm = new AuthorsForm(program);
            Visible = false;
            authorsForm.ShowDialog();
            this.Close();
        }

        private void homeGenresPictureBox_Click(object sender, System.EventArgs e)
        {
            var genresForm = new GenresForm(program);
            Visible = false;
            genresForm.ShowDialog();
            this.Close();
        }

        private void homeTextsLabel_Click(object sender, System.EventArgs e)
        {
            var textsForm = new TextsForm(program);
            Visible = false;
            textsForm.ShowDialog();
            this.Close();
        }

        private void homeAuthorsLabel_Click(object sender, System.EventArgs e)
        {
            var authorsForm = new AuthorsForm(program);
            Visible = false;
            authorsForm.ShowDialog();
            this.Close();
        }

        private void homeGenresLabel_Click(object sender, System.EventArgs e)
        {
            var genresForm = new GenresForm(program);
            Visible = false;
            genresForm.ShowDialog();
            this.Close();
        }
    }
}
