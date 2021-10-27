
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
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.PIBTextBox = new System.Windows.Forms.TextBox();
            this.plase_of_esidenceTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.updateLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.managerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLabel = new System.Windows.Forms.Label();
            date_of_birthLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            pIBLabel = new System.Windows.Forms.Label();
            plase_of_esidenceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // date_of_birthLabel
            // 
            date_of_birthLabel.AutoSize = true;
            date_of_birthLabel.Location = new System.Drawing.Point(98, 163);
            date_of_birthLabel.Name = "date_of_birthLabel";
            date_of_birthLabel.Size = new System.Drawing.Size(68, 13);
            date_of_birthLabel.TabIndex = 7;
            date_of_birthLabel.Text = "Date of birth:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(98, 110);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(45, 13);
            genderLabel.TabIndex = 9;
            genderLabel.Text = "Gender:";
            // 
            // pIBLabel
            // 
            pIBLabel.AutoSize = true;
            pIBLabel.Location = new System.Drawing.Point(98, 84);
            pIBLabel.Name = "pIBLabel";
            pIBLabel.Size = new System.Drawing.Size(27, 13);
            pIBLabel.TabIndex = 13;
            pIBLabel.Text = "PIB:";
            // 
            // plase_of_esidenceLabel
            // 
            plase_of_esidenceLabel.AutoSize = true;
            plase_of_esidenceLabel.Location = new System.Drawing.Point(98, 136);
            plase_of_esidenceLabel.Name = "plase_of_esidenceLabel";
            plase_of_esidenceLabel.Size = new System.Drawing.Size(94, 13);
            plase_of_esidenceLabel.TabIndex = 15;
            plase_of_esidenceLabel.Text = "Plase of esidence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add new customer";
            // 
            // AgeDateTimePicker
            // 
            this.AgeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "Date_of_birth", true));
            this.AgeDateTimePicker.Location = new System.Drawing.Point(198, 159);
            this.AgeDateTimePicker.Name = "AgeDateTimePicker";
            this.AgeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AgeDateTimePicker.TabIndex = 8;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(198, 107);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.genderTextBox.TabIndex = 10;
            // 
            // PIBTextBox
            // 
            this.PIBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PIB", true));
            this.PIBTextBox.Location = new System.Drawing.Point(198, 81);
            this.PIBTextBox.Name = "PIBTextBox";
            this.PIBTextBox.Size = new System.Drawing.Size(200, 20);
            this.PIBTextBox.TabIndex = 14;
            // 
            // plase_of_esidenceTextBox
            // 
            this.plase_of_esidenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Plase_of_esidence", true));
            this.plase_of_esidenceTextBox.Location = new System.Drawing.Point(198, 133);
            this.plase_of_esidenceTextBox.Name = "plase_of_esidenceTextBox";
            this.plase_of_esidenceTextBox.Size = new System.Drawing.Size(200, 20);
            this.plase_of_esidenceTextBox.TabIndex = 16;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(323, 198);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(323, 198);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateComboBox
            // 
            this.updateComboBox.FormattingEnabled = true;
            this.updateComboBox.Location = new System.Drawing.Point(198, 54);
            this.updateComboBox.Name = "updateComboBox";
            this.updateComboBox.Size = new System.Drawing.Size(200, 21);
            this.updateComboBox.TabIndex = 21;
            this.updateComboBox.SelectedIndexChanged += new System.EventHandler(this.updateComboBox_SelectedIndexChanged);
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Location = new System.Drawing.Point(98, 57);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(84, 13);
            this.updateLabel.TabIndex = 22;
            this.updateLabel.Text = "Select Customer";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.managerBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(198, 28);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 23;
            // 
            // managerBindingSource
            // 
            this.managerBindingSource.DataSource = typeof(lab5WinForms.Models.Manager);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(lab5WinForms.Models.Customer);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(98, 31);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 24;
            this.idLabel.Text = "Id:";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 242);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.updateComboBox);
            this.Controls.Add(this.updateButton);
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
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managerBindingSource)).EndInit();
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
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.BindingSource managerBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
    }
}