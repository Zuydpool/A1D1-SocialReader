
namespace SocialReader.Forms
{
    partial class AddTextForm
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
            this.components = new System.ComponentModel.Container();
            this.textYearOfPublishingTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textGenresTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addTextButton = new System.Windows.Forms.Button();
            this.textAuthorsTextBox = new System.Windows.Forms.TextBox();
            this.textTitleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textVersionTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textYearOfPublishingTextBox
            // 
            this.textYearOfPublishingTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textYearOfPublishingTextBox.Location = new System.Drawing.Point(14, 181);
            this.textYearOfPublishingTextBox.Name = "textYearOfPublishingTextBox";
            this.textYearOfPublishingTextBox.Size = new System.Drawing.Size(430, 23);
            this.textYearOfPublishingTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Year Of Publishing";
            this.toolTip3.SetToolTip(this.label4, "dd-mm-YYYY");
            // 
            // textGenresTextBox
            // 
            this.textGenresTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGenresTextBox.Location = new System.Drawing.Point(14, 132);
            this.textGenresTextBox.Name = "textGenresTextBox";
            this.textGenresTextBox.Size = new System.Drawing.Size(430, 23);
            this.textGenresTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Genres";
            this.toolTip2.SetToolTip(this.label3, "Seperate author by ;");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Authors";
            this.toolTip1.SetToolTip(this.label2, "Seperate author by ;");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Title";
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
            this.addTextButton.Text = "Add Text";
            this.addTextButton.UseVisualStyleBackColor = true;
            this.addTextButton.Click += new System.EventHandler(this.addTextButton_Click);
            // 
            // textAuthorsTextBox
            // 
            this.textAuthorsTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAuthorsTextBox.Location = new System.Drawing.Point(14, 83);
            this.textAuthorsTextBox.Name = "textAuthorsTextBox";
            this.textAuthorsTextBox.Size = new System.Drawing.Size(430, 23);
            this.textAuthorsTextBox.TabIndex = 2;
            // 
            // textTitleTextBox
            // 
            this.textTitleTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitleTextBox.Location = new System.Drawing.Point(14, 34);
            this.textTitleTextBox.Name = "textTitleTextBox";
            this.textTitleTextBox.Size = new System.Drawing.Size(430, 23);
            this.textTitleTextBox.TabIndex = 1;
            this.textTitleTextBox.Text = "Enter title here...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Version";
            // 
            // textVersionTextBox
            // 
            this.textVersionTextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVersionTextBox.Location = new System.Drawing.Point(14, 230);
            this.textVersionTextBox.Name = "textVersionTextBox";
            this.textVersionTextBox.Size = new System.Drawing.Size(430, 23);
            this.textVersionTextBox.TabIndex = 5;
            // 
            // AddTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 476);
            this.Controls.Add(this.textVersionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textYearOfPublishingTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textGenresTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addTextButton);
            this.Controls.Add(this.textAuthorsTextBox);
            this.Controls.Add(this.textTitleTextBox);
            this.Name = "AddTextForm";
            this.Text = "AddTextForm";
            this.Load += new System.EventHandler(this.AddTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textYearOfPublishingTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textGenresTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addTextButton;
        private System.Windows.Forms.TextBox textAuthorsTextBox;
        private System.Windows.Forms.TextBox textTitleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textVersionTextBox;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}