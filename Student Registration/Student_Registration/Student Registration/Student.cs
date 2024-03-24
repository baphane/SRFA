using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration
{
    public class Student
    {

        public Student(int studentID, string courseCode, string name, string surname, string phone, string gender, string address, DateTime dob)
        {
            this.StudentID1 = studentID;
            this.CourseCode1 = courseCode;
            this.Name1 = name;
            this.Surname1 = surname;
            this.Phone1 = phone;
            this.Gender1 = gender;
            this.Address1 = address;
            this.DOB1 = dob;
        }

        public Student(int studentID)
        {
            this.StudentID1 = studentID;
        }

        private int StudentID;
        private string CourseCode;
        private string Name;
        private string Surname;
        private string Phone;
        private string Gender;
        private string Address;
        private DateTime DOB;

        public int StudentID1 { get => StudentID; set => StudentID = value; }
        public string CourseCode1 { get => CourseCode; set => CourseCode = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string Address1 { get => Address; set => Address = value; }
        public DateTime DOB1 { get => DOB; set => DOB = value; }
    }
}
