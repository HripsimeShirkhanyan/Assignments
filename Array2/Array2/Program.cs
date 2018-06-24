using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. գրել կրկնակի ցիկլ, որը կարտածի երկչափ զանգվածի էլեմենտները աղյուսակի տեսքով։
            //int[,] myArray = new int [2, 2] 
            //{
            //    { 1, 2 },
            //    { 3, 4 }
            //};
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int k = 0; k < 2; k++)
            //    {
            //        Console.Write($"{myArray[i, k]} ");
            //    }
            //    Console.WriteLine();
            //}



            // 2. Ստեղծել զանգված, որը կպարունակի շախմատի խաղատախտակի դաշտերի անվանումները։

            //    int[,] chess = new int[8, 8];
            //    for (int i = 0; i < 8; i++)
            //    {
            //        for (int j = 0; j < 8; j++)
            //        {
            //            if ((i + j) % 2 == 1)
            //            {
            //                chess[i, j] = 1;

            //            }
            //            Console.Write(chess[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }

            //}
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {

            //    }

            //}




            //3. Chgitem vonc anem vor sirun artahanvi :)//Ստեղծել երկչափ զանգված, որը կպարունակի 1-9 թվերի բազմապատկման աղյուսակը։

            //int[,] product = new int[10, 10];
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        int product1 = i * j;
            //        Console.Write($"{product1}   ");
            //    }
            //    Console.WriteLine();
            //}



            //4. Ստեղծել երկչափ քառակուսաձև զանգված, որի անկյունագծի էլեմենտները հավասար կլինեն 1-ի, իսկ մնացածները՝ 0-ի։
            //int n = int.Parse(Console.ReadLine());
            //int[,] array = new int[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int y = 0; y < n; y++)
            //    {
            //        if (i == y || i + y == n - 1)
            //        {
            //            array[i, y] = 1;
            //        }
            //        Console.Write (array[i, y]);
            //    }
            //    Console.WriteLine();
            //}



            //5. Ստեղծել երկչափ քառակուսաձև զանգված, որի զույգ համարով տողերի էլեմենտները հավասար կլինեն 1-ի, իսկ կենտերը՝ 0-ի։
            //int[,] array = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int y = 0; y < 5; y++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            array[i, y] = 1;
            //        }
            //        Console.Write(array[i, y]);
            //    }
            //    Console.WriteLine();
            //}



            //6. Ստեղծել երկչափ քառակուսաձև զանգված, որի էլեմենտները հավասար կլինեն 1-ի, եթե էլեմենտի ինդեքսների գումարը զույգ է, իսկ մնացածները՝ 0-ի։
            //int[,] array = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int y = 0; y < 5; y++)
            //    {
            //        if (( + y) % 2 == 0)
            //        {
            //            array[i, y] = 1;
            //        }
            //        Console.Write(array[i, y]);
            //    }
            //    Console.WriteLine();
            //}



            //7. Տրված են m ամբողջ թիվը և m x m չափի զանգված, որի տարրերը բնական թվեր են, հաշվել` 
            //գլխավոր անկյունագծից ներքև գտնվող թվերի քանակը, որոնք բաժանվում են տրված k թվին

            //int[,] array = new int[4, 4]
            //{
            //    { 1, 2, 3, 4},
            //    { 8, 7, 6, 5},
            //    { 5, 9, 6, 7},
            //    { 18, 3, 5, 8}
            //};
            //Console.WriteLine("Please enter the requested number: ");
            //int k = int.Parse(Console.ReadLine());
            //int c = 0;
            //for (int i = 1; i < 4; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (array[i, j] % k == 0)

            //        {
            //            c += 1;
            //        }

            //    }

            //}
            //Console.WriteLine($"The number of elements is {c}");




            //8. գլխավոր անկյունագծից ներքև գտնվող տարրերի միջին  թվաբանականը, որոնք բազմապատիկ են 5 - ի և դրանց քանակը

            //    int[,] array = new int[4, 4]
            //{
            //            { 1, 2, 3, 4},
            //            { 8, 7, 6, 5},
            //            { 5, 9, 6, 7},
            //            { 10, 3, 5, 8}
            //};
            //    int k = 0;
            //    int c = 0;
            //    for (int i = 1; i < 4; i++)
            //    {
            //        for (int j = 0; j < i; j++)
            //        {

            //            if (array[i, j] % 5 == 0)

            //            {
            //                k += 1;
            //                c += array[i, j];
            //            }

            //        }
            //    }
            //    Console.WriteLine(k);
            //    Console.WriteLine(c/k);



            //9. գլխավոր անկյունագծից ներքև կամ դրա վրա գտնվող այն զույգ արժեք ունեցող տարրերի միջին թվաբանականը

            //    int[,] array = new int[4, 4]
            //{
            //                { 1, 2, 3, 4},
            //                { 8, 7, 6, 5},
            //                { 5, 9, 6, 7},
            //                { 10, 3, 5, 8}
            //};
            //    int k = 0;
            //    double c = 0;
            //    for (int i = 1; i < 4; i++)
            //    {
            //        for (int j = 0; j < i; j++)
            //        {

            //            if (array[i, j] % 2 == 0)

            //            {
            //                k += 1;
            //                c += array[i, j];
            //            }

            //        }
            //    }
            //    Console.WriteLine($"The quantity of the even numbers is: {k}");
            //    Console.WriteLine($"The average is {c / k}");


            //10. գլխավոր անկյունագծից ներքև գտնվող զույգ տարրերի քանակը

            //     int[,] array = new int[4, 4]
            //{
            //         { 1, 2, 3, 4},
            //         { 8, 7, 6, 5},
            //         { 5, 9, 6, 7},
            //         { 10, 3, 5, 8}
            //};
            //     int k = 0;

            //     for (int i = 1; i < 4; i++)
            //     {
            //         for (int j = 0; j < i; j++)
            //         {

            //             if (array[i, j] % 2 == 0)

            //             {
            //                 k += 1;

            //             }

            //         }
            //     }
            //     Console.WriteLine($"The quantity of even numbers below the primary diagonal is: {k}");



            //11. օժանդակ անկյունագծի վրա, կամ դրանից վերև գտնվող զրո արժեք ունեցող տարրերի քանակը
            //int[,] array = new int[4, 4]
            //        {
            //         { 0, 2, 0, 4},
            //         { 8, 7, 6, 5},
            //         { 5, 9, 1, 0},
            //         { 0, 3, 5, 8}
            //        };
            //int quantity = 0;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {

            //        if (((i + j) <= 4 - 1) && array[i, j] == 0)
            //        {
            //            quantity += 1;
            //        }

            //    }

            //}
            //Console.WriteLine($"The quantity of the indexes having 0 value is: {quantity}");
            ///////////////kam senc
            //Console.WriteLine("Please insert n");
            //int n = int.Parse(Console.ReadLine());
            //int[,] array = new int[n, n];

            //Random myRd = new Random();
            //int quantity = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        array[i, j] = myRd.Next(0, 2);
            //        Console.Write($"{array[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {

            //        if (((i + j) <= n - 1) && array[i, j] == 0)
            //        {

            //            quantity += 1;

            //        }

            //    }

            //}
            //Console.WriteLine($"Sum {quantity}");



            //12. օժանդակ անկյունագծից ներքև կամ դրա վրա գտնվող տարրերի քանակը, որոնց ինդեքսների գումարը կենտ է:
            //int[,] array = new int[4, 4]
            //        {
            //         { 0, 2, 0, 4},
            //         { 8, 7, 6, 5},
            //         { 5, 9, 1, 0},
            //         { 0, 3, 5, 8}
            //        };
            //int quantity = 0;

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {

            //        if (((i + j) >= 4 - 1) && (i + j) % 2 == 1)
            //        {
            //            quantity += 1;
            //        }

            //    }

            //}
            //Console.WriteLine($"The quantity of the odd indexes is: {quantity}");


            //Console.WriteLine();



            //??????13. օժանդակ անկյունագծից վերև, կամ նրա դրա գտնվող այն տարրերի միջին քառակուսայինը, որոնց ինդեքսների գումարը կենտ է????

            //int[,] array = new int[4, 4]
            //        {
            //         { 0, 2, 0, 4},
            //         { 8, 7, 6, 5},
            //         { 5, 9, 1, 0},
            //         { 0, 3, 5, 8}
            //        };
            //int average = 0;
            //int quantity = 0;
            //int product = 1;
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {

            //        if (((i + j) <= 4 - 1) && (i + j) % 2 == 1)
            //        {
            //            quantity += 1;
            //            product *= array[i, j];
            //            average += product;
            //        }

            //    }

            //}
            //Console.WriteLine($"The quantity of odd indexes is: {quantity}");
            //Console.WriteLine((int)Math.Sqrt(average/quantity));




            //14.??????? Տրված են m ամբողջ թիվը և m x m չափի զանգված(մատրից) , որի տարրերը բնական թվեր են, հաշվել զանվածի անկյունակծից ներքև, կամ նրա վրա գտնվող կենտ թվերի միջին թվաբանականը

            //int[,] array = new int[4, 4]
            //               {
            //                { 1, 2, 3, 4},
            //                { 8, 7, 6, 5},
            //                { 5, 9, 6, 7},
            //                { 10, 3, 5, 8}
            //               };
            //int k = 0;
            //double c = 0;
            //for (int i = 1; i < 4; i++)
            //{
            //    //for (int j = 0; j < i; j++)
            //    //{
            //    //    k += 1;
            //    //    c += array[i, j];
            //    //}
            //    for (int j = 0; j < 4; j++)
            //    {

            //        if (((i + j) >= 4 - 1) && i - j <= 0 && (i + j) % 2 == 1)
            //        {
            //            k += 1;
            //            c += array[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"The quantity of the odd numbers is: {k}");
            //Console.WriteLine($"The average is {c / k}");













        }



    }


}
