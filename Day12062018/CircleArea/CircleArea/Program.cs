﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            const double pi = 3.14;
            double area = pi * radius * radius;
            Console.WriteLine(area);
        }
    }
}
