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
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            
            productBindingSource.EndEdit();
            Product product = productBindingSource.Current as Product;
            Manager manager = (Manager)pIBComboBox.SelectedItem;
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
                product.ManagerId = manager.Id;
               string cmdText = $"Insert into Product(P_name, Category, P_description, Manager_id) values('{product.P_name}','{product.Category}','{product.P_description}','{product.ManagerId}')";

                SqlCommand comm = new SqlCommand(cmdText, con);
                comm.ExecuteNonQuery();
                this.Close();
                con.Close();
            }
        }

    }
}
