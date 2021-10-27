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
    public partial class AddAddressForm : Form
    {
        string ConnectionString = "Server=tcp:itacademy.database.windows.net;Database=lesyuk;User ID = lesyuk;Password=Dxm23487;Trusted_Connection=False;Encrypt=True";
        public AddAddressForm()
        {
            InitializeComponent();
            addressBindingSource.DataSource = new Address();
        }

        private void AddAddressForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select Id, PIB from Customers";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.Id = (int)sqlDataReader[0];
                customer.PIB = (string)sqlDataReader[1];
                CustomerComboBox.Items.Add(customer);
                CustomerComboBox.DisplayMember = "PIB";
            }
            con.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            addressBindingSource.EndEdit();
            Address address = addressBindingSource.Current as Address;
            Customer customer = (Customer)CustomerComboBox.SelectedItem;
            if (address != null)
            {
                ValidationContext context = new ValidationContext(address, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(address, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string cmdAddToAddres = $"Insert into Address_c(Region, City, Street, Building) values('{address.Region}','{address.City}','{address.Street}','{address.Building}')";
                SqlCommand addAdress = new SqlCommand(cmdAddToAddres, con);
                addAdress.ExecuteNonQuery();

                string cmdGetAddress = "SELECT Id FROM Address_c WHERE id=(SELECT max(id) FROM Address_c);";
                SqlCommand selectCreatedAddres = new SqlCommand(cmdGetAddress, con);
                int getAddress = (int)selectCreatedAddres.ExecuteScalar();

                string cmdAddToCustomersAddres = $"Insert into Customer_adress(Addres_id,Customer_id) Values({getAddress},{customer.Id})";
                SqlCommand insetToCustomer_address = new SqlCommand(cmdAddToCustomersAddres, con);
                insetToCustomer_address.ExecuteNonQuery(); 


                 this.Close();
                con.Close();
            }
        }
    }
}
