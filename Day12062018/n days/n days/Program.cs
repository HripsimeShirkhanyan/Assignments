using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_days
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            int days = int.Parse(Console.ReadLine());
            const int s = 86400;
            int second = s * days;
            Console.WriteLine(second);
            //Console.WriteLine("{0}", second);
        }
    }
}
