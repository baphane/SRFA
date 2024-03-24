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
    public partial class Deleteform : Form
    {
        public Deleteform()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = new Student(int.Parse(txtStudentDelete.Text));

            DataHandler handler = new DataHandler();
            handler.Delete(student.StudentID1);
        }
    }
}
