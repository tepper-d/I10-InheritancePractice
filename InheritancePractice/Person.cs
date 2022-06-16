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
 *      a. Person       base
 *      b. Student      derived
 *      c. Faculty      derived
 *      d. Admin        derived
 *      e. Staff        derived
 * ******************************************************/

namespace InheritancePractice
{
/* ******************************************************
 * 1-A. Person class properties
 *          firstName   string
 *          lastName    string
 *          email       string    
 *      Method
 *      a. PersonWrite
 * ********************************* Tepper, 06JUN2022 */
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

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

        public override string ToString()
        {
            return $"Person(" +
                $"FirstName='{firstName}', " +
                $"LastName='{lastName}',  " +
                $"Email={email})";
        }

        public void SayHello()
        {
            Console.WriteLine($"Hi, I'm {firstName} {lastName}!");
        }
    }

}
