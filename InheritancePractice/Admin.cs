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
* 1-D/4. Complete the derived Admin Class
*          i. AdminID       private string
*         ii. use a getter and setter
*        iii. define 2 constructors
*         iv. AdminWrite    method
* ********************************* Tepper, 16JUN2022 */
    namespace InheritancePractice
    {
        public class Admin : Person
        {
            //i. private string
            private string adminID;

            //iii. constructor 1 - no parameters
            public Admin() { }

            //iii. constructor 2 - admin ID
            public Admin(string firstName, string lastName, string email, string adminID) :
                base(firstName, lastName, email)
            {
                this.adminID = adminID;
            }

            //ii. Admin getter & setter
            //Tepper, 16JUN2022
            public string AdminID
            {
                get
                {
                    return adminID;
                }
                set
                {
                    this.adminID = value;
                }
            }

            //iv. AdminWrite() as an override of the PersonWrite() method
            /*public override string PersonWrite() =>
                base.PersonWrite() +
                "Admin ID: " + this.adminID;*/
            public void AdminWrite()
            {
                Console.WriteLine($"My name is {FirstName} {LastName}. Admin ID is {AdminID}.");
            }
        }
    }
}
