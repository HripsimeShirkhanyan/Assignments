using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Արտածել 1 - ից մինչև n բոլոր ամբողջ թվերը։
            //Console.WriteLine("Please write your number: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"{i} ");
            //}


            //Արտածել 1 - ից մինչև n բոլոր ամբողջ զույգ թվերը։
            //Console.WriteLine("Please enter your number: ");
            //int n = int.Parse(Console.ReadLine());
            //int i;
            //for (i = 1; i <= n; i++)
            //{
            //    if (i%2 == 0)                                                                                                   
            //    {
            //        Console.Write($"{i} ");
            //    }

            //}


            //Արտածել 1-ից մինչև n բոլոր ամբողջ կենտ թվերը։
            //Console.WriteLine("Please enter your number: ");
            //int n = int.Parse(Console.ReadLine());
            //int i;
            //for (i = 1; i <= n; i++)
            //{
            //    if (i%2 != 0)                                                                                                   
            //    {
            //        Console.Write($"{i} ");
            //    }

            //}



            //Հաշվել 1-ից մինչև n բոլոր ամբողջ թվերի գումարը և արտածել այն։
            //Console.WriteLine("Please write your number: ");
            //int n = int.Parse(Console.ReadLine());
            //int sum=0;
            //for (int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"The sum of the numbers from 1 to n is: {sum}");




            //Հաշվել a-ից մինչև b բոլոր ամբողջ թվերի գումարը և արտածել այն։
            //Console.WriteLine("Please write your number: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = a; i <= b; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"The sum of the numbers from {a} to {b} is: {sum}");



            //Հաշվել 1 - ից մինչև 15 բոլոր ամբողջ թվերի արտադրյալը և արտածել այն։\
            //int product = 1;
            //for (int i = 1; i <= 15; i++)
            //{
            //    product *= i;
            //}
            //Console.WriteLine($"The product of the numbers from 1-15 is: {product}"); ???



            //Տպել 1-999 միջակայքի այն թվերի գումարը, որոնց վրա առանց մնացորդի բաժանվում է տրված n բնական թիվը։
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= 999; i++)
            //{
            //    if (n % i == 0)
            //        sum += i;
            //}
            //Console.WriteLine(sum);



            //Տպել 1-999 միջակայքի այն թվերի արտադրյալը, որոնց վրա առանց մնացորդի բաժանվում է տրված n բնական թիվը։
            //int n = int.Parse(Console.ReadLine());
            //int product = 1;
            //for (int i = 1; i <= 999; i++)
            //{
            //    if (n % i == 0)
            //        product *= i;
            //}
            //Console.WriteLine(product);???



            //Տպել 1-999 միջակայքի այն թվերի գումարը, որոնց վրա տրված n բնական թիվը բաժանելիս կմնա 2 մնացորդ։
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= 999; i++)
            //{
            //    if (n % i == 2)
            //        sum += i;
            //}
            //Console.WriteLine(sum);



            //Տպել 1-999 միջակայքի այն թվերի արտադրյալը, որոնց վրա տրված n բնական թիվը բաժանելիս կմնա 3 մնացորդ։
            //double n = double.Parse(Console.ReadLine());
            //double product = 1;
            //for (double i = 1; i <= 999; i++)
            //{
            //    if (n % i == 3)
            //        product *= i;
            //}
            //Console.WriteLine(product);



            //Տպել բոլոր երկնիշ թվերի գումարը, որոնք բազմապատիկ են 3-ի։
            //int sum = 0;
            //for (int i = 10; i <= 99; i++)
            //{
            //    if (i % 3 == 0)
            //        sum += i;
            //}
            //Console.WriteLine(sum);



            //Տպել բոլոր երկնիշ թվերի արտադրյալը, որոնք բազմապատիկ են 3-ի և 5-ի։
            //double product = 1;
            //for (double i = 10; i <= 99; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0) //if (i % 15 == 0)
            //        
            //            product *= i;

            //}
            //Console.WriteLine(product);



            //Տպել բոլոր եռանիշ թվերի արտադրյալը, որոնց բազմապատիկ չեն 5-ի։
            //double product = 1;
            //for (double i = 100; i <= 999; i++)
            //{
            //    if (i % 5 != 0)
            //        product *= i;
            //}
            //Console.WriteLine(product);




            //Տպել բոլոր եռանիշ թվերի արտադրյալը, որոնց բազմապատիկ չեն 2 - ի և 3 - ի։
            //int product = 100;
            //for (int i = 100; i <= 999; i++)
            //{
            //    if (i % 2 != 0 && i % 3 != 0)
            //        product *= i;
            //}
            //Console.WriteLine(product);???




            //Տպել բոլոր եռանիշ թվերի արտադրյալը, որոնք 3 - ի բաժանելիս կմնա 1 մնացորդ, իսկ 4 - ի բաժանելիս՝ 2 մնացորդ։
            //int product = 1;
            //for (int i = 100; i <= 999; i++)
            //{
            //    if (i % 3 == 1 && i % 4 == 2)
            //        product *= i;
            //}
            //Console.WriteLine(product);



            //???? knereq, es mek@ chem haskanum vonc piti grem, u sranic kaxvac mnacacn el chem karum...Տպել ամենափոքր եռանիշ թիվը, որը 16 - ով բազմապատկելիս դառնում է բնական թվի քառակուսի։
            //double i = 1;
            //for (i = 100; i <= 999; i++)
            //{

            //    double a = i * 16;
            //    double b = Math.Sqrt(a);
            //    if (b - (int)b == 0)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

            //Տպել ամենափոքր քառանիշ թիվը, որը 26 - ով բազմապատկելիս դառնում է բնական թվի քառակուսի։



            //double i = 1;
            //for (i = 1000; i <= 9999; i++)
            //{

            //    double a = i * 26;
            //    double b = Math.Sqrt(a);
            //    if (b - (int)b == 0)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}





            //Տպել ամենամեծ քառանիշ թիվը, որը 14 - ով բազմապատկելիս դառնում է բնական թվի քառակուսի։????
            //double i = 1;
            //for (i = 1000; i <= 9999; i++)
            //{

            //    double a = i * 14;
            //    double b = Math.Sqrt(a);
            //    {
            //        if (b - (int)b == 0) ;
            //    }
            //}
            //Console.WriteLine(i);

            //Տպել ամենամեծ քառանիշ թիվը, որը 18 - ով բազմապատկելիս դառնում է բնական թվի քառակուսի։

            //?????



            //Տպել ամենափոքր եռանիշ թիվը, որի քառակուսի արմատը մեծ է տրված n բնական թվից։
            //int n = int.Parse(Console.ReadLine());
            //double i = 0;
            //for (i = 100; i <= 999; i++)
            //{
            //    double a = Math.Sqrt(i);
            //    if (a > n)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }

            //}



        }
    }
}

