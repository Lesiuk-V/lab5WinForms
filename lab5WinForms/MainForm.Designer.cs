
namespace lab5WinForms
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.getUsersLivedInKharkivNowInKiev = new System.Windows.Forms.Button();
            this.getCustomersKiivLvivIvanoFrankivsk = new System.Windows.Forms.Button();
            this.getUsersBetwen1980and1955 = new System.Windows.Forms.Button();
            this.getManagers = new System.Windows.Forms.Button();
            this.getAddress = new System.Windows.Forms.Button();
            this.getProducts = new System.Windows.Forms.Button();
            this.getCustomers = new System.Windows.Forms.Button();
            this.addManager = new System.Windows.Forms.Button();
            this.addAddress = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.addCustomers = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.updateManager = new System.Windows.Forms.Button();
            this.updateAddress = new System.Windows.Forms.Button();
            this.updateProduct = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.getUsersLivedInKharkivNowInKiev);
            this.splitContainer1.Panel1.Controls.Add(this.getCustomersKiivLvivIvanoFrankivsk);
            this.splitContainer1.Panel1.Controls.Add(this.getUsersBetwen1980and1955);
            this.splitContainer1.Panel1.Controls.Add(this.getManagers);
            this.splitContainer1.Panel1.Controls.Add(this.getAddress);
            this.splitContainer1.Panel1.Controls.Add(this.getProducts);
            this.splitContainer1.Panel1.Controls.Add(this.getCustomers);
            this.splitContainer1.Panel1.Controls.Add(this.addManager);
            this.splitContainer1.Panel1.Controls.Add(this.addAddress);
            this.splitContainer1.Panel1.Controls.Add(this.addProduct);
            this.splitContainer1.Panel1.Controls.Add(this.addCustomers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(820, 529);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 0;
            // 
            // getUsersLivedInKharkivNowInKiev
            // 
            this.getUsersLivedInKharkivNowInKiev.Location = new System.Drawing.Point(7, 366);
            this.getUsersLivedInKharkivNowInKiev.Name = "getUsersLivedInKharkivNowInKiev";
            this.getUsersLivedInKharkivNowInKiev.Size = new System.Drawing.Size(201, 49);
            this.getUsersLivedInKharkivNowInKiev.TabIndex = 10;
            this.getUsersLivedInKharkivNowInKiev.Text = "Get customers who previously lived in Kharkiv and now live\r\nIn Kiev";
            this.getUsersLivedInKharkivNowInKiev.UseVisualStyleBackColor = true;
            this.getUsersLivedInKharkivNowInKiev.Click += new System.EventHandler(this.getUsersLivedInKharkivNowInKiev_Click);
            // 
            // getCustomersKiivLvivIvanoFrankivsk
            // 
            this.getCustomersKiivLvivIvanoFrankivsk.Location = new System.Drawing.Point(7, 324);
            this.getCustomersKiivLvivIvanoFrankivsk.Name = "getCustomersKiivLvivIvanoFrankivsk";
            this.getCustomersKiivLvivIvanoFrankivsk.Size = new System.Drawing.Size(202, 35);
            this.getCustomersKiivLvivIvanoFrankivsk.TabIndex = 9;
            this.getCustomersKiivLvivIvanoFrankivsk.Text = "Get customers living in Kyiv, Lviv, Ivano-Frankivsk";
            this.getCustomersKiivLvivIvanoFrankivsk.UseVisualStyleBackColor = true;
            this.getCustomersKiivLvivIvanoFrankivsk.Click += new System.EventHandler(this.getCustomersKiivLvivIvanoFrankivsk_Click);
            // 
            // getUsersBetwen1980and1955
            // 
            this.getUsersBetwen1980and1955.Location = new System.Drawing.Point(7, 277);
            this.getUsersBetwen1980and1955.Name = "getUsersBetwen1980and1955";
            this.getUsersBetwen1980and1955.Size = new System.Drawing.Size(201, 40);
            this.getUsersBetwen1980and1955.TabIndex = 8;
            this.getUsersBetwen1980and1955.Text = "Get all customers born between 1980 and 1995";
            this.getUsersBetwen1980and1955.UseVisualStyleBackColor = true;
            this.getUsersBetwen1980and1955.Click += new System.EventHandler(this.getUsersBetwen1980and1955_Click);
            // 
            // getManagers
            // 
            this.getManagers.Location = new System.Drawing.Point(111, 213);
            this.getManagers.Name = "getManagers";
            this.getManagers.Size = new System.Drawing.Size(97, 23);
            this.getManagers.TabIndex = 7;
            this.getManagers.Text = "Get Managers";
            this.getManagers.UseVisualStyleBackColor = true;
            this.getManagers.Click += new System.EventHandler(this.getManagers_Click);
            // 
            // getAddress
            // 
            this.getAddress.Location = new System.Drawing.Point(7, 213);
            this.getAddress.Name = "getAddress";
            this.getAddress.Size = new System.Drawing.Size(97, 23);
            this.getAddress.TabIndex = 6;
            this.getAddress.Text = "Get Address";
            this.getAddress.UseVisualStyleBackColor = true;
            this.getAddress.Click += new System.EventHandler(this.getAddress_Click);
            // 
            // getProducts
            // 
            this.getProducts.Location = new System.Drawing.Point(111, 184);
            this.getProducts.Name = "getProducts";
            this.getProducts.Size = new System.Drawing.Size(97, 23);
            this.getProducts.TabIndex = 5;
            this.getProducts.Text = "Get Products";
            this.getProducts.UseVisualStyleBackColor = true;
            this.getProducts.Click += new System.EventHandler(this.getProducts_Click);
            // 
            // getCustomers
            // 
            this.getCustomers.Location = new System.Drawing.Point(7, 185);
            this.getCustomers.Name = "getCustomers";
            this.getCustomers.Size = new System.Drawing.Size(97, 23);
            this.getCustomers.TabIndex = 4;
            this.getCustomers.Text = "Get Customers";
            this.getCustomers.UseVisualStyleBackColor = true;
            this.getCustomers.Click += new System.EventHandler(this.getCustomers_Click);
            // 
            // addManager
            // 
            this.addManager.Location = new System.Drawing.Point(111, 83);
            this.addManager.Name = "addManager";
            this.addManager.Size = new System.Drawing.Size(98, 23);
            this.addManager.TabIndex = 3;
            this.addManager.Text = "Add Manager";
            this.addManager.UseVisualStyleBackColor = true;
            this.addManager.Click += new System.EventHandler(this.addManager_Click);
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(7, 83);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(97, 23);
            this.addAddress.TabIndex = 2;
            this.addAddress.Text = "Add Address";
            this.addAddress.UseVisualStyleBackColor = true;
            this.addAddress.Click += new System.EventHandler(this.addAddress_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(111, 54);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(97, 23);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // addCustomers
            // 
            this.addCustomers.Location = new System.Drawing.Point(7, 53);
            this.addCustomers.Name = "addCustomers";
            this.addCustomers.Size = new System.Drawing.Size(97, 23);
            this.addCustomers.TabIndex = 0;
            this.addCustomers.Text = "Add Customer";
            this.addCustomers.UseVisualStyleBackColor = true;
            this.addCustomers.Click += new System.EventHandler(this.addCustomers_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.updateManager);
            this.splitContainer2.Panel1.Controls.Add(this.updateAddress);
            this.splitContainer2.Panel1.Controls.Add(this.updateProduct);
            this.splitContainer2.Panel1.Controls.Add(this.updateCustomer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(600, 529);
            this.splitContainer2.SplitterDistance = 61;
            this.splitContainer2.TabIndex = 0;
            // 
            // updateManager
            // 
            this.updateManager.Location = new System.Drawing.Point(476, 12);
            this.updateManager.Name = "updateManager";
            this.updateManager.Size = new System.Drawing.Size(97, 23);
            this.updateManager.TabIndex = 11;
            this.updateManager.Text = "Update Manager";
            this.updateManager.UseVisualStyleBackColor = true;
            // 
            // updateAddress
            // 
            this.updateAddress.Location = new System.Drawing.Point(325, 12);
            this.updateAddress.Name = "updateAddress";
            this.updateAddress.Size = new System.Drawing.Size(97, 23);
            this.updateAddress.TabIndex = 10;
            this.updateAddress.Text = "Update Address";
            this.updateAddress.UseVisualStyleBackColor = true;
            // 
            // updateProduct
            // 
            this.updateProduct.Location = new System.Drawing.Point(170, 12);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(98, 23);
            this.updateProduct.TabIndex = 9;
            this.updateProduct.Text = "Update Product";
            this.updateProduct.UseVisualStyleBackColor = true;
            this.updateProduct.Click += new System.EventHandler(this.updateProduct_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Location = new System.Drawing.Point(18, 12);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(97, 23);
            this.updateCustomer.TabIndex = 8;
            this.updateCustomer.Text = "Update Customer";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(600, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 529);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button getManagers;
        private System.Windows.Forms.Button getAddress;
        private System.Windows.Forms.Button getProducts;
        private System.Windows.Forms.Button getCustomers;
        private System.Windows.Forms.Button addManager;
        private System.Windows.Forms.Button addAddress;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button addCustomers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getUsersBetwen1980and1955;
        private System.Windows.Forms.Button updateManager;
        private System.Windows.Forms.Button updateAddress;
        private System.Windows.Forms.Button updateProduct;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button getUsersLivedInKharkivNowInKiev;
        private System.Windows.Forms.Button getCustomersKiivLvivIvanoFrankivsk;
    }
}

