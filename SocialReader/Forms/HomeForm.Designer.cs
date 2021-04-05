
namespace SocialReader.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.signOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.homeTextsPictureBox = new System.Windows.Forms.PictureBox();
            this.homeAuthorsPictureBox = new System.Windows.Forms.PictureBox();
            this.homeGenresPictureBox = new System.Windows.Forms.PictureBox();
            this.homeTextsLabel = new System.Windows.Forms.Label();
            this.homeAuthorsLabel = new System.Windows.Forms.Label();
            this.homeGenresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeTextsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAuthorsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeGenresPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signOutButton
            // 
            this.signOutButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutButton.Location = new System.Drawing.Point(76, 381);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(75, 23);
            this.signOutButton.TabIndex = 1;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Logged in As:";
            // 
            // homeTextsPictureBox
            // 
            this.homeTextsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("homeTextsPictureBox.Image")));
            this.homeTextsPictureBox.Location = new System.Drawing.Point(256, 101);
            this.homeTextsPictureBox.Name = "homeTextsPictureBox";
            this.homeTextsPictureBox.Size = new System.Drawing.Size(100, 96);
            this.homeTextsPictureBox.TabIndex = 10;
            this.homeTextsPictureBox.TabStop = false;
            this.homeTextsPictureBox.Click += new System.EventHandler(this.homeTextsPictureBox_Click);
            // 
            // homeAuthorsPictureBox
            // 
            this.homeAuthorsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("homeAuthorsPictureBox.Image")));
            this.homeAuthorsPictureBox.Location = new System.Drawing.Point(405, 101);
            this.homeAuthorsPictureBox.Name = "homeAuthorsPictureBox";
            this.homeAuthorsPictureBox.Size = new System.Drawing.Size(100, 96);
            this.homeAuthorsPictureBox.TabIndex = 11;
            this.homeAuthorsPictureBox.TabStop = false;
            this.homeAuthorsPictureBox.Click += new System.EventHandler(this.homeAuthorsPictureBox_Click);
            // 
            // homeGenresPictureBox
            // 
            this.homeGenresPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("homeGenresPictureBox.Image")));
            this.homeGenresPictureBox.Location = new System.Drawing.Point(256, 236);
            this.homeGenresPictureBox.Name = "homeGenresPictureBox";
            this.homeGenresPictureBox.Size = new System.Drawing.Size(100, 100);
            this.homeGenresPictureBox.TabIndex = 12;
            this.homeGenresPictureBox.TabStop = false;
            this.homeGenresPictureBox.Click += new System.EventHandler(this.homeGenresPictureBox_Click);
            // 
            // homeTextsLabel
            // 
            this.homeTextsLabel.AutoSize = true;
            this.homeTextsLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTextsLabel.Location = new System.Drawing.Point(286, 200);
            this.homeTextsLabel.Name = "homeTextsLabel";
            this.homeTextsLabel.Size = new System.Drawing.Size(38, 15);
            this.homeTextsLabel.TabIndex = 13;
            this.homeTextsLabel.Text = "Texts";
            this.homeTextsLabel.Click += new System.EventHandler(this.homeTextsLabel_Click);
            // 
            // homeAuthorsLabel
            // 
            this.homeAuthorsLabel.AutoSize = true;
            this.homeAuthorsLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeAuthorsLabel.Location = new System.Drawing.Point(428, 200);
            this.homeAuthorsLabel.Name = "homeAuthorsLabel";
            this.homeAuthorsLabel.Size = new System.Drawing.Size(51, 15);
            this.homeAuthorsLabel.TabIndex = 14;
            this.homeAuthorsLabel.Text = "Authors";
            this.homeAuthorsLabel.Click += new System.EventHandler(this.homeAuthorsLabel_Click);
            // 
            // homeGenresLabel
            // 
            this.homeGenresLabel.AutoSize = true;
            this.homeGenresLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeGenresLabel.Location = new System.Drawing.Point(276, 339);
            this.homeGenresLabel.Name = "homeGenresLabel";
            this.homeGenresLabel.Size = new System.Drawing.Size(48, 15);
            this.homeGenresLabel.TabIndex = 15;
            this.homeGenresLabel.Text = "Genres";
            this.homeGenresLabel.Click += new System.EventHandler(this.homeGenresLabel_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homeGenresLabel);
            this.Controls.Add(this.homeAuthorsLabel);
            this.Controls.Add(this.homeTextsLabel);
            this.Controls.Add(this.homeGenresPictureBox);
            this.Controls.Add(this.homeAuthorsPictureBox);
            this.Controls.Add(this.homeTextsPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signOutButton);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.homeTextsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeAuthorsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeGenresPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox homeTextsPictureBox;
        private System.Windows.Forms.PictureBox homeAuthorsPictureBox;
        private System.Windows.Forms.PictureBox homeGenresPictureBox;
        private System.Windows.Forms.Label homeTextsLabel;
        private System.Windows.Forms.Label homeAuthorsLabel;
        private System.Windows.Forms.Label homeGenresLabel;
    }
}