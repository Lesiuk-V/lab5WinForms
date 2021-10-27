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
            updateButton.Visible = false;
            updateLabel.Visible = false;
            updateComboBox.Visible = false;
            idTextBox.Visible = false;
            idLabel.Visible = false;
           
        }
        public AddCustomerForm(bool a)
        {
            InitializeComponent();
            label2.Text = "Update customer";
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



        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
/*            ValidationContext context = new ValidationContext(customer, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(customer, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }*/
            string dateOfBirth = AgeDateTimePicker.Value.Year.ToString() + '-' + AgeDateTimePicker.Value.Month.ToString() + '-' + AgeDateTimePicker.Value.Day.ToString();
            string cmdText = $"UPDATE Customers SET PIB = '{PIBTextBox.Text}', Gender= '{genderTextBox.Text}', Plase_of_esidence = '{plase_of_esidenceTextBox.Text}', Date_of_birth = '{dateOfBirth}' WHERE Id ={idTextBox.Text}";

            SqlCommand comm = new SqlCommand(cmdText, con);
            comm.ExecuteNonQuery();
            this.Close();
            con.Close();
        }

        private void updateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)updateComboBox.SelectedItem;
            label2.Text = "Update Customer";
            PIBTextBox.Text = customer.PIB;
            genderTextBox.Text = customer.Gender;
            plase_of_esidenceTextBox.Text = customer.Plase_of_esidence;
            AgeDateTimePicker.Value = DateTime.Parse(customer.Date_of_birth);
            idTextBox.Text = Convert.ToString(customer.Id);
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select Id, PIB, Gender, Plase_of_esidence,Date_of_birth from Customers";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.Id = (int)sqlDataReader[0];
                customer.PIB = (string)sqlDataReader[1];
                customer.Gender = (string)sqlDataReader[2];
                customer.Plase_of_esidence = (string)sqlDataReader[3];
                DateTime date = DateTime.Parse(Convert.ToString(sqlDataReader[4]));
                string dateOfBirth = date.Year.ToString() + '-' + date.Month.ToString() + '-' + date.Day.ToString();
                customer.Date_of_birth = dateOfBirth;
                updateComboBox.Items.Add(customer);
                updateComboBox.DisplayMember = "PIB";
            }
            con.Close();
        }
    }
}
