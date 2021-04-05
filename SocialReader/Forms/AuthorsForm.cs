using System;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SocialReader.objects;

namespace SocialReader.Forms
{
    public partial class AuthorsForm : Form
    {
        private Program program;
        private string authorSearchTextBoxText = "Search author...";
        public AuthorsForm(Program program)
        {
            this.program = program;
            InitializeComponent();

            LoadListBox();

            authorSearchTextBox.GotFocus += new EventHandler(RemoveText);
            authorSearchTextBox.LostFocus += new EventHandler(AddText);
        }

        private void LoadListBox()
        {
            textDataListView.SetObjects(program.AuthorDao.GetAuthors());
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            var homeForm = new HomeForm(program);
            Visible = false;
            homeForm.ShowDialog();
            this.Close();
        }

        private void authorSearchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            var text = authorSearchTextBox.Text;
            if (string.IsNullOrEmpty(text) || text == authorSearchTextBoxText)
            {
                textDataListView.ModelFilter = null;
                return;
            }

            textDataListView.ModelFilter = new ModelFilter(delegate (object x) {
                var author = x as Author;
                return x != null && (author.Name.ToLower().Contains(text.ToLower()));
            });
        }

        private void RemoveText(object sneder, EventArgs e)
        {
            if (authorSearchTextBox.Text == authorSearchTextBoxText)
            {
                authorSearchTextBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorSearchTextBox.Text))
                authorSearchTextBox.Text = authorSearchTextBoxText;
        }

        private void addGenrePictureBox_Click(object sender, EventArgs e)
        {
            var addAuthorForm = new AddAuthorForm(program);
            Visible = false;
            addAuthorForm.ShowDialog();
            this.Close();
        }
    }
}
