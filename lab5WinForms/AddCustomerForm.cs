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
    public partial class AddCustomerForm : Form
    {
        string ConnectionString = "Server=tcp:itacademy.database.windows.net;Database=lesyuk;User ID = lesyuk;Password=Dxm23487;Trusted_Connection=False;Encrypt=True";
        public AddCustomerForm()
        {
            InitializeComponent();
            customerBindingSource.DataSource = new Customer();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = new Customer();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            customerBindingSource.EndEdit();
            Customer customer = customerBindingSource.Current as Customer;
            if(customer != null)
            {

                ValidationContext context = new ValidationContext(customer, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if(!Validator.TryValidateObject(customer,context,errors,true))
                {
                    foreach(ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string dateOfBirth = AgeDateTimePicker.Value.Year.ToString() + '-' + AgeDateTimePicker.Value.Month.ToString() + '-' + AgeDateTimePicker.Value.Day.ToString();
                string cmdText = $"Insert into Customers(PIB, Date_of_birth, Gender, Plase_of_esidence) values('{customer.PIB}','{dateOfBirth}','{customer.Gender}','{customer.Plase_of_esidence}')";

                SqlCommand comm = new SqlCommand(cmdText, con);
                comm.ExecuteNonQuery();
                this.Close();
                con.Close(); 
            }
        }
    }
}
