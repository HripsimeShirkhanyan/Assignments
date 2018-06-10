using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleLength
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            const double pi = 3.14;
            double c = 2 * pi * radius;
            Console.WriteLine(c);
        }
    }
}
