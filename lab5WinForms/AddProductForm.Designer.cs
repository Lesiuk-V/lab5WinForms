
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
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pIBComboBox = new System.Windows.Forms.ComboBox();
            categoryLabel = new System.Windows.Forms.Label();
            p_descriptionLabel = new System.Windows.Forms.Label();
            p_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(47, 89);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Category:";
            // 
            // p_descriptionLabel
            // 
            p_descriptionLabel.AutoSize = true;
            p_descriptionLabel.Location = new System.Drawing.Point(47, 142);
            p_descriptionLabel.Name = "p_descriptionLabel";
            p_descriptionLabel.Size = new System.Drawing.Size(71, 13);
            p_descriptionLabel.TabIndex = 7;
            p_descriptionLabel.Text = "P description:";
            // 
            // p_nameLabel
            // 
            p_nameLabel.AutoSize = true;
            p_nameLabel.Location = new System.Drawing.Point(47, 63);
            p_nameLabel.Name = "p_nameLabel";
            p_nameLabel.Size = new System.Drawing.Size(46, 13);
            p_nameLabel.TabIndex = 9;
            p_nameLabel.Text = "P name:";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Category", true));
            this.categoryTextBox.Location = new System.Drawing.Point(124, 86);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(301, 20);
            this.categoryTextBox.TabIndex = 2;
            // 
            // p_descriptionTextBox
            // 
            this.p_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_description", true));
            this.p_descriptionTextBox.Location = new System.Drawing.Point(124, 139);
            this.p_descriptionTextBox.Multiline = true;
            this.p_descriptionTextBox.Name = "p_descriptionTextBox";
            this.p_descriptionTextBox.Size = new System.Drawing.Size(301, 82);
            this.p_descriptionTextBox.TabIndex = 8;
            // 
            // p_nameTextBox
            // 
            this.p_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "P_name", true));
            this.p_nameTextBox.Location = new System.Drawing.Point(124, 60);
            this.p_nameTextBox.Name = "p_nameTextBox";
            this.p_nameTextBox.Size = new System.Drawing.Size(301, 20);
            this.p_nameTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Додавання продукту";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(350, 236);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Зберегти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(lab5WinForms.Models.Product);
            // 
            // pIBComboBox
            // 
            this.pIBComboBox.FormattingEnabled = true;
            this.pIBComboBox.Location = new System.Drawing.Point(124, 112);
            this.pIBComboBox.Name = "pIBComboBox";
            this.pIBComboBox.Size = new System.Drawing.Size(301, 21);
            this.pIBComboBox.TabIndex = 13;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 456);
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
    }
}