using lab5WinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5WinForms
{
    public partial class AddProductForm : Form
    {
        string ConnectionString = "Server=tcp:itacademy.database.windows.net;Database=lesyuk;User ID = lesyuk;Password=Dxm23487;Trusted_Connection=False;Encrypt=True";
        public AddProductForm()
        {
            InitializeComponent();
            productBindingSource.DataSource = new Product();
            updateButton.Visible = false;
            updateLable.Visible = false;
            updateComboBox.Visible = false;
            idTextBox.Visible = false;
            idLabel.Visible = false;


        }
        public AddProductForm(bool a)
        {
            InitializeComponent();
            label1.Text = "Update product";

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select Id, PIB from Manager";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();
            
            while (sqlDataReader.Read())
            {
                Manager manager = new Manager();
                manager.Id = (int)sqlDataReader[0];
                manager.PIB = (string)sqlDataReader[1];
                pIBComboBox.Items.Add(manager);
                pIBComboBox.DisplayMember = "PIB";
            }
            con.Close();
            con.Open();

            string cmdText1 = "Select Id, P_name, Category, P_description, Manager_id from Product";
            SqlCommand comm1 = new SqlCommand(cmdText1, con);
            SqlDataReader sqlDataReader1 = comm1.ExecuteReader();

            while (sqlDataReader1.Read())
            {
                Product product = new Product();
                product.Id = (int)sqlDataReader1[0];
                product.P_name = (string)sqlDataReader1[1];
                product.Category = (string)sqlDataReader1[2];
                product.P_description = (string)sqlDataReader1[3];
                product.ManagerId = Convert.ToInt32(sqlDataReader1[4]);
                updateComboBox.Items.Add(product);
                updateComboBox.DisplayMember = "P_name";
            }
            con.Close();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            
            productBindingSource.EndEdit();
            Product product = productBindingSource.Current as Product;
            Customer customer = (Customer)pIBComboBox.SelectedItem;
            if (product != null)
            {
                ValidationContext context = new ValidationContext(product, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(product, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
               string cmdText = $"Insert into Product(P_name, Category, P_description, Manager_id) values('{product.P_name}','{product.Category}','{product.P_description}','{customer.Id}')";

                SqlCommand comm = new SqlCommand(cmdText, con);
                comm.ExecuteNonQuery();
                this.Close();
                con.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                Manager manager = (Manager)pIBComboBox.SelectedItem;

                string cmdText = $"UPDATE Product SET P_name = '{p_nameTextBox.Text}', P_description= '{p_descriptionTextBox.Text}', Category = '{categoryTextBox.Text}', Manager_id = '{manager.Id}' WHERE Id ={idTextBox.Text}";

                SqlCommand comm = new SqlCommand(cmdText, con);
                comm.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            else 
                MessageBox.Show("Please enter valid data");

        }

        private void updateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = (Product)updateComboBox.SelectedItem;
            p_nameTextBox.Text = product.P_name;
            categoryTextBox.Text = product.Category;
            p_descriptionTextBox.Text = product.P_description;
            pIBComboBox.SelectedIndex = product.ManagerId-1;
            idTextBox.Text = Convert.ToString(product.Id);
        }

        private bool ValidateForm()
        {
            bool bValidSelectedProduct = ValidateSelectedProduct();
            bool bValidProductName = ValidateProductName();
            bool bValidCategory = ValidateCategory();
            bool bValideSelectedManager = ValidateSelectedManager();
            bool bValidDescription = ValidateDescription();
            if (bValidSelectedProduct && bValidProductName && bValidCategory && bValideSelectedManager && bValidDescription)
                return true;
            else
                return false;
        }


            private bool ValidateSelectedProduct()
            {
                bool bStatus = true;
                if (updateComboBox.Text == "")
                {

                    errorProvider1.SetError(updateComboBox, "Please select product");
                    bStatus = false;
                }
                else
                    errorProvider1.SetError(updateComboBox, "");
                return bStatus;
            }

            private bool ValidateProductName()
            {
                bool bStatus = true;
                if (p_nameTextBox.Text == "")
                {

                    errorProvider2.SetError(p_nameTextBox, "Please enter product name");
                    bStatus = false;
                }
                else
                    errorProvider2.SetError(p_nameTextBox, "");
                return bStatus;
            }
            private bool ValidateCategory()
            {
                bool bStatus = true;
                if (categoryTextBox.Text == "")
                {

                    errorProvider3.SetError(categoryTextBox, "Please enter category");
                    bStatus = false;
                }
                else
                    errorProvider3.SetError(categoryTextBox, "");
                return bStatus;
            }
            private bool ValidateSelectedManager()
            {
                bool bStatus = true;
                if (pIBComboBox.Text == "")
                {

                    errorProvider4.SetError(pIBComboBox, "Please select manager");
                    bStatus = false;
                }
                else
                    errorProvider4.SetError(pIBComboBox, "");
                return bStatus;
            }
            private bool ValidateDescription()
            {
                bool bStatus = true;
                if (p_descriptionTextBox.Text == "")
                {

                    errorProvider5.SetError(p_descriptionTextBox, "Please enter description");
                    bStatus = false;
                }
                else
                    errorProvider5.SetError(p_descriptionTextBox, "");
                return bStatus;
            }

        private void updateComboBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateSelectedProduct();
        }

        private void p_nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateProductName();
        }

        private void categoryTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateCategory();
        }

        private void pIBComboBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateSelectedManager();
        }

        private void p_descriptionTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateDescription();
        }
    }
}
