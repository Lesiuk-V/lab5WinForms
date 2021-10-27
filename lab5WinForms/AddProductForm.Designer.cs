
namespace lab5WinForms
{
    partial class AddProductForm
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
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label p_descriptionLabel;
            System.Windows.Forms.Label p_nameLabel;
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.p_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.p_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.pIBComboBox = new System.Windows.Forms.ComboBox();
            this.updateComboBox = new System.Windows.Forms.ComboBox();
            this.updateLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            categoryLabel = new System.Windows.Forms.Label();
            p_descriptionLabel = new System.Windows.Forms.Label();
            p_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(54, 122);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Category:";
            // 
            // p_descriptionLabel
            // 
            p_descriptionLabel.AutoSize = true;
            p_descriptionLabel.Location = new System.Drawing.Point(54, 175);
            p_descriptionLabel.Name = "p_descriptionLabel";
            p_descriptionLabel.Size = new System.Drawing.Size(71, 13);
            p_descriptionLabel.TabIndex = 7;
            p_descriptionLabel.Text = "P description:";
            // 
            // p_nameLabel
            // 
            p_nameLabel.AutoSize = true;
            p_nameLabel.Location = new System.Drawing.Point(54, 96);
            p_nameLabel.Name = "p_nameLabel";
            p_nameLabel.Size = new System.Drawing.Size(46, 13);
            p_nameLabel.TabIndex = 9;
            p_nameLabel.Text = "P name:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(136, 119);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(301, 20);
            this.categoryTextBox.TabIndex = 2;
            // 
            // p_descriptionTextBox
            // 
            this.p_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_description", true));
            this.p_descriptionTextBox.Location = new System.Drawing.Point(136, 172);
            this.p_descriptionTextBox.Multiline = true;
            this.p_descriptionTextBox.Name = "p_descriptionTextBox";
            this.p_descriptionTextBox.Size = new System.Drawing.Size(301, 82);
            this.p_descriptionTextBox.TabIndex = 8;
            // 
            // p_nameTextBox
            // 
            this.p_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_name", true));
            this.p_nameTextBox.Location = new System.Drawing.Point(136, 93);
            this.p_nameTextBox.Name = "p_nameTextBox";
            this.p_nameTextBox.Size = new System.Drawing.Size(301, 20);
            this.p_nameTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add new product";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(362, 269);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pIBComboBox
            // 
            this.pIBComboBox.FormattingEnabled = true;
            this.pIBComboBox.Location = new System.Drawing.Point(136, 145);
            this.pIBComboBox.Name = "pIBComboBox";
            this.pIBComboBox.Size = new System.Drawing.Size(301, 21);
            this.pIBComboBox.TabIndex = 13;
            // 
            // updateComboBox
            // 
            this.updateComboBox.FormattingEnabled = true;
            this.updateComboBox.Location = new System.Drawing.Point(136, 66);
            this.updateComboBox.Name = "updateComboBox";
            this.updateComboBox.Size = new System.Drawing.Size(301, 21);
            this.updateComboBox.TabIndex = 14;
            this.updateComboBox.SelectedIndexChanged += new System.EventHandler(this.updateComboBox_SelectedIndexChanged);
            // 
            // updateLable
            // 
            this.updateLable.AutoSize = true;
            this.updateLable.Location = new System.Drawing.Point(54, 69);
            this.updateLable.Name = "updateLable";
            this.updateLable.Size = new System.Drawing.Size(76, 13);
            this.updateLable.TabIndex = 15;
            this.updateLable.Text = "Select product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select manager";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(136, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 17;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(54, 43);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(16, 13);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "Id";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(362, 268);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(lab5WinForms.Models.Product);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 336);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateLable);
            this.Controls.Add(this.updateComboBox);
            this.Controls.Add(this.pIBComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(p_descriptionLabel);
            this.Controls.Add(this.p_descriptionTextBox);
            this.Controls.Add(p_nameLabel);
            this.Controls.Add(this.p_nameTextBox);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox p_descriptionTextBox;
        private System.Windows.Forms.TextBox p_nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox pIBComboBox;
        private System.Windows.Forms.ComboBox updateComboBox;
        private System.Windows.Forms.Label updateLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button updateButton;
    }
}