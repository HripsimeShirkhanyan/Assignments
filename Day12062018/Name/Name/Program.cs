using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hripsime Shirkhanyan, 24 years old.");
            string firstName = "Hripsime ";
            string lastName = "Shirkhanyan";
            int age = 24;
            Console.WriteLine(firstName + lastName);
            Console.WriteLine($"{age} years old.");
            //Console.WriteLine ("{0} years old", age)
        }
    }
}
