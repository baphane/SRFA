using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Registration
{
    internal class DataHandler
    {
        public DataHandler() { }
        

        static string connect = @"Data Source=X\SQLEXPRESS;Initial Catalog=StudentRegistration;Integrated Security=True;";

        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;

        public void Register(Student student)
        {
            string query = $"INSERT INTO Students (StudentID, StudentName, StudentSurname, CourseCode, Phone, DOB) " +
                           $"VALUES('{student.StudentID1}', '{student.Name1}', '{student.Surname1}', '{student.CourseCode1}', '{student.Phone1}', '{student.DOB1.ToString("yyyy-MM-dd")}')";

            conn = new SqlConnection(connect);
            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Student information saved");
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Student information not showing" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Update(Student student)
        {
            string query = $"UPDATE Students SET " +
                           $"StudentNumber = '{student.StudentID1}', " +
                           $"StudentName = '{student.Name1}', " +
                           $"StudentSurname = '{student.Surname1}', " +
                           $"CourseCode = '{student.CourseCode1}', " +
                           $"Address = '{student.Address1}', " +
                           $"Gender = '{student.Gender1}', " +
                           $"DOB = '{student.DOB1.ToString("yyyy-MM-dd")}' " +
                           $"WHERE StudentID = {student.StudentID1}";

            conn = new SqlConnection(connect);
            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Student information updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student information: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Delete(int studentID)
        {
            string query = $"DELETE FROM Students WHERE StudentID = {studentID}";

            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student record deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("No student record found with the specified ID");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error deleting student record: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }
        }


        public DataTable Search(int studentID)
        {
            DataTable dt = new DataTable();

            string query = $"SELECT * FROM Students WHERE StudentID = '{studentID}'";

            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error searching student records: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message);
                }
            }

            return dt;
        }


    }

}

   

