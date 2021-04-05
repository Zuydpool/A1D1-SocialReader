using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SocialReader.objects;

namespace SocialReader.Forms
{
    public partial class AddTextForm : Form
    {
        private Program program;
        private string titleTextBoxText = "Enter title here...";
        
        public AddTextForm(Program program)
        {
            this.program = program;
            InitializeComponent();
        }

        private void AddTextForm_Load(object sender, EventArgs e)
        {
            textTitleTextBox.Text = titleTextBoxText;

            textTitleTextBox.GotFocus += new EventHandler(RemoveText);
            textTitleTextBox.LostFocus += new EventHandler(AddText);
        }

        private void RemoveText(object sneder, EventArgs e)
        {
            if (textTitleTextBox.Text == titleTextBoxText)
            {
                textTitleTextBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textTitleTextBox.Text))
                textTitleTextBox.Text = titleTextBoxText;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var textsForm = new TextsForm(program);
            Visible = false;
            textsForm.ShowDialog();
            this.Close();
        }

        private void addTextButton_Click(object sender, EventArgs e)
        {
            var title = textTitleTextBox.Text;
            var authorsStr = textAuthorsTextBox.Text;
            var genresStr = textGenresTextBox.Text;
            var yearOfPublishingStr = textYearOfPublishingTextBox.Text;
            var version = textVersionTextBox.Text;

            if (string.IsNullOrWhiteSpace(title) || title == titleTextBoxText || string.IsNullOrWhiteSpace(version))
            {
                MessageBox.Show("Title and version cannot be empty.");
                return;
            }

            var authorsStrList = authorsStr.Split(';');
            var genresStrList = genresStr.Split(';');

            Console.WriteLine(string.Join(", ", genresStrList));
            Console.WriteLine(string.Join(", ", authorsStrList.Select(program.AuthorDao.GetByName).ToList()));
            Console.WriteLine(string.Join(", ", genresStrList.Select(program.GenreDao.GetByName).ToList()));

            var authors = authorsStrList.Select(program.AuthorDao.GetByName).Where(obj => obj != null).ToList();
            var genres = genresStrList.Select(program.GenreDao.GetByName).Where(obj => obj != null).ToList();
          
            if (authors.Count == 0)
            {
                MessageBox.Show("Invalid Author(s)");
                return;
            }
            if (genres.Count == 0)
            {
                MessageBox.Show("Invalid Genre(s)");
                return;
            }

            try
            {
                DateTime yearOfPublishing = DateTime.Parse(yearOfPublishingStr);

                var text = new Text { Title = title, YearOfPublishing = yearOfPublishing, Version = version };
                text.AddAuthors(authors);
                text.AddGenres(genres);

                program.TextDao.Create(text);

                MessageBox.Show($"Successfully created text {title}");

                var textsForm = new TextsForm(program);
                Visible = false;
                textsForm.ShowDialog();
                this.Close();
            } catch (FormatException) {
                MessageBox.Show("Year Of Publishing has an invalid date.");
            }
        }
    }
}