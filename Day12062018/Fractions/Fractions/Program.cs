using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = (double)6 / 5;
            double b = (double)2 / 5;
            double sum = a + b;
            //Console.WriteLine("Write as a fraction: {0}", sum);
            Console.WriteLine($"Write as a fraction: {sum}");
            int sum1 = (int)sum;
            Console.WriteLine("Write as an integer: {0}", sum1);
        }
    }
}
