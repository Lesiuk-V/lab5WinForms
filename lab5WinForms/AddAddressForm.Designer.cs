
namespace lab5WinForms
{
    partial class AddAddressForm
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
            System.Windows.Forms.Label buildingLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label streetLabel;
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.CustomerComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            buildingLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.Location = new System.Drawing.Point(60, 130);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new System.Drawing.Size(47, 13);
            buildingLabel.TabIndex = 1;
            buildingLabel.Text = "Building:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(60, 104);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City:";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(60, 54);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(44, 13);
            regionLabel.TabIndex = 7;
            regionLabel.Text = "Region:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(60, 78);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(38, 13);
            streetLabel.TabIndex = 9;
            streetLabel.Text = "Street:";
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "Building", true));
            this.buildingTextBox.Location = new System.Drawing.Point(113, 127);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(172, 20);
            this.buildingTextBox.TabIndex = 2;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(lab5WinForms.Models.Address);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(113, 101);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(172, 20);
            this.cityTextBox.TabIndex = 4;
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(113, 51);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(172, 20);
            this.regionTextBox.TabIndex = 8;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "Street", true));
            this.streetTextBox.Location = new System.Drawing.Point(113, 75);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(172, 20);
            this.streetTextBox.TabIndex = 10;
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.FormattingEnabled = true;
            this.CustomerComboBox.Location = new System.Drawing.Point(113, 153);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(172, 21);
            this.CustomerComboBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(210, 189);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Зберегти";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add new address";
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerComboBox);
            this.Controls.Add(buildingLabel);
            this.Controls.Add(this.buildingTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Name = "AddAddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAddressForm";
            this.Load += new System.EventHandler(this.AddAddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.TextBox buildingTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
    }
}