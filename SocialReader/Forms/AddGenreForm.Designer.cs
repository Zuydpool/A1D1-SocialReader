
namespace SocialReader.Forms
{
    partial class AddGenreForm
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
            this.genreDescriptionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addTextButton = new System.Windows.Forms.Button();
            this.genresDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.genreNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // genreDescriptionLabel
            // 
            this.genreDescriptionLabel.AutoSize = true;
            this.genreDescriptionLabel.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreDescriptionLabel.Location = new System.Drawing.Point(14, 60);
            this.genreDescriptionLabel.Name = "genreDescriptionLabel";
            this.genreDescriptionLabel.Size = new System.Drawing.Size(96, 20);
            this.genreDescriptionLabel.TabIndex = 15;
            this.genreDescriptionLabel.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(293, 443);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addTextButton
            // 
            this.addTextButton.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTextButton.Location = new System.Drawing.Point(372, 443);
            this.addTextButton.Name = "addTextButton";
            this.addTextButton.Size = new System.Drawing.Size(75, 23);
            this.addTextButton.TabIndex = 6;
            this.addTextButton.Text = "Add Genre";
            this.addTextButton.UseVisualStyleBackColor = true;
            this.addTextButton.Click += new System.EventHandler(this.addTextButton_Click);
            // 
            // genresDescriptionTextBox
            // 
            this.genresDescriptionTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genresDescriptionTextBox.Location = new System.Drawing.Point(14, 83);
            this.genresDescriptionTextBox.Name = "genresDescriptionTextBox";
            this.genresDescriptionTextBox.Size = new System.Drawing.Size(430, 23);
            this.genresDescriptionTextBox.TabIndex = 2;
            // 
            // genreNameTextBox
            // 
            this.genreNameTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreNameTextBox.Location = new System.Drawing.Point(14, 34);
            this.genreNameTextBox.Name = "genreNameTextBox";
            this.genreNameTextBox.Size = new System.Drawing.Size(430, 23);
            this.genreNameTextBox.TabIndex = 1;
            this.genreNameTextBox.Text = "Enter name here...";
            // 
            // AddGenreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 476);
            this.Controls.Add(this.genreDescriptionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addTextButton);
            this.Controls.Add(this.genresDescriptionTextBox);
            this.Controls.Add(this.genreNameTextBox);
            this.Name = "AddGenreForm";
            this.Text = "AddGenreForm";
            this.Load += new System.EventHandler(this.AddTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label genreDescriptionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addTextButton;
        private System.Windows.Forms.TextBox genresDescriptionTextBox;
        private System.Windows.Forms.TextBox genreNameTextBox;
    }
}