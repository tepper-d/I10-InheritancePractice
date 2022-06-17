using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Student : Person
    {
        private string studentID;

        public Student() { }

        public Student(string firstName, string lastName, string email, string studentID) :
            base(firstName, lastName, email)
        {
            this.studentID = studentID;
        }

        public string StudentID
        {
            get 
            { 
                return studentID; 
            }
            set 
            { 
                this.studentID = value; 
            }
        }

        public override string PersonWrite() => 
            base.PersonWrite() + 
            " SID " + this.studentID;
    }
}
