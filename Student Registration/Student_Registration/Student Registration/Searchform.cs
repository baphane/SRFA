using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration
{
    public partial class Searchform : Form
    {
        public Searchform()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student student = new Student(int.Parse(txtStudentSerch.Text));

            DataHandler handler = new DataHandler();
            dataGridView1.DataSource = handler.Search(student.StudentID1);
        }
    }
}
