using InheritancePractice;
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
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
    public class Program
    {
        public static void Main()
        {
            var person1 = new Person { firstName = "Tsun", lastName = "Pe", email = "tsunpe@email.me" };
            var person2 = new Person { firstName = "Schneup", lastName = "Doug", email = "schneupdoug@email.me"};

            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person2.GetHashCode());
            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.PersonWrite());
            Console.WriteLine(person2.PersonWrite());
        }
    }