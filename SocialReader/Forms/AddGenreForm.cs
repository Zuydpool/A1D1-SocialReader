using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SocialReader.objects;

namespace SocialReader.Forms
{
    public partial class AddGenreForm : Form
    {
        private Program program;
        private string nameTextBoxText = "Enter name here...";
        
        public AddGenreForm(Program program)
        {
            this.program = program;
            InitializeComponent();
        }

        private void AddTextForm_Load(object sender, EventArgs e)
        {
            genreNameTextBox.Text = nameTextBoxText;

            genreNameTextBox.GotFocus += new EventHandler(RemoveText);
            genreNameTextBox.LostFocus += new EventHandler(AddText);
        }

        private void RemoveText(object sneder, EventArgs e)
        {
            if (genreNameTextBox.Text == nameTextBoxText)
            {
                genreNameTextBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(genreNameTextBox.Text))
                genreNameTextBox.Text = nameTextBoxText;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var genresForm = new GenresForm(program);
            Visible = false;
            genresForm.ShowDialog();
            this.Close();
        }

        private void addTextButton_Click(object sender, EventArgs e)
        {
            var name = genreNameTextBox.Text;
            var description = genresDescriptionTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Name and Description cannot be empty.");
                return;
            }

            var genre = new Genre { Name = name, Description = description };
            program.GenreDao.Create(genre);

            MessageBox.Show($"Successfully created genre {name}");

            var genresForm = new GenresForm(program);
            Visible = false;
            genresForm.ShowDialog();
            this.Close();
        }

    }
}
