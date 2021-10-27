using lab5WinForms.Models;
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
    public partial class MainForm : Form
    {
        string ConnectionString = "Server=tcp:itacademy.database.windows.net;Database=lesyuk;User ID = lesyuk;Password=Dxm23487;Trusted_Connection=False;Encrypt=True";
        public MainForm()
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
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select Distinct Customers.PIB, Customers.Date_of_birth, Product.P_name, Mark_of_product.Mark, Relatives.PIB," +
                " Relatives.Who_for_customer from Customers  join Relatives on Customers.Id = Relatives.Customer_id join Mark_of_product on Customers.Id" +
                " = Mark_of_product.Customer_id join Product on Product.Id = Mark_of_product.Product_id Where Relatives.Who_for_customer IN('брат','сестра') " +
                "and Customers.Date_of_birth between '1980' and '1995' and Product.P_name = 'Шоколадні цукерки Каракум' and Mark_of_product.Mark > 3 ";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
            con.Close();
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


        private void addCustomers_Click(object sender, EventArgs e)
        {
            
            AddCustomerForm addCustomer = new AddCustomerForm();
            addCustomer.Show();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProduct = new AddProductForm();
            addProduct.Show();

        }

        private void addAddress_Click(object sender, EventArgs e)
        {
            AddAddressForm addAddress = new AddAddressForm();
            addAddress.Show();
        }

        private void addManager_Click(object sender, EventArgs e)
        {
            AddManagerForm addManager = new AddManagerForm();
            addManager.Show();
        }

        private void getCustomersKiivLvivIvanoFrankivsk_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select Customers.PIB, Address_c.City, Hobbi.Hobbi_name, Product.P_name, Mark_of_product.Mark from Customers " +
                "join Customer_adress on Customer_adress.Customer_id = Customers.Id join Address_c on Customer_adress.Addres_id = Address_c.Id join Customer_hobbi  " +
                "on Customer_hobbi.Customer_id = Customers.Id join Hobbi on Customer_hobbi.hobbi_id = Hobbi.Id join Mark_of_product on Mark_of_product.Customer_id = Customers.Id" +
                " join Product on Mark_of_product.Product_id = Product.Id where Address_c.City IN('Київ','Львів','Івано-Франківськ') and Hobbi.Hobbi_name = 'Займатися спортом' and Product.P_name" +
                " In('Шоколадне драже','Вафлі Артек') ";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
            con.Close();
        }

        private void getUsersLivedInKharkivNowInKiev_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string cmdText = "Select Distinct Customers.PIB, Customers.Plase_of_esidence, Address_c.City, Hobbi.Hobbi_name from Customers " +
               "join Customer_adress on Customer_adress.Customer_id = Customers.Id join Address_c on Customer_adress.Addres_id = Address_c.Id" +
               " join Customer_hobbi on Customer_hobbi.Customer_id = Customers.Id join Hobbi on Customer_hobbi.hobbi_id = Hobbi.Id where Customers.Plase_of_esidence" +
               " LIKE '%Київ%' and Address_c.City = 'Харків'and Hobbi.Hobbi_name = 'Читання книг'";
            SqlCommand comm = new SqlCommand(cmdText, con);
            SqlDataReader sqlDataReader = comm.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
            con.Close();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm updateCustomer = new AddCustomerForm(true);
            updateCustomer.Show();
        }

        private void updateProduct_Click(object sender, EventArgs e)
        {

            AddProductForm updateProduct = new AddProductForm(true);
            updateProduct.Show();
        }
    }
}
