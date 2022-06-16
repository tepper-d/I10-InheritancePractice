using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Program
    {
        public static void Main()
        {
            var person1 = new Person { firstName = "Tsun", lastName = "Pe", email = "tsunpe@email.me" };
            var person2 = new Person { firstName = "Schneup", lastName = "Doug", email = "schneupdoug@email.me" };

            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person2.GetHashCode());
            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
