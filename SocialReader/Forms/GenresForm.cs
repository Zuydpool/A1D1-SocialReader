using System;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SocialReader.objects;

namespace SocialReader.Forms
{
    public partial class GenresForm : Form
    {
        private Program program;
        private string genreSearchTextBoxText = "Search genre...";
        public GenresForm(Program program)
        {
            this.program = program;
            InitializeComponent();

            LoadListBox();

            genreSearchTextBox.GotFocus += new EventHandler(RemoveText);
            genreSearchTextBox.LostFocus += new EventHandler(AddText);
        }

        private void LoadListBox()
        {
            textDataListView.SetObjects(program.GenreDao.GetGenres());
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            var homeForm = new HomeForm(program);
            Visible = false;
            homeForm.ShowDialog();
            this.Close();
        }

        private void addGenrePictureBox_Click(object sender, System.EventArgs e)
        {
            var addGenreForm = new AddGenreForm(program);
            Visible = false;
            addGenreForm.ShowDialog();
            this.Close();
        }

        private void genreSearchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            var text = genreSearchTextBox.Text;
            if (string.IsNullOrEmpty(text) || text == genreSearchTextBoxText)
            {
                textDataListView.ModelFilter = null;
                return;
            }

            textDataListView.ModelFilter = new ModelFilter(delegate (object x) {
                var genre = x as Genre;
                return x != null && (genre.Name.ToLower().Contains(text.ToLower()));
            });
        }

        private void RemoveText(object sneder, EventArgs e)
        {
            if (genreSearchTextBox.Text == genreSearchTextBoxText)
            {
                genreSearchTextBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(genreSearchTextBox.Text))
                genreSearchTextBox.Text = genreSearchTextBoxText;
        }
    }
}
