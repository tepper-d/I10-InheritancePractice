using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*********************************************************
 * CIS 123: Introduction to Object-Oriented Programming
 * Module 10: Inheritance Assignment (Individual)
 * Dominique Tepper, 16JUN2022
 * 
 * 1-B/2. Complete the derived Student Class
 *          i. studentID       private string
 *         ii. use a getter and setter
 *        iii. define 2 constructors
 *         iv. StudentWrite    method
 * ********************************* Tepper, 06JUN2022 */
namespace InheritancePractice
{
    public class Student : Person
    {
        //i. private string
        private string studentID;

        //iii. constructor 1 - no parameters
        public Student() { }

        //iii. constructor 2 - student ID
        public Student(string firstName, string lastName, string email, string studentID) :
            base(firstName, lastName, email)
        {
            this.studentID = studentID;
        }

        //ii. Student getter & setter
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

        //iv. StudentWrite() as an override of the PersonWrite() method
        public override string PersonWrite() => 
            base.PersonWrite() + 
            " SID " + this.studentID;
    }
}
