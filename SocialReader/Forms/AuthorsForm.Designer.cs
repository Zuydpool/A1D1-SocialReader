
namespace SocialReader.Forms
{
    partial class AuthorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsForm));
            this.textDataListView = new BrightIdeasSoftware.DataListView();
            this.AuthorIdColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.authorNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.authorFirstNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AuthorTitleColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.authorSearchTextBox = new System.Windows.Forms.TextBox();
            this.addGenreLabel = new System.Windows.Forms.Label();
            this.addGenrePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textDataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGenrePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textDataListView
            // 
            this.textDataListView.AllColumns.Add(this.AuthorIdColumn);
            this.textDataListView.AllColumns.Add(this.authorNameColumn);
            this.textDataListView.AllColumns.Add(this.authorFirstNameColumn);
            this.textDataListView.AllColumns.Add(this.AuthorTitleColumn);
            this.textDataListView.CellEditUseWholeCell = false;
            this.textDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AuthorIdColumn,
            this.authorNameColumn,
            this.authorFirstNameColumn,
            this.AuthorTitleColumn});
            this.textDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.textDataListView.DataSource = null;
            this.textDataListView.HideSelection = false;
            this.textDataListView.Location = new System.Drawing.Point(53, 120);
            this.textDataListView.Name = "textDataListView";
            this.textDataListView.Size = new System.Drawing.Size(691, 253);
            this.textDataListView.TabIndex = 0;
            this.textDataListView.UseCompatibleStateImageBehavior = false;
            this.textDataListView.UseFiltering = true;
            this.textDataListView.View = System.Windows.Forms.View.Details;
            // 
            // AuthorIdColumn
            // 
            this.AuthorIdColumn.AspectName = "Id";
            this.AuthorIdColumn.Groupable = false;
            this.AuthorIdColumn.Text = "ID";
            // 
            // authorNameColumn
            // 
            this.authorNameColumn.AspectName = "Name";
            this.authorNameColumn.Groupable = false;
            this.authorNameColumn.Text = "Name";
            this.authorNameColumn.Width = 100;
            // 
            // authorFirstNameColumn
            // 
            this.authorFirstNameColumn.AspectName = "FirstName";
            this.authorFirstNameColumn.Groupable = false;
            this.authorFirstNameColumn.Text = "FirstName";
            this.authorFirstNameColumn.Width = 100;
            // 
            // AuthorTitleColumn
            // 
            this.AuthorTitleColumn.AspectName = "Title";
            this.AuthorTitleColumn.Groupable = false;
            this.AuthorTitleColumn.Text = "Title";
            this.AuthorTitleColumn.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Go back";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 36);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // authorSearchTextBox
            // 
            this.authorSearchTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorSearchTextBox.Location = new System.Drawing.Point(319, 80);
            this.authorSearchTextBox.Name = "authorSearchTextBox";
            this.authorSearchTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorSearchTextBox.TabIndex = 11;
            this.authorSearchTextBox.Text = "Search author...";
            this.authorSearchTextBox.TextChanged += new System.EventHandler(this.authorSearchTextBox_TextChanged);
            // 
            // addGenreLabel
            // 
            this.addGenreLabel.AutoSize = true;
            this.addGenreLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGenreLabel.Location = new System.Drawing.Point(696, 402);
            this.addGenreLabel.Name = "addGenreLabel";
            this.addGenreLabel.Size = new System.Drawing.Size(62, 13);
            this.addGenreLabel.TabIndex = 13;
            this.addGenreLabel.Text = "Add Author";
            // 
            // addGenrePictureBox
            // 
            this.addGenrePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addGenrePictureBox.Image")));
            this.addGenrePictureBox.Location = new System.Drawing.Point(654, 392);
            this.addGenrePictureBox.Name = "addGenrePictureBox";
            this.addGenrePictureBox.Size = new System.Drawing.Size(90, 36);
            this.addGenrePictureBox.TabIndex = 12;
            this.addGenrePictureBox.TabStop = false;
            this.addGenrePictureBox.Click += new System.EventHandler(this.addGenrePictureBox_Click);
            // 
            // AuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addGenreLabel);
            this.Controls.Add(this.addGenrePictureBox);
            this.Controls.Add(this.authorSearchTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDataListView);
            this.Name = "AuthorsForm";
            this.Text = "AuthorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.textDataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGenrePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.DataListView textDataListView;
        private BrightIdeasSoftware.OLVColumn AuthorIdColumn;
        private BrightIdeasSoftware.OLVColumn AuthorTitleColumn;
        private BrightIdeasSoftware.OLVColumn authorNameColumn;
        private BrightIdeasSoftware.OLVColumn authorFirstNameColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox authorSearchTextBox;
        private System.Windows.Forms.Label addGenreLabel;
        private System.Windows.Forms.PictureBox addGenrePictureBox;
    }
}