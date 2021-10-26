
namespace lab5WinForms
{
    partial class AddCustomerForm
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
            System.Windows.Forms.Label date_of_birthLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label pIBLabel;
            System.Windows.Forms.Label plase_of_esidenceLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.AgeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.PIBTextBox = new System.Windows.Forms.TextBox();
            this.plase_of_esidenceTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            date_of_birthLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            pIBLabel = new System.Windows.Forms.Label();
            plase_of_esidenceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_of_birthLabel
            // 
            date_of_birthLabel.AutoSize = true;
            date_of_birthLabel.Location = new System.Drawing.Point(98, 127);
            date_of_birthLabel.Name = "date_of_birthLabel";
            date_of_birthLabel.Size = new System.Drawing.Size(68, 13);
            date_of_birthLabel.TabIndex = 7;
            date_of_birthLabel.Text = "Date of birth:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(98, 74);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 9;
            genderLabel.Text = "Gender:";
            // 
            // pIBLabel
            // 
            pIBLabel.AutoSize = true;
            pIBLabel.Location = new System.Drawing.Point(98, 48);
            pIBLabel.Name = "pIBLabel";
            pIBLabel.Size = new System.Drawing.Size(27, 13);
            pIBLabel.TabIndex = 13;
            pIBLabel.Text = "PIB:";
            // 
            // plase_of_esidenceLabel
            // 
            plase_of_esidenceLabel.AutoSize = true;
            plase_of_esidenceLabel.Location = new System.Drawing.Point(98, 100);
            plase_of_esidenceLabel.Name = "plase_of_esidenceLabel";
            plase_of_esidenceLabel.Size = new System.Drawing.Size(94, 13);
            plase_of_esidenceLabel.TabIndex = 15;
            plase_of_esidenceLabel.Text = "Plase of esidence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Додавання нового користувача";
            // 
            // AgeDateTimePicker
            // 
            this.AgeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "Date_of_birth", true));
            this.AgeDateTimePicker.Location = new System.Drawing.Point(198, 123);
            this.AgeDateTimePicker.Name = "AgeDateTimePicker";
            this.AgeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AgeDateTimePicker.TabIndex = 8;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(lab5WinForms.Models.Customer);
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(198, 71);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 10;
            // 
            // PIBTextBox
            // 
            this.PIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PIB", true));
            this.PIBTextBox.Location = new System.Drawing.Point(198, 45);
            this.PIBTextBox.Name = "PIBTextBox";
            this.PIBTextBox.Size = new System.Drawing.Size(200, 20);
            this.PIBTextBox.TabIndex = 14;
            // 
            // plase_of_esidenceTextBox
            // 
            this.plase_of_esidenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Plase_of_esidence", true));
            this.plase_of_esidenceTextBox.Location = new System.Drawing.Point(198, 97);
            this.plase_of_esidenceTextBox.Name = "plase_of_esidenceTextBox";
            this.plase_of_esidenceTextBox.Size = new System.Drawing.Size(200, 20);
            this.plase_of_esidenceTextBox.TabIndex = 16;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(323, 162);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 242);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(date_of_birthLabel);
            this.Controls.Add(this.AgeDateTimePicker);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(pIBLabel);
            this.Controls.Add(this.PIBTextBox);
            this.Controls.Add(plase_of_esidenceLabel);
            this.Controls.Add(this.plase_of_esidenceTextBox);
            this.Controls.Add(this.label2);
            this.Name = "AddCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DateTimePicker AgeDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox PIBTextBox;
        private System.Windows.Forms.TextBox plase_of_esidenceTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}