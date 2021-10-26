using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5WinForms
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Server=tcp:itacademy.database.windows.net;Database=lesyuk;User ID = lesyuk;Password=Dxm23487;Trusted_Connection=False;Encrypt=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void getCustomers_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select* from Customers";
            SqlCommand comm = new SqlCommand(cmdText,con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
            con.Close();
        }

        private void getUsersBetwen1980and1955_Click(object sender, EventArgs e)
        {
          
        }

        private void getProducts_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select Product.P_name, Product.Category, Manager.PIB from Product inner join Manager on Product.Manager_id = Manager.Id";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
            con.Close();
        }

        private void getAddress_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select Customers.PIB, Address_c.Region, Address_c.City, Address_c.Street, Address_c.Building from Customers " +
                "inner join Customer_adress on Customer_adress.Customer_id = Customers.Id inner join Address_c on Customer_adress.Addres_id = Address_c.Id";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
            con.Close();
        }

        private void getManagers_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select* from Manager";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdTextCustomers = "Select Id, PIB from Customers";
            string cmdTextAddress = "Select Id, City from Address_c";
            string cmdTextProduct = "Select Id, P_name from Product";
            string cmdTextManagers = "Select Id, PIB from Manager";
            SqlCommand commCustomer = new SqlCommand(cmdTextCustomers, con);
            SqlDataReader sqlDataReaderCustomer = commCustomer.ExecuteReader();


           /* 
            SqlCommand commAddress = new SqlCommand(cmdTextAddress, con);
            SqlDataReader sqlDataReaderAddress = commAddress.ExecuteReader();

            
            SqlCommand commManagers = new SqlCommand(cmdTextManagers, con);
            SqlDataReader sqlDataReaderManagers = commManagers.ExecuteReader();

            
            SqlCommand commProduct = new SqlCommand(cmdTextProduct, con);
            SqlDataReader sqlDataReaderProduct = commProduct.ExecuteReader();
*/
            updateCustomerComboBox.Items.Clear();
            updateAddressComboBox.Items.Clear();
            updateManagerComboBox.Items.Clear();
            updateProductComboBox.Items.Clear();
            while(sqlDataReaderCustomer.Read())
            {
                updateCustomerComboBox.Items.Add(sqlDataReaderCustomer[1]);
               /* updateAddressComboBox.Items.Add(sqlDataReaderAddress[1]);
                updateManagerComboBox.Items.Add(sqlDataReaderManagers[1]);
                updateProductComboBox.Items.Add(sqlDataReaderProduct[1]);*/
;           }
            con.Close();

        }

        private void addCustomers_Click(object sender, EventArgs e)
        {
            
            AddCustomerForm addCustomer = new AddCustomerForm();
            addCustomer.Show();
        }
    }
}
