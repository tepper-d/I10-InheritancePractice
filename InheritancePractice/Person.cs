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
 * 1. Complete the base and derived classes:
 *      a.   Person       base
 *      b/2. Student      derived
 *      c/3. Admin      derived
 *      d/4. Admin        derived
 *      e/5. Staff        derived
 * ******************************************************/

namespace InheritancePractice
{
/* ******************************************************
 * 1-A Person class properties
 *          firstName   string
 *          lastName    string
 *          email       string    
 *      Method
 *          a. PersonWrite
 * ********************************* Tepper, 06JUN2022 */
    public class Person
    {
        public string firstName;
        public string lastName;
        public string email;

        public Person() { }

        public Person(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "First name must not exceed 50 characters", "Input Error");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get 
            { 
                return lastName; 
            }
            set
            {
                if (value.Length > 60)
                {
                    throw new ArgumentException(
                        "Last name must not exceed 60 characters", "Input Error");
                }
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Length > 70)
                {
                    throw new ArgumentException(
                        "Email must not exceed 70 characters", "Input Error");
                }
                email = value;
            }
        }


        public override bool Equals(object obj)
        {
            return obj is Person person &&
               firstName == person.firstName &&
               lastName == person.lastName &&
               email == person.email;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(firstName, lastName, email).GetHashCode();
        }

        public virtual string PersonWrite()
        {
            return $"Person(" +
                $"FirstName='{firstName}', " +
                $"LastName='{lastName}',  " +
                $"Email={email})";
        }

        /*public void SayHello()
        {
            Console.WriteLine($"Hi, I'm {firstName} {lastName}!");
            Console.WriteLine($"Email me at {email} anytime.");
        }*/
    }

}
