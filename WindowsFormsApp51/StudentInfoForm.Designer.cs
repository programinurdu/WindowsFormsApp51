namespace WindowsFormsApp51
{
    partial class StudentInfoForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveRecordButton = new System.Windows.Forms.Button();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MobileTextBox = new System.Windows.Forms.TextBox();
            this.MobileLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.OthersRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.SelectCourseGroupBox = new System.Windows.Forms.GroupBox();
            this.CSharpCheckBox = new System.Windows.Forms.CheckBox();
            this.VBNETCheckBox = new System.Windows.Forms.CheckBox();
            this.PhotoshopCheckBox = new System.Windows.Forms.CheckBox();
            this.HtmlCheckBox = new System.Windows.Forms.CheckBox();
            this.GenderGroupBox.SuspendLayout();
            this.SelectCourseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(594, 66);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(176, 43);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveRecordButton
            // 
            this.SaveRecordButton.Location = new System.Drawing.Point(594, 17);
            this.SaveRecordButton.Name = "SaveRecordButton";
            this.SaveRecordButton.Size = new System.Drawing.Size(176, 43);
            this.SaveRecordButton.TabIndex = 17;
            this.SaveRecordButton.Text = "Save Record";
            this.SaveRecordButton.UseVisualStyleBackColor = true;
            this.SaveRecordButton.Click += new System.EventHandler(this.SaveRecordButton_Click);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTextBox.Location = new System.Drawing.Point(35, 448);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesTextBox.Size = new System.Drawing.Size(856, 228);
            this.NotesTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notes:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.Location = new System.Drawing.Point(155, 152);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(254, 29);
            this.PhoneTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone:";
            // 
            // MobileTextBox
            // 
            this.MobileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileTextBox.Location = new System.Drawing.Point(155, 106);
            this.MobileTextBox.Name = "MobileTextBox";
            this.MobileTextBox.Size = new System.Drawing.Size(254, 29);
            this.MobileTextBox.TabIndex = 14;
            // 
            // MobileLabel
            // 
            this.MobileLabel.AutoSize = true;
            this.MobileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileLabel.Location = new System.Drawing.Point(31, 109);
            this.MobileLabel.Name = "MobileLabel";
            this.MobileLabel.Size = new System.Drawing.Size(72, 24);
            this.MobileLabel.TabIndex = 9;
            this.MobileLabel.Text = "Mobile:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(155, 62);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(254, 29);
            this.EmailTextBox.TabIndex = 13;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(31, 65);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(62, 24);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTextBox.Location = new System.Drawing.Point(155, 17);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(254, 29);
            this.FullNameTextBox.TabIndex = 11;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(31, 20);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(102, 24);
            this.FullNameLabel.TabIndex = 12;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.OthersRadioButton);
            this.GenderGroupBox.Controls.Add(this.FemaleRadioButton);
            this.GenderGroupBox.Controls.Add(this.MaleRadioButton);
            this.GenderGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderGroupBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GenderGroupBox.Location = new System.Drawing.Point(35, 215);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(531, 90);
            this.GenderGroupBox.TabIndex = 19;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // OthersRadioButton
            // 
            this.OthersRadioButton.AutoSize = true;
            this.OthersRadioButton.ForeColor = System.Drawing.Color.Black;
            this.OthersRadioButton.Location = new System.Drawing.Point(369, 41);
            this.OthersRadioButton.Name = "OthersRadioButton";
            this.OthersRadioButton.Size = new System.Drawing.Size(84, 28);
            this.OthersRadioButton.TabIndex = 6;
            this.OthersRadioButton.TabStop = true;
            this.OthersRadioButton.Text = "Others";
            this.OthersRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.FemaleRadioButton.Location = new System.Drawing.Point(204, 41);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(92, 28);
            this.FemaleRadioButton.TabIndex = 5;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.ForeColor = System.Drawing.Color.Black;
            this.MaleRadioButton.Location = new System.Drawing.Point(32, 41);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(69, 28);
            this.MaleRadioButton.TabIndex = 4;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SelectCourseGroupBox
            // 
            this.SelectCourseGroupBox.Controls.Add(this.CSharpCheckBox);
            this.SelectCourseGroupBox.Controls.Add(this.VBNETCheckBox);
            this.SelectCourseGroupBox.Controls.Add(this.PhotoshopCheckBox);
            this.SelectCourseGroupBox.Controls.Add(this.HtmlCheckBox);
            this.SelectCourseGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCourseGroupBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SelectCourseGroupBox.Location = new System.Drawing.Point(35, 320);
            this.SelectCourseGroupBox.Name = "SelectCourseGroupBox";
            this.SelectCourseGroupBox.Size = new System.Drawing.Size(531, 85);
            this.SelectCourseGroupBox.TabIndex = 20;
            this.SelectCourseGroupBox.TabStop = false;
            this.SelectCourseGroupBox.Text = "Select Course(s)";
            // 
            // CSharpCheckBox
            // 
            this.CSharpCheckBox.AutoSize = true;
            this.CSharpCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSharpCheckBox.ForeColor = System.Drawing.Color.Black;
            this.CSharpCheckBox.Location = new System.Drawing.Point(25, 38);
            this.CSharpCheckBox.Name = "CSharpCheckBox";
            this.CSharpCheckBox.Size = new System.Drawing.Size(52, 28);
            this.CSharpCheckBox.TabIndex = 7;
            this.CSharpCheckBox.Text = "C#";
            this.CSharpCheckBox.UseVisualStyleBackColor = true;
            // 
            // VBNETCheckBox
            // 
            this.VBNETCheckBox.AutoSize = true;
            this.VBNETCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VBNETCheckBox.ForeColor = System.Drawing.Color.Black;
            this.VBNETCheckBox.Location = new System.Drawing.Point(117, 38);
            this.VBNETCheckBox.Name = "VBNETCheckBox";
            this.VBNETCheckBox.Size = new System.Drawing.Size(98, 28);
            this.VBNETCheckBox.TabIndex = 8;
            this.VBNETCheckBox.Text = "VB.NET";
            this.VBNETCheckBox.UseVisualStyleBackColor = true;
            // 
            // PhotoshopCheckBox
            // 
            this.PhotoshopCheckBox.AutoSize = true;
            this.PhotoshopCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhotoshopCheckBox.ForeColor = System.Drawing.Color.Black;
            this.PhotoshopCheckBox.Location = new System.Drawing.Point(376, 38);
            this.PhotoshopCheckBox.Name = "PhotoshopCheckBox";
            this.PhotoshopCheckBox.Size = new System.Drawing.Size(120, 28);
            this.PhotoshopCheckBox.TabIndex = 10;
            this.PhotoshopCheckBox.Text = "Photoshop";
            this.PhotoshopCheckBox.UseVisualStyleBackColor = true;
            // 
            // HtmlCheckBox
            // 
            this.HtmlCheckBox.AutoSize = true;
            this.HtmlCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HtmlCheckBox.ForeColor = System.Drawing.Color.Black;
            this.HtmlCheckBox.Location = new System.Drawing.Point(255, 38);
            this.HtmlCheckBox.Name = "HtmlCheckBox";
            this.HtmlCheckBox.Size = new System.Drawing.Size(81, 28);
            this.HtmlCheckBox.TabIndex = 9;
            this.HtmlCheckBox.Text = "HTML";
            this.HtmlCheckBox.UseVisualStyleBackColor = true;
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 688);
            this.Controls.Add(this.SelectCourseGroupBox);
            this.Controls.Add(this.GenderGroupBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveRecordButton);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MobileTextBox);
            this.Controls.Add(this.MobileLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Info Screen";
            this.Load += new System.EventHandler(this.StudentInfoForm_Load);
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.SelectCourseGroupBox.ResumeLayout(false);
            this.SelectCourseGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveRecordButton;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MobileTextBox;
        private System.Windows.Forms.Label MobileLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton OthersRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.GroupBox SelectCourseGroupBox;
        private System.Windows.Forms.CheckBox CSharpCheckBox;
        private System.Windows.Forms.CheckBox VBNETCheckBox;
        private System.Windows.Forms.CheckBox PhotoshopCheckBox;
        private System.Windows.Forms.CheckBox HtmlCheckBox;
    }
}