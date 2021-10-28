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
    public partial class AddManagerForm : Form
    {
        string ConnectionString = "Server=tcp:itacademy.database.windows.net;Database=lesyuk;User ID = lesyuk;Password=Dxm23487;Trusted_Connection=False;Encrypt=True";
        public AddManagerForm()
        {
            InitializeComponent();
            managerBindingSource.DataSource = new Manager();
            updateButton.Visible = false;
            updateLabel.Visible = false;
            updateComboBox.Visible = false;
            idTextBox.Visible = false;
            idLabel.Visible = false;

        }
        public AddManagerForm(bool a)
        {
            InitializeComponent();
            label1.Text = "Update manager";
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            managerBindingSource.EndEdit();
            Manager manager = managerBindingSource.Current as Manager;
            if (manager != null)
            {

                ValidationContext context = new ValidationContext(manager, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(manager, context, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                string dateOfBirth = dateOfBirthDateTimePicker.Value.Year.ToString() + '-' + dateOfBirthDateTimePicker.Value.Month.ToString() + '-' + dateOfBirthDateTimePicker.Value.Day.ToString();
                string cmdText = $"Insert into Manager(PIB, Date_od_birth, Gender) values('{manager.PIB}','{dateOfBirth}','{manager.Gender}')";

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
                string dateOfBirth = dateOfBirthDateTimePicker.Value.Year.ToString() + '-' + dateOfBirthDateTimePicker.Value.Month.ToString() + '-' + dateOfBirthDateTimePicker.Value.Day.ToString();
                string cmdText = $"UPDATE Manager SET PIB = '{pIBTextBox.Text}', Gender= '{genderTextBox.Text}', Date_od_birth = '{dateOfBirth}' WHERE Id ={idTextBox.Text}";

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
            Manager manager = (Manager)updateComboBox.SelectedItem;
            label1.Text = "Update Customer";
            pIBTextBox.Text = manager.PIB;
            genderTextBox.Text = manager.Gender;
            dateOfBirthDateTimePicker.Value = DateTime.Parse(manager.DateOfBirth);
            idTextBox.Text = Convert.ToString(manager.Id);
            managerBindingSource.DataSource = manager;

        }

        private void pIBTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidatePIB();
        }
        private bool ValidatePIB()
        {
            bool bStatus = true;
            if (pIBTextBox.Text == "")
            {
                
                errorProvider2.SetError(pIBTextBox, "Please enter PIB");
                bStatus = false;
            }
            else
                errorProvider2.SetError(pIBTextBox, "");
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
        private bool ValidateAge()
        {
            bool bStatus = true;
            if (dateOfBirthDateTimePicker.Text == "")
            {

                errorProvider4.SetError(dateOfBirthDateTimePicker, "Please select date");
                bStatus = false;
            }
            else
                errorProvider4.SetError(dateOfBirthDateTimePicker, "");
            return bStatus;
        }

        private bool ValidateSelectedManager()
        {
            bool bStatus = true;
            if (updateComboBox.Text == "")
            {

                errorProvider1.SetError(updateComboBox, "Please select manager");
                bStatus = false;
            }
            else
                errorProvider1.SetError(updateComboBox, "");
            return bStatus;
        }


        private bool ValidateForm()
        {
            bool bValidName = ValidatePIB();
            bool bValidGender = ValidateGender();
            bool bValidAge = ValidateAge();
            bool bValideSelectedManager = ValidateSelectedManager();
            if (bValidName && bValidGender && bValidAge && bValideSelectedManager)
                return true;
            else
            return false;
        }

        private void genderTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateGender();
        }

        private void dateOfBirthDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            ValidateAge();
        }

        private void updateComboBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateSelectedManager();
        }

        private void AddManagerForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select Id, PIB, Gender, Date_od_birth from Manager";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Manager manager = new Manager();
                manager.Id = (int)sqlDataReader[0];
                manager.PIB = (string)sqlDataReader[1];
                manager.Gender = (string)sqlDataReader[2];
                DateTime date = DateTime.Parse(Convert.ToString(sqlDataReader[3]));
                string dateOfBirth = date.Year.ToString() + '-' + date.Month.ToString() + '-' + date.Day.ToString();
                manager.DateOfBirth = dateOfBirth;
                updateComboBox.Items.Add(manager);
                updateComboBox.DisplayMember = "PIB";
            }
            con.Close();
        }
    }
}
