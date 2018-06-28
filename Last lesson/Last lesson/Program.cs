using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_lesson
{
    class Program
    {
        //static void Main(string[] args) { }

        //1. Գրել ֆունկցիա, որը կվերադարձնի true, եթե արգումենտում փոխանցված ամբողջ թիվը զույգ է և false՝ եթե կենտ է։
        //{    
        //    Program.TF();

        //}

        //    static int TF()
        //{ 
        //    Console.Write("Please enter your number: ");
        //    int num = int.Parse(Console.ReadLine());
        //    if (num % 2 == 0)
        //    {
        //        Console.WriteLine("The statement that the number is even is True");

        //    }
        //    else
        //    {
        //        Console.WriteLine("The statement that the number is even is False");
        //    }
        //    return num;
        //}



        //{ 
        //2. Գրել ֆունկցիա, որը կվերադարձնի արգումենտում փոխանցված զանգվածը հակադարձած։
        //static void Main(string[] args)
        // {
        //    int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        //    int b = ReverseArray(a);

        //}
        //static int ReverseArray(int[] num)
        //{
        //    int a = num.Length;
        //    for (int i = num.Length - 1; i >= 0; i--)
        //    {
        //        Console.Write(num[i]);
        //    }
        //    return a;
        //}
        // }

        //3. Գրել ֆունկցիա, որը կվերադարձնի արգումենտում փոխանցված թվային զանգվածի ամենամեծ(ամենափոքր) էլեմենտի արժեքը։
        // static void Main(string[] args)
        //{
        //    int[] num = new int [] { 1, 2, 5, 9, 4, 3, 5 };
        //    int maxValue = myMaxValue(num);
        //    int minValue = myMinValue(num);
        //}
        //static int myMaxValue(int[] mymax)
        //{
        //    int n = 0;
        //    for (int i = 0; i < mymax.Length; i++)
        //    {

        //        Console.WriteLine($"The max value of the given array is: {mymax.Max()}");

        //        break;
        //    }
        //    return n;
        //}
        //static int myMinValue(int[] mymin)
        //{
        //    int k = 0;
        //    for (int i = 0; i < mymin.Length; i++)
        //    {
        //        Console.WriteLine($"The min value of the given array is: {mymin.Min()}");
        //        break;
        //    }

        //    return k;
        //}




        //4. ????Գրել ֆունկցիա, որը կվերադարձնի արգումենտում փոխանցված թվային զանգվածի ամենամեծ(ամենափոքր) էլեմենտի ինդեքսը։
        //static void Main(string[] args)
        //{
        //    int[] array = new int[] { 9, 2, 3, 5, 8, 10, 5, 4, 1, 7 };
        //    int maxind = index(array);
        //    int minind = index(array);

        //}
        //static int index(int[] num)
        //{
        //    int a = 0;
        //    for (int i = 0; i < num.Length; i++)
        //    {

        //        }

        //    }

        //    return a;
        //}




        //5. Գրել ֆունկցիա, որը կվերադարձնի արգումենտում փոխանցված երկու թվային զանգվածների գումարը(արտադրյալը)։
        //static void Main(string[] args)
        //{
        //    int[] array1 = { 1, 2, 3, 4, 5};
        //    int[] array2 = { 5, 4, 3, 2, 1};

        //    int sum = ArraySum(array1, array2);
        //    int product = ArrayProduct(array1, array2);
        //    Console.WriteLine(sum);

        //    Console.WriteLine(product);

        //}
        //static int ArraySum(int[] firstArray, int[] secondArray)
        //{
        //    int sum1 = 0;
        //    int sum2 = 0;
        //    for (int i = 0; i < firstArray.Length; i++)
        //    {
        //        sum1 += firstArray[i];
        //    }
        //    for (int i = 0; i < secondArray.Length; i++)
        //    {
        //        sum2 += secondArray[i];
        //    }
        //    int sumarr1arr2 = sum1 + sum2;
        //    return sumarr1arr2;
        //}
        //static int ArrayProduct(int[] firstArray, int[] secondArray)
        //{
        //    int product1 = 1;
        //    int product2 = 1;
        //    for (int i = 0; i < firstArray.Length; i++)
        //    {
        //        product1 *= firstArray[i];
        //    }
        //    for (int i = 0; i < secondArray.Length; i++)
        //    {
        //        product2 *= secondArray[i];
        //    }
        //    int productarr1arr2 = product1 * product2;
        //    return productarr1arr2;
        //}



        //6. ???Գրել ֆունկցիա, որը արգումենտում փոխանցված թվային զանգվածը էլեմենտ առ էլեմենտ կբազմապատկի(կգումարի) արգումենտում փոխանցված թվով։
        //        static void Main(string[] args)

        //        {
        //            int[] array = { 12, 13, 14, 15, 16 };
        //            int d = int.Parse(Console.ReadLine());
        //            int sum = ArraySum(array);
        //            int product = ArrayProduct(array);
        //            Console.WriteLine(sum + d);
        //            Console.WriteLine(product * d);
        //        }
        //        static int ArraySum(int[] a)
        //        {


        //            int SumofArray = 0;
        //            for (int i = 0; i < a.Length; i++)
        //            {
        //                a[i] += 5;

        //            }

        //            return SumofArray;
        //        }
        //        static int ArrayProduct(int[] b)
        //        {
        //            int a = 1;
        //            int ProductofArray = 1;

        //            for (int i = 1; i < b.Length; i++)
        //            {
        //                b[i] *= 7;


        //            }

        //            return a;
        //        }

        //    }

        //}





        //7. Գրել ֆունկցիա, որը կվերադարձնի միաչափ զանգված, որի էլէմնտները պատահական թվեր են 0 - ից 10 տիրույթի։


        //static void Main(string[] args)
        //{
        //    rdm_number(1);

        //}
        //static int rdm_number(int r_number)
        //{
            
        //    Random rd = new Random();   
        //    int x = int.Parse(Console.ReadLine());
        //    int y = int.Parse(Console.ReadLine());
        //    int rrr = rd.Next(x, y);
        //    int[] RandomArray = new int[rrr];
        //    for (int i = 0; i < RandomArray.Length; i++)
        //    {
        //        RandomArray[i] = rd.Next(0, 10);
        //        Console.WriteLine($"{RandomArray[i]}   ");
        //    }
        //    return rrr;
        //}
    }
}


