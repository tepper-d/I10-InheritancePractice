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
 * 1-C/3. Complete the derived Faculty Class
 *          i. facultyID       private string
 *         ii. use a getter and setter
 *        iii. define 2 constructors
 *         iv. FacultyWrite    method
 * ********************************* Tepper, 06JUN2022 */
    namespace InheritancePractice
    {
        public class Faculty : Person
        {
            //i. private string
            private string facultyID;

            //iii. constructor 1 - no parameters
            public Faculty() { }

            //iii. constructor 2 - faculty ID
            public Faculty(string firstName, string lastName, string email, string facultyID) :
                base(firstName, lastName, email)
            {
                this.facultyID = facultyID;
            }

            //ii. Student getter & setter
            public string FacultyID
            {
                get
                {
                    return facultyID;
                }
                set
                {
                    this.facultyID = value;
                }
            }

            //iv. StudentWrite() as an override of the PersonWrite() method
            public override string PersonWrite() =>
                base.PersonWrite() +
                "FID: " + this.facultyID;
        }
    }
}
