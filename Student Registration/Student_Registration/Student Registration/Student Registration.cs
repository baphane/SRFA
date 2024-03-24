using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    class Student_Registration
    {
        private string name, surname, gender, address, coursecode, phonenum;
        private int studentID;
        private DateTime dob;

        public Student_Registration(string name, string surname, string gender, string address, string coursecode, string phonenum, int studentID, DateTime dob)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Address = address;
            this.Coursecode = coursecode;
            this.Phonenum = phonenum;
            this.StudentID = studentID;
            this.Dob = dob;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string Coursecode { get => coursecode; set => coursecode = value; }
        public string Phonenum { get => phonenum; set => phonenum = value; }
        public int StudentID { get => studentID; set => studentID = value; }
        public DateTime Dob { get => dob; set => dob = value; }

        public override string ToString()
        {
            

            return "Name"+this.Name+"|Surname"+this.Surname+"|Gender"+this.Gender+"|Adress"+this.Address+"|CourseCode"+this.Coursecode+"|phonenum"+this.Phonenum+"|studentID"+this.StudentID+"|Dob"+this.Dob;
        }
    }
}
