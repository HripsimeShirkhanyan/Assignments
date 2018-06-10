using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 4;
            double perimeter = 2 * a + 2 * b;
            double area = a * b;
            Console.WriteLine($"When one side is 2, and the other is 4.\nThe perimeter is: {perimeter}\nThe area is: {area}");
            Console.WriteLine("When the sides are not given.\nPlease enter the length: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width: ");
            double b1 = double.Parse(Console.ReadLine());
            double perimeter1 = 2 * a1 + 2 * b1;
            double area1 = a1 * b1;
            Console.WriteLine($"The perimeter is: {perimeter1}\nThe area is: {area1}");
        }
    }
}
