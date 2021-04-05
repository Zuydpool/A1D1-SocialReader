
namespace SocialReader.Forms
{
    partial class GenresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenresForm));
            this.textDataListView = new BrightIdeasSoftware.DataListView();
            this.genreIdColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.genreNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.genreDescriptionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addGenreLabel = new System.Windows.Forms.Label();
            this.addGenrePictureBox = new System.Windows.Forms.PictureBox();
            this.genreSearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.textDataListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGenrePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textDataListView
            // 
            this.textDataListView.AllColumns.Add(this.genreIdColumn);
            this.textDataListView.AllColumns.Add(this.genreNameColumn);
            this.textDataListView.AllColumns.Add(this.genreDescriptionColumn);
            this.textDataListView.CellEditUseWholeCell = false;
            this.textDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.genreIdColumn,
            this.genreNameColumn,
            this.genreDescriptionColumn});
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
            // genreIdColumn
            // 
            this.genreIdColumn.AspectName = "Id";
            this.genreIdColumn.Groupable = false;
            this.genreIdColumn.Text = "ID";
            // 
            // genreNameColumn
            // 
            this.genreNameColumn.AspectName = "Name";
            this.genreNameColumn.Groupable = false;
            this.genreNameColumn.Text = "Name";
            this.genreNameColumn.Width = 100;
            // 
            // genreDescriptionColumn
            // 
            this.genreDescriptionColumn.AspectName = "Description";
            this.genreDescriptionColumn.Groupable = false;
            this.genreDescriptionColumn.Text = "Description";
            this.genreDescriptionColumn.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Genres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Go back";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 36);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // addGenreLabel
            // 
            this.addGenreLabel.AutoSize = true;
            this.addGenreLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGenreLabel.Location = new System.Drawing.Point(694, 404);
            this.addGenreLabel.Name = "addGenreLabel";
            this.addGenreLabel.Size = new System.Drawing.Size(59, 13);
            this.addGenreLabel.TabIndex = 10;
            this.addGenreLabel.Text = "Add Genre";
            // 
            // addGenrePictureBox
            // 
            this.addGenrePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("addGenrePictureBox.Image")));
            this.addGenrePictureBox.Location = new System.Drawing.Point(654, 392);
            this.addGenrePictureBox.Name = "addGenrePictureBox";
            this.addGenrePictureBox.Size = new System.Drawing.Size(90, 36);
            this.addGenrePictureBox.TabIndex = 9;
            this.addGenrePictureBox.TabStop = false;
            this.addGenrePictureBox.Click += new System.EventHandler(this.addGenrePictureBox_Click);
            // 
            // genreSearchTextBox
            // 
            this.genreSearchTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreSearchTextBox.Location = new System.Drawing.Point(315, 80);
            this.genreSearchTextBox.Name = "genreSearchTextBox";
            this.genreSearchTextBox.Size = new System.Drawing.Size(100, 23);
            this.genreSearchTextBox.TabIndex = 11;
            this.genreSearchTextBox.Text = "Search genre...";
            this.genreSearchTextBox.TextChanged += new System.EventHandler(this.genreSearchTextBox_TextChanged);
            // 
            // GenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genreSearchTextBox);
            this.Controls.Add(this.addGenreLabel);
            this.Controls.Add(this.addGenrePictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDataListView);
            this.Name = "GenresForm";
            this.Text = "Genres";
            ((System.ComponentModel.ISupportInitialize)(this.textDataListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addGenrePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BrightIdeasSoftware.DataListView textDataListView;
        private BrightIdeasSoftware.OLVColumn genreIdColumn;
        private BrightIdeasSoftware.OLVColumn genreNameColumn;
        private BrightIdeasSoftware.OLVColumn genreDescriptionColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label addGenreLabel;
        private System.Windows.Forms.PictureBox addGenrePictureBox;
        private System.Windows.Forms.TextBox genreSearchTextBox;
    }
}