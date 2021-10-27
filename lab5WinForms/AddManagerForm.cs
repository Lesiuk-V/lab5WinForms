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
    }
}
