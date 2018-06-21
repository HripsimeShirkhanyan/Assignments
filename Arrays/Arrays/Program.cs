using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Ստեղծել միաչափ զանգված, որը կպարունակի ընթացիկ շաբաթվա ամսաթվերը։

            //string[] date = new string[] { "21 June", "22 June", "23 June", "24 June", "25 June", "26 June", "27 June"};
            //for (int i = 0; i < date.Length; i++)
            //{
            //    Console.Write($"{date[i]}, ");
            //}


            //2. Գրել ցիկլ, որը կարտածի միաչափ զանգվածի էլեմենտները։

            //string[] date = new string[] { "Monday", "Tuesday", "Wednesday", "Thirsday", "Friday", "Saturday", "Sunday" };
            //for (int i = 0; i < date.Length; i++)
            //{
            //Console.Write($"{date[i]}, ");
            //}



            // 3. Ստեղծել n երկարությամբ միաչափ զանգված և ցիկլով ներմուծել զնագվածի էլեմենտների արժեքները։
            //Console.Write("Type the dimension of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] num = new int[n];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine("Input elements: ");
            //    num[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("End of input Operation");

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write($"{num[i]}, ");
            //}


            //4.Ստեղծել զանգված, որի էլեմենտները կպարունակեն 1 - ից մինչև n ամբողջ թվերի քառակուսիները։
            //int n = int.Parse(Console.ReadLine());
            //int[] number = new int[n+1];
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(number[i] = i * i);
            //}


            //5. Հաշվել թվային զանգվածի էլեմենտների գումարը:
            //Console.Write("Type the dimension of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] number = new int[n];
            //int sum = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine("Please enter the elements: ");
            //    number[i] = int.Parse(Console.ReadLine());
            //    sum += number[i];
            //}
            //Console.WriteLine($"The sum of the elements is {sum}");


            //6. Հաշվել թվային զանգվածի էլեմենտների արտադրյալը։
            //Console.Write("Please enter the dimension of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] number = new int[n];
            //int product = 1;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine("Please input the elements: ");
            //    number[i] = int.Parse(Console.ReadLine());
            //    product *= number[i];
            //}
            //Console.WriteLine($"The product of the elements is {product}");


            //7. Գտնել թվային զանգվածի էլեմենտներից փոքրագույնը։????
            //Console.WriteLine("Please enter the dimension of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] number = new int[n];
            //float zero = 0;
            //float Min_number = 1 / zero;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine($"Enter elements: ");
            //    number[i] = int.Parse(Console.ReadLine());
            //    if (number[i] < Min_number)
            //    {
            //        Min_number = number[i];
            //    }

            //}

            //Console.WriteLine($"The minimum number is {Min_number}");



            //8. Գտնել թվային զանգվածի էլեմենտներից մեծագույնը։

            //Console.WriteLine("Please enter the dimension of the array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] number = new int[n];
            //float zero = 0;
            //float Max_number = -1 / zero;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine($"Enter elements: ");
            //    number[i] = int.Parse(Console.ReadLine());
            //    if (number[i] > Max_number)
            //    {
            //        Max_number = number[i];
            //    }

            //}

            //Console.WriteLine($"The maximum number is {Max_number}");


            //9. Գրել ծրագիր, որը կպատճենի a զանգվածը b զանգվածի մեջ։
            //Console.WriteLine("Please enter the dimension: ");
            //int a = int.Parse(Console.ReadLine());
            //int[] num1 = new int [a];
            //int[] b = new int[a];

            //for (int i = 0; i < num1.Length; i++)
            //{
            //    Console.WriteLine("enter the elements of the array a");
            //    num1[i] = int.Parse(Console.ReadLine());
            //    b[i] = num1[i];
            //    Console.WriteLine(b[i]);
            //}
            


            //10. Գրել ծրագիր, որը կհակադարձի զանգվածը։
            //Console.WriteLine("Please enter the dimension");
            //int n = int.Parse(Console.ReadLine());
            //int[] dimension = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Please input elements: ");
            //    dimension[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = n-1; i >= 0; i--)
            //{
            //    Console.Write($"{dimension[i]}, ");

            //}

            //11. Գրել ծրագիր, որը կգումարի էլեմենտ առ էլեմենտ a և b զանգվածները և արդյունքը կպահի c զանգվածի մեջ։
            //int[] a = new int[5] { 1, 2, 3, 4, 5};
            //int[] b = new int[5] { 7, 5, 8, 4, 2};
            //int[] c = new int[5];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    for (int j = 0; j < a.Length; j++)
            //    {
            //        c[i] = a[i] + b[i];
            //    }
            //}
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine($"The sum of a and b arrays is {c[i]}");
            //}


            // 12. Գրել ծրագիր, որը կբազմապատկի էլեմենտ առ էլեմենտ a և b զանգվածները և արդյունքը կպահի c զանգվածի մեջ
            //int[] a = new int[5] { 1, 2, 3, 4, 5 };
            //int[] b = new int[5] { 7, 5, 8, 4, 2 };
            //int[] c = new int[5];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    for (int j = 0; j < a.Length; j++)
            //    {
            //        c[i] = a[i] * b[i];
            //    }
            //}
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.WriteLine($"The product of a and b arrays is {c[i]}");
            //}
        }
    }
}
