using System;
using System.Drawing;
using System.Windows.Forms;
using BrightIdeasSoftware;
using SocialReader.objects;

namespace SocialReader.Forms
{
    public partial class TextsForm : Form
    {
        private Program program;
        private string textSearchTextBoxText = "Search text...";
        public TextsForm(Program program)
        {
            this.program = program;
            InitializeComponent();

            LoadListBox();

            textsSearchTextBox.GotFocus += new EventHandler(RemoveText);
            textsSearchTextBox.LostFocus += new EventHandler(AddText);
        }

        private void LoadListBox()
        {
            //string stdDetails = "{0, -30}{1, -40}{2, -20}{3, -30}";
            //textsListBox.Items.Add(string.Format(stdDetails, "Title", "Year Of Publishing", "Version", "Summary"));
            textsDataListView.SetObjects(program.TextDao.GetTexts());
            /*foreach (var text in program.TextDao.GetTexts())
            {
                var row = new string[] { text.Id.ToString(), text.Title, text.getAuthorsAsString(), text.getGenresAsString(), text.YearOfPublishing.ToString(), text.GetAverageScore().ToString(), text.Version };
                var listViewItem = new ListViewItem(row)
                {
                    Tag = text
                };

                //textsListBox.Items.Add(string.Format(stdDetails, text.Title, text.YearOfPublishing.ToString(), text.Version, text.Summary));
                textsListView.Items.Add(listViewItem);
            }*/
        }

        private void addTextPictureBox_Click(object sender, System.EventArgs e)
        {
            var addTextForm = new AddTextForm(program);
            Visible = false;
            addTextForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            var homeForm = new HomeForm(program);
            Visible = false;
            homeForm.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void textsSearchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            var searchBoxText = textsSearchTextBox.Text;
            if (string.IsNullOrEmpty(searchBoxText) || searchBoxText == textSearchTextBoxText)
            {
                textsDataListView.ModelFilter = null;
                return;
            }

            textsDataListView.ModelFilter = new ModelFilter(delegate (object x) {
                var text = x as Text;
                return x != null && (text.Title.ToLower().Contains(searchBoxText.ToLower()));
            });
        }

        private void RemoveText(object sneder, EventArgs e)
        {
            if (textsSearchTextBox.Text == textSearchTextBoxText)
            {
                textsSearchTextBox.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textsSearchTextBox.Text))
                textsSearchTextBox.Text = textSearchTextBoxText;
        }
    }
}
