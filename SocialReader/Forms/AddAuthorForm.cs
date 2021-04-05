using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SocialReader.objects;

namespace SocialReader.Forms
{
    public partial class AddAuthorForm : Form
    {
        private Program program;
        private string titleTextBoxText = "Enter name here...";
        
        public AddAuthorForm(Program program)
        {
            this.program = program;
            InitializeComponent();
        }

        private void AddTextForm_Load(object sender, EventArgs e)
        {
            authorNameTextBox.Text = titleTextBoxText;

            authorNameTextBox.GotFocus += new EventHandler(RemoveText);
            authorNameTextBox.LostFocus += new EventHandler(AddText);
        }

        private void RemoveText(object sneder, EventArgs e)
        {
            if (authorNameTextBox.Text == titleTextBoxText)
            {
                authorNameTextBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(authorNameTextBox.Text))
                authorNameTextBox.Text = titleTextBoxText;
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
            var name = authorNameTextBox.Text;
            var firstName = authorfirstnameTextBox.Text;
            var title = authorTitleTextBox.Text;
            
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Name and Firstname cannot be empty.");
                return;
            }

            var author = new Author { Name = name, FirstName = firstName, Title = title };
            program.AuthorDao.Create(author);

            MessageBox.Show($"Successfully created author {name}");

            var authorsForm = new AuthorsForm(program);
            Visible = false;
            authorsForm.ShowDialog();
            this.Close();
        }
    }
}
