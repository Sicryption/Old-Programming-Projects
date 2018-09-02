using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Account_Creator
{
    class Student
    {
        private string studentFirstName = "",
            studentLastName = "",
            studentID = "",
            studentES = "",
            studentGrade = "",
            parentFirstName = "",
            parentLastName = "",
            parentEmail = "",
            username = "",
            password = "";


        public Student()
        {

        }

        public override string ToString()
        {
            return "Name: " + studentFirstName + " " + studentLastName +
                "\nID: " + studentID +
                "\nES: " + studentES +
                "\nGrade: " + studentGrade +
                "\nParent Name: " + parentFirstName + " " + parentLastName +
                "\nParent Email: " + parentEmail;
        }

        public Student(string fullName, string ID,
            string Grade, string parentFirst, string parentLast, string Email)
        {
            string[] name = fullName.Split(new char[] { ' ' });
            studentFirstName = name[0];
            studentLastName = name[1];
            studentID = ID;
            studentGrade = Grade;
            parentFirstName = parentFirst;
            parentLastName = parentLast;
            parentEmail = Email;
        }

        public Student(string fullName, string ID, string ES)
        {
            string[] name = fullName.Split(new char[] { ' ' });
            studentFirstName = name[0];
            studentLastName = name[1];
            studentID = ID;
            studentES = ES;
        }

        public string StudentFirstName { get { return studentFirstName; } set { studentFirstName = value; } }
        public string StudentLastName { get { return studentLastName; } set { studentLastName = value; } }
        public string StudentID { get { return studentID; } set { studentID = value; } }
        public string StudentES { get { return studentES; } set { studentES = value; } }
        public string StudentGrade { get { return studentGrade; } set { studentGrade = value; } }
        public string ParentFirstName { get { return parentFirstName; } set { parentFirstName = value; } }
        public string ParentLastName { get { return parentLastName; } set { parentLastName = value; } }
        public string ParentEmail { get { return parentEmail; } set { parentEmail = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
    }
}