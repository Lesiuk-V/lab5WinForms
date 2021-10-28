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
            if(ValidateForm())
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                string dateOfBirth = AgeDateTimePicker.Value.Year.ToString() + '-' + AgeDateTimePicker.Value.Month.ToString() + '-' + AgeDateTimePicker.Value.Day.ToString();
                string cmdText = $"UPDATE Customers SET PIB = '{PIBTextBox.Text}', Gender= '{genderTextBox.Text}', Plase_of_esidence = '{plase_of_esidenceTextBox.Text}', Date_of_birth = '{dateOfBirth}' WHERE Id ={idTextBox.Text}";

                SqlCommand comm = new SqlCommand(cmdText, con);
                comm.ExecuteNonQuery();
                this.Close();
                con.Close();
            }    
            else
                MessageBox.Show("Please enter valid data");
        }

        private void updateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = (Customer)updateComboBox.SelectedItem;
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


        private bool ValidateForm()
        {
            bool bValidSelectedCustomer = ValidateSelectedCustomer();
            bool bValidPIB = ValidatePIB();
            bool bValidGender = ValidateGender();
            bool bValidPlaceOfEsidence = ValidatePlaseOfEsidence();
            bool bValidDateOfBirth = ValidateDateOfBirth();
            if (bValidSelectedCustomer && bValidPIB && bValidGender && bValidPlaceOfEsidence && bValidDateOfBirth)
                return true;
            else
                return false;
        }

        private bool ValidateSelectedCustomer()
        {
            bool bStatus = true;
            if (updateComboBox.Text == "")
            {

                errorProvider1.SetError(updateComboBox, "Please select customer");
                bStatus = false;
            }
            else
                errorProvider1.SetError(updateComboBox, "");
            return bStatus;
        }

        private bool ValidatePIB()
        {
            bool bStatus = true;
            if (PIBTextBox.Text == "")
            {

                errorProvider2.SetError(PIBTextBox, "Please enter PIB");
                bStatus = false;
            }
            else
                errorProvider2.SetError(PIBTextBox, "");
            return bStatus;
        }
        private bool ValidateGender()
        {
            bool bStatus = true;
            if (genderTextBox.Text == "")
            {

                errorProvider3.SetError(genderTextBox, "Please enter gender");
                bStatus = false;
            }
            else
                errorProvider3.SetError(genderTextBox, "");
            return bStatus;
        }
        private bool ValidatePlaseOfEsidence()
        {
            bool bStatus = true;
            if (plase_of_esidenceTextBox.Text == "")
            {

                errorProvider4.SetError(plase_of_esidenceTextBox, "Please enter plase of esidence");
                bStatus = false;
            }
            else
                errorProvider4.SetError(plase_of_esidenceTextBox, "");
            return bStatus;
        }
        private bool ValidateDateOfBirth()
        {
            bool bStatus = true;
            if (AgeDateTimePicker.Text == "")
            {

                errorProvider5.SetError(AgeDateTimePicker, "Please enter date of birth");
                bStatus = false;
            }
            else
                errorProvider5.SetError(AgeDateTimePicker, "");
            return bStatus;
        }

        private void updateComboBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateSelectedCustomer();
        }

        private void PIBTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidatePIB();
        }

        private void genderTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateGender();
        }

        private void plase_of_esidenceTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidatePlaseOfEsidence();
        }

        private void AgeDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateOfBirth();
        }
    }
}
