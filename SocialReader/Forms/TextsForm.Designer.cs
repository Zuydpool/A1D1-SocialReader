
namespace SocialReader.Forms
{
    partial class TextsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextsForm));
            this.textsLabel = new System.Windows.Forms.Label();
            this.addTextPictureBox = new System.Windows.Forms.PictureBox();
            this.addTextLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textsDataListView = new BrightIdeasSoftware.DataListView();
            this.textIDColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textsTitleColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textsAuthorsColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textsGenresColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textsYearOfPublishingColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textsAvgScoreColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textsVersionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textsSearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.addTextPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsDataListView)).BeginInit();
            this.SuspendLayout();
            // 
            // textsLabel
            // 
            this.textsLabel.AutoSize = true;
            this.textsLabel.Font = new System.Drawing.Font("Roboto", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsLabel.Location = new System.Drawing.Point(311, 9);
            this.textsLabel.Name = "textsLabel";
            this.textsLabel.Size = new System.Drawing.Size(117, 48);
            this.textsLabel.TabIndex = 0;
            this.textsLabel.Text = "Texts";
            // 
            // addTextPictureBox
            // 
            this.addTextPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addTextPictureBox.Image")));
            this.addTextPictureBox.Location = new System.Drawing.Point(654, 392);
            this.addTextPictureBox.Name = "addTextPictureBox";
            this.addTextPictureBox.Size = new System.Drawing.Size(90, 36);
            this.addTextPictureBox.TabIndex = 3;
            this.addTextPictureBox.TabStop = false;
            this.addTextPictureBox.Click += new System.EventHandler(this.addTextPictureBox_Click);
            // 
            // addTextLabel
            // 
            this.addTextLabel.AutoSize = true;
            this.addTextLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTextLabel.Location = new System.Drawing.Point(694, 404);
            this.addTextLabel.Name = "addTextLabel";
            this.addTextLabel.Size = new System.Drawing.Size(50, 13);
            this.addTextLabel.TabIndex = 4;
            this.addTextLabel.Text = "Add Text";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 36);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Go back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textsDataListView
            // 
            this.textsDataListView.AllColumns.Add(this.textIDColumn);
            this.textsDataListView.AllColumns.Add(this.textsTitleColumn);
            this.textsDataListView.AllColumns.Add(this.textsAuthorsColumn);
            this.textsDataListView.AllColumns.Add(this.textsGenresColumn);
            this.textsDataListView.AllColumns.Add(this.textsYearOfPublishingColumn);
            this.textsDataListView.AllColumns.Add(this.textsAvgScoreColumn);
            this.textsDataListView.AllColumns.Add(this.textsVersionColumn);
            this.textsDataListView.CellEditUseWholeCell = false;
            this.textsDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.textIDColumn,
            this.textsTitleColumn,
            this.textsAuthorsColumn,
            this.textsGenresColumn,
            this.textsYearOfPublishingColumn,
            this.textsAvgScoreColumn,
            this.textsVersionColumn});
            this.textsDataListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.textsDataListView.DataSource = null;
            this.textsDataListView.HideSelection = false;
            this.textsDataListView.Location = new System.Drawing.Point(53, 120);
            this.textsDataListView.Name = "textsDataListView";
            this.textsDataListView.ShowGroups = false;
            this.textsDataListView.Size = new System.Drawing.Size(691, 253);
            this.textsDataListView.TabIndex = 7;
            this.textsDataListView.UseCompatibleStateImageBehavior = false;
            this.textsDataListView.UseFiltering = true;
            this.textsDataListView.View = System.Windows.Forms.View.Details;
            // 
            // textIDColumn
            // 
            this.textIDColumn.AspectName = "Id";
            this.textIDColumn.Text = "ID";
            // 
            // textsTitleColumn
            // 
            this.textsTitleColumn.AspectName = "Title";
            this.textsTitleColumn.Text = "Title";
            this.textsTitleColumn.Width = 100;
            // 
            // textsAuthorsColumn
            // 
            this.textsAuthorsColumn.AspectName = "AuthorsAsString";
            this.textsAuthorsColumn.Text = "Authors";
            this.textsAuthorsColumn.Width = 120;
            // 
            // textsGenresColumn
            // 
            this.textsGenresColumn.AspectName = "GenresAsString";
            this.textsGenresColumn.Text = "Genres";
            this.textsGenresColumn.Width = 120;
            // 
            // textsYearOfPublishingColumn
            // 
            this.textsYearOfPublishingColumn.AspectName = "YearOfPublishing";
            this.textsYearOfPublishingColumn.Text = "Year Of Publishing";
            this.textsYearOfPublishingColumn.Width = 100;
            // 
            // textsAvgScoreColumn
            // 
            this.textsAvgScoreColumn.AspectName = "AverageScore";
            this.textsAvgScoreColumn.Text = "Avg. Score";
            this.textsAvgScoreColumn.Width = 80;
            // 
            // textsVersionColumn
            // 
            this.textsVersionColumn.AspectName = "Version";
            this.textsVersionColumn.Text = "Version";
            // 
            // textsSearchTextBox
            // 
            this.textsSearchTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsSearchTextBox.Location = new System.Drawing.Point(319, 80);
            this.textsSearchTextBox.Name = "textsSearchTextBox";
            this.textsSearchTextBox.Size = new System.Drawing.Size(100, 23);
            this.textsSearchTextBox.TabIndex = 12;
            this.textsSearchTextBox.Text = "Search text...";
            this.textsSearchTextBox.TextChanged += new System.EventHandler(this.textsSearchTextBox_TextChanged);
            // 
            // TextsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textsSearchTextBox);
            this.Controls.Add(this.textsDataListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addTextLabel);
            this.Controls.Add(this.addTextPictureBox);
            this.Controls.Add(this.textsLabel);
            this.Name = "TextsForm";
            this.Text = "TextsForm";
            ((System.ComponentModel.ISupportInitialize)(this.addTextPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textsDataListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textsLabel;
        private System.Windows.Forms.PictureBox addTextPictureBox;
        private System.Windows.Forms.Label addTextLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private BrightIdeasSoftware.DataListView textsDataListView;
        private BrightIdeasSoftware.OLVColumn textIDColumn;
        private BrightIdeasSoftware.OLVColumn textsTitleColumn;
        private BrightIdeasSoftware.OLVColumn textsAuthorsColumn;
        private BrightIdeasSoftware.OLVColumn textsGenresColumn;
        private BrightIdeasSoftware.OLVColumn textsYearOfPublishingColumn;
        private BrightIdeasSoftware.OLVColumn textsAvgScoreColumn;
        private BrightIdeasSoftware.OLVColumn textsVersionColumn;
        private System.Windows.Forms.TextBox textsSearchTextBox;
    }
}