using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    /*********************************************************
    * CIS 123: Introduction to Object-Oriented Programming
    * Module 10: Inheritance Assignment (Individual)
    * Dominique Tepper, 16JUN2022
    * 
    * 1-E/5. Complete the derived Staff Class
    *          i. staffID       private string
    *         ii. use a getter and setter
    *        iii. define 2 constructors
    *         iv. StaffWrite    method
    * ********************************* Tepper, 16JUN2022 */
    namespace InheritancePractice
    {
        public class Staff : Person
        {
            //i. private string
            private string staffID;

            //iii. constructor 1 - no parameters
            public Staff() { }

            //iii. constructor 2 - staff ID
            public Staff(string firstName, string lastName, string email, string staffID) :
                base(firstName, lastName, email)
            {
                this.staffID = staffID;
            }

            //ii. Staff getter & setter
            //Tepper, 16JUN2022
            public string StaffID
            {
                get
                {
                    return staffID;
                }
                set
                {
                    this.staffID = value;
                }
            }

            //iv. StaffWrite() as an override of the PersonWrite() method
            /*public override string PersonWrite() =>
                base.PersonWrite() +
                "Staff ID: " + this.staffID;*/

            public void StaffWrite()
            {
                Console.WriteLine($"My name is {FirstName} {LastName}. Student ID is {StaffID}.");
            }
        }
    }
}
