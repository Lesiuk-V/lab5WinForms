
namespace lab5WinForms
{
    partial class AddManagerForm
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
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label pIBLabel;
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.pIBTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            pIBLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(64, 118);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(71, 13);
            dateOfBirthLabel.TabIndex = 0;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(64, 91);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender:";
            // 
            // pIBLabel
            // 
            pIBLabel.AutoSize = true;
            pIBLabel.Location = new System.Drawing.Point(64, 65);
            pIBLabel.Name = "pIBLabel";
            pIBLabel.Size = new System.Drawing.Size(27, 13);
            pIBLabel.TabIndex = 6;
            pIBLabel.Text = "PIB:";
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataSource = typeof(lab5WinForms.Models.Manager);
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.managerBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(141, 114);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthDateTimePicker.TabIndex = 1;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(141, 88);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 3;
            // 
            // pIBTextBox
            // 
            this.pIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerBindingSource, "PIB", true));
            this.pIBTextBox.Location = new System.Drawing.Point(141, 62);
            this.pIBTextBox.Name = "pIBTextBox";
            this.pIBTextBox.Size = new System.Drawing.Size(200, 20);
            this.pIBTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Manager";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(266, 140);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 226);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(pIBLabel);
            this.Controls.Add(this.pIBTextBox);
            this.Name = "AddManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource managerBindingSource;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox pIBTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
    }
}