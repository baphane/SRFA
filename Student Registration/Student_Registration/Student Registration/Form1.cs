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

namespace Student_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding gender to a combobox
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Other");

            //selecting first item
            cboGender.SelectedIndex = 0;

            // Clear any existing data in the DataGridView
            string connect = @"Data Source=X\SQLEXPRESS;Initial Catalog=StudentRegistration;Integrated Security=True;";
            dgvRead.DataSource = null;

            // Establish a database connection
            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Students";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dgvRead.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Clear any existing data in the DataGridView
            string connect = @"Data Source=X\SQLEXPRESS;Initial Catalog=StudentRegistration;Integrated Security=True;";
            dgvRead.DataSource = null;

            // Establish a database connection
            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM Students";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dgvRead.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student(
                int.Parse(txtStdentID.Text),
                txtcoursecode.Text,
                txtname.Text,
                txtSurname.Text,
                txtPhoneNumber.Text,
                cboGender.Text,
                txtAdress.Text,
                dateTimePicker1.Value
                );

            handler.Update(student); 
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Student student = new Student(
                int.Parse(txtStdentID.Text),
                txtcoursecode.Text,
                txtname.Text,
                txtSurname.Text,
                txtPhoneNumber.Text,
                cboGender.Text,
                txtAdress.Text,
                dateTimePicker1.Value
                );

            handler.Register(student);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int studentID = int.Parse(txtSearch.Text);
            DataTable searchResults = handler.Search(studentID);
            dgvRead.DataSource = searchResults;
        }
    }
}
