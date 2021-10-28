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
            updateButton.Visible = false;
            updateLable.Visible = false;
            updateComboBox.Visible = false;
            idTextBox.Visible = false;
            idLabel.Visible = false;
        } 
        public AddAddressForm(bool a)
        {
            InitializeComponent();
            CustomerComboBox.Visible = false;
            label1.Visible = false;
            label2.Text = "Update address";
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
            con.Open();

            string cmdText1 = "Select Id,Region, City, Street, Building from Address_c";
            SqlCommand comm1 = new SqlCommand(cmdText1, con);
            SqlDataReader sqlDataReader1 = comm1.ExecuteReader();

            while (sqlDataReader1.Read())
            {
                Address address = new Address();
                address.Id = (int)sqlDataReader1[0];
                address.Region = (string)sqlDataReader1[1];
                address.City = (string)sqlDataReader1[2];
                address.Street = (string)sqlDataReader1[3];
                address.Building = (string)sqlDataReader1[4];
                updateComboBox.Items.Add(address);
                updateComboBox.DisplayMember = "FullAddress";
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


        private void updateButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                string cmdText = $"UPDATE Address_c SET Region = '{regionTextBox.Text}', City= '{cityTextBox.Text}', Street = '{streetTextBox.Text}', Building = '{buildingTextBox.Text}' WHERE Id ={idTextBox.Text}";
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
            Address address = (Address)updateComboBox.SelectedItem;
            regionTextBox.Text = address.Region;
            cityTextBox.Text = address.City;
            streetTextBox.Text = address.Street;
            buildingTextBox.Text = address.Building;
            idTextBox.Text = Convert.ToString(address.Id);
        }

        private bool ValidateForm()
        {
            bool bValidSelectedAddress = ValidateSelectedAddress();
            bool bValidRegion = ValidateRegion();
            bool bValidCity = ValidateCity();
            bool bValidStreet = ValidateStreet();
            bool bValidBuilding = ValidateBuilding();
            if (bValidSelectedAddress && bValidRegion && bValidCity && bValidStreet && bValidBuilding)
                return true;
            else
                return false;
        }

        private bool ValidateSelectedAddress()
        {
            bool bStatus = true;
            if (updateComboBox.Text == "")
            {

                errorProvider1.SetError(updateComboBox, "Please select address");
                bStatus = false;
            }
            else
                errorProvider1.SetError(updateComboBox, "");
            return bStatus;
        }

        private bool ValidateRegion()
        {
            bool bStatus = true;
            if (regionTextBox.Text == "")
            {

                errorProvider2.SetError(regionTextBox, "Please enter region");
                bStatus = false;
            }
            else
                errorProvider2.SetError(regionTextBox, "");
            return bStatus;
        }
        private bool ValidateCity()
        {
            bool bStatus = true;
            if (cityTextBox.Text == "")
            {

                errorProvider3.SetError(cityTextBox, "Please enter city");
                bStatus = false;
            }
            else
                errorProvider3.SetError(cityTextBox, "");
            return bStatus;
        }
        private bool ValidateStreet()
        {
            bool bStatus = true;
            if (streetTextBox.Text == "")
            {

                errorProvider4.SetError(streetTextBox, "Please enter street");
                bStatus = false;
            }
            else
                errorProvider4.SetError(streetTextBox, "");
            return bStatus;
        }
        private bool ValidateBuilding()
        {
            bool bStatus = true;
            if (buildingTextBox.Text == "")
            {

                errorProvider5.SetError(buildingTextBox, "Please enter building");
                bStatus = false;
            }
            else
                errorProvider5.SetError(buildingTextBox, "");
            return bStatus;
        }

        private void updateComboBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateSelectedAddress();
        }

        private void regionTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateRegion();
        }

        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateCity();
        }

        private void streetTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateStreet();
        }

        private void buildingTextBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateBuilding();
        }
    }
}
