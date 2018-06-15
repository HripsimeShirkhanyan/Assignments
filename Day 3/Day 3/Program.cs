using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Տրված են/ներմուծված են  իրարից տարբեր a,b,c թվերը, կազմել ծրագիր, որը՝
            //Կարտածի դրանցից մեծը, փոքրը, 
            //Կարտածի true, եթե տվյալ թվերը թվաբանական պրոգրեսիա են կազմում, հակառակ դեպքում՝ false
            //Կարտածի true, եթե տվյալ թվերը երկրաչափական պրոգրեսիա են կազմում, հակառակ դեպքում՝ false
            //Կարտածի տվյալ թվերը ըստ աճման կարգի
            //Կարտածի տվյալ թվերը ըստ նվազման կարգի
            //double a1 = double.Parse(Console.ReadLine());
            //double a2 = double.Parse(Console.ReadLine());
            //double a3 = double.Parse(Console.ReadLine());
            //double max = a1;
            //double min = a1;
            //if (a2 > max && a2 > a3)
            //{
            //    Console.WriteLine($"The biggest value is {a2}");
            //}
            //else if (a3 > max && a3 > a2)
            //{
            //    Console.WriteLine($"The biggest value is {a3}");
            //}
            //else
            //{
            //    Console.WriteLine($"The biggest value is {a1}");
            //}
            //if (a2 < min && a2 < a3)
            //{
            //    Console.WriteLine($"The smallest value is {a2}");
            //}
            //else if (a3 < min && a3 < a2)
            //{
            //    Console.WriteLine($"The smallest value is {a3}");
            //}
            //else
            //    Console.WriteLine($"The smallest value is {a1}");
            //if ((a1 + a3) / 2 == a2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if (a1 * a3 == a2 * a2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //if (a1 > a2 && a2 > a3)
            //{
            //    Console.WriteLine($"Ascending: {a1}, {a2}, {a3}");
            //    Console.WriteLine($"Descending: {a3}, {a2}, {a1}");
            //}
            //else if (a1 > a3 && a3 > a2)
            //{
            //    Console.WriteLine($"Ascending: {a2}, {a3}, {a1}");
            //    Console.WriteLine($"Descending: {a1}, {a3}, {a2}");
            //}
            //else if (a2 > a1 && a1 > a3)
            //{
            //    Console.WriteLine($"Ascending: {a3}, {a1}, {a2}");
            //    Console.WriteLine($"Descending: {a2}, {a1}, {a3}");
            //}
            //else if (a2 > a3 && a3 > a1)
            //{
            //    Console.WriteLine($"Ascending: {a1}, {a3}, {a2}");
            //    Console.WriteLine($"Descending: {a2}, {a3}, {a1}");
            //}
            //else if (a3 > a1 && a1 > a2)
            //{
            //    Console.WriteLine($"Ascending: {a2}, {a1}, {a3}");
            //    Console.WriteLine($"Descending: {a3}, {a1}, {a2}");
            //}
            //else
            //{
            //    Console.WriteLine($"Ascending: {a1}, {a2}, {a3}");
            //    Console.WriteLine($"Descending: {a3}, {a2}, {a1}");
            //}




            //Տրված են/ներմուծված են  իրարից տարբեր a,b,c, d թվերը, կազմել ծրագիր, որը՝
            //Կարտածի դրանցից մեծը / փոքրը,
            //Եթե դրանցից գոնե մեկը հավասար է 1 - ի, տպել true, հակառակ դեպքում՝ false
            //Եթե դրանցից գոնե երկուսը հավասար են 2 - ի, տպել true, հակառակ դեպքում՝ false
            //Եթե տրված թվերից երկուսի գումարը հավասար է մյուս երկուսի գումարի, կարտածի true, հակառակ դեպքում՝ false
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double c = double.Parse(Console.ReadLine());
            //double d = double.Parse(Console.ReadLine());
            //double max = a;
            //double min = a;
            //if (b > max && b > c && b > d)
            //{
            //    Console.WriteLine($"The biggest value is {b}");
            //}
            //else if (c > max && c > b && c > d)
            //{
            //    Console.WriteLine($"The biggest value is {c}");
            //}
            //else if (d > max && d > b && d > c)
            //{
            //    Console.WriteLine($"The biggest value is {d}");
            //}
            //else
            //{
            //    Console.WriteLine($"The biggest value is {a}");
            //}
            //if (b < min && b < c && b < d)

            //{
            //    Console.WriteLine($"The smallest value is {b}");
            //}
            //else if (c < min && c < b && c < d)
            //{
            //    Console.WriteLine($"The smallest value is {c}");
            //}
            //else if (d < min && d < b && d < c)
            //{
            //    Console.WriteLine($"The smallest value is {d}");
            //}
            //else
            //{
            //    Console.WriteLine($"The smallest value is {a}");
            //}
            //if (a == 1 || b == 1 || c == 1 || d == 1)
            //{
            //    Console.WriteLine("One of the values is 1: True");
            //}
            //else
            //    Console.WriteLine("One of the values is 1: False");



            //Լուծել a *x + b = 0 գծային հավասարումը կամայական a և b թվերի համար։
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double x = -b / a;
            //Console.WriteLine(x);




            //Լուծել a *x * x + b * x + c = 0 քառակուսային հավասարումը կամայական a, b և c թվերի համար։
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double c = double.Parse(Console.ReadLine());
            //double D = b * b - 4 * a * c;
            //if (a > 0 && D > 0)
            //{
            //    double x1 = (-b + Math.Sqrt(D)) / 2 * a;
            //    double x2 = (-b - Math.Sqrt(D)) / 2 * a;
            //    Console.WriteLine($"The solutions are: {x1} and {x2}");
            //}
            //else if (a > 0 && D == 0)

            //{
            //    double x = (-b + -Math.Sqrt(D)) / 2 * a;
            //    Console.WriteLine($"The solution is: {x}");
            //}
            //else
            //{
            //    Console.WriteLine("No solution");
            //}



            //գտնել երկու թվերից մեծագույնը։
            //գտնել երկու թվերից փոքրագույնը։
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"The biggest value is: {Math.Max(a, b)}");
            //Console.WriteLine($"The smallest value is: {Math.Min(a, b)}");



            //Գտնել երեք թվերից մեծագույնը։
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a > b && a > c)
            //{
            //    Console.WriteLine($"The biggest number is: {a}");
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine($"The biggest number is: {b}");
            //}
            //else
            //    Console.WriteLine($"The biggest number is: {c}");



            //Գտնել երեք թվերից փոքրագույնը։
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a < b && a < c)
            //{
            //    Console.WriteLine($"The smallest number is: {a}");
            //}
            //else if (b < a && b < c)
            //{
            //    Console.WriteLine($"The smallest number is: {b}");
            //}
            //else
            //    Console.WriteLine($"The smallest number is: {c}");



            //Պարզել ներմուծված թիվը զու՞յգ է, թե՞ կենտ։
            //int a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");



            //Պարզել ներմուծված թիվը արդյոք բաժանվու՞մ է առանց մնացորդի 5-ի վրա։
            //int a = int.Parse(Console.ReadLine());
            //if (a % 5 == 0)
            //{
            //    Console.WriteLine("Divided by 5 without residual.");
            //}
            //else
            //{
            //    Console.WriteLine("Divided by 5 with residual.");
            //}




            //Ներմուծված թիվը բազմապատկել 2-ով, եթե այն զու՞յգ է և առանց մնացորդի բաժանվու՞մ է 3-ի վրա։
            //int a = int.Parse(Console.ReadLine());
            //if (a % 2 == 0 && a % 3 == 0)
            //{
            //    Console.WriteLine(a * 2);
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}


            //Ներմուծված թիվը բազմապատկել 2 - ով, եթե այն կենտ է կամ առանց մնացորդի բաժանվում է 3 - ի վրա։
            //int a = int.Parse(Console.ReadLine());
            //if (a % 2 != 0 || a % 3 == 0)
            //{
            //    Console.WriteLine(a * 2);
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}



            //Գրեք տարեթիվը ու պարզեք՝ էդ տարին նահանջ տարի ա, թե չէ
            //int date = int.Parse(Console.ReadLine());
            //if (date % 400 == 0 || date % 4 == 0 && date % 100 != 0)
            //{
            //    Console.WriteLine($"{date} is a leap year");
            //}
            //else
            //{
            //    Console.WriteLine($"{date} is a common year");
            //}



            //Տրված է եռանիշ թիվ, արտածել true եթե եռանիշ թվի միավորների թվանշանը հավասար է տասնավորների և հարյուրավորների թվանշանների գումարին, հակառակ դեպքում՝ false։
            //int a = int.Parse(Console.ReadLine());
            //if (a / 100 + a % 100 / 10 == a % 10)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}


            //Տրված է եռանիշ թիվ, արտածել true եթե եռանիշ թվի թվանշաների մեջ կան իրար հավասար թվանշաններ, հակառակ դեպքոււմ՝ false:
            //int a = int.Parse(Console.ReadLine());
            //int hundreds = a / 100;
            //int tens = a % 100 / 10;
            //int unit = a % 10;
            //if (hundreds == tens || hundreds == unit || tens == unit)
            //{
            //    Console.WriteLine("True: there are equal digits in the given number.");
            //}
            //else
            //{
            //    Console.WriteLine("False: there aren't equal digits in the given number.");
            //}



            //Տրված է եռանիշ թիվ, հաշվել և արտածել եռանիշ թվի և իր թվանշանների գումարի հարաբերությանն արժեքը։
            //int a = int.Parse(Console.ReadLine());
            //int hundreds = a / 100;
            //int tens = a % 100 / 10;
            //int unit = a % 10;
            //int division = a / (hundreds + tens + unit);
            //Console.WriteLine($"The division of the initial number and the sum of its digits is {division}");



            //Տրված է եռանիշ թիվ, հաշվել և արտածել եռանիշ թվի թվանշաններից մեծագույնի/ փոքրագույնի արժեքը։
            //int a = int.Parse(Console.ReadLine());
            //int hundreds = a / 100;
            //int tens = a % 100 / 10;
            //int unit = a % 10;
            //if (hundreds > tens && hundreds > unit)
            //{
            //    Console.WriteLine($"The biggest digit is {hundreds}");
            //}
            //else if (tens > hundreds && tens > unit)
            //{
            //    Console.WriteLine($"The biggest digit is {tens}");
            //}
            //else
            //{
            //    Console.WriteLine($"The biggest digit is {unit}");
            //}
            //if (hundreds < tens && hundreds < unit)
            //{
            //    Console.WriteLine($"The smallest digit is {hundreds}");
            //}
            //else if (tens < hundreds && tens < unit)
            //{
            //    Console.WriteLine($"The smallest digit is {tens}");
            //}
            //else
            //{
            //    Console.WriteLine($"The smallest digit is {unit}");
            //}



            //Ներմուծեք շաբաթվա օրերին համապատասխան թիվը, արտածեք համապատասխան օրը՝ 2 > երեքշաբթի

            //    int number = int.Parse(Console.ReadLine());
            //    switch (number)
            //        {
            //        case 1:
            //         Console.WriteLine("Monday");
            //        break;
            //        case 2:
            //         Console.WriteLine("Tuesday");
            //        break;
            //        case 3:
            //         Console.WriteLine("Wednesday");
            //        break;
            //        case 4:
            //         Console.WriteLine("Thirsday");
            //        break;
            //        case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //        case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //        case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //        default:
            //         Console.WriteLine("Please input a valid number. There are only 7 days in a week.");
            //        break;
            //    }



            //Ներմուծեք ամսաթիվը, արտածեք թե ամսվա որ շաբաթվա օրն է դա՝ 15 > 3
            //int date = int.Parse(Console.ReadLine());
            //if (date >= 1 && date <= 7)
            //{
            //    Console.WriteLine("1");
            //}
            //else if (date >= 8 && date <= 14)
            //{
            //    Console.WriteLine("2");
            //}
            //else if (date >= 15 && date <= 21)
            //{
            //    Console.WriteLine("3");
            //}
            //else
            //{
            //    Console.WriteLine("4");
            //}



            //Ներմուծեք ամսվան համապատասխան թիվը(3 > մարտ), արտածեք ամսվա անունը և քանի օր կա այդ ամսում՝  9 > սեպտեմբեր 30
            //int date = int.Parse(Console.ReadLine());
            //switch (date)
            //{
            //    case 1:
            //        Console.WriteLine("January, 31 days");
            //        break;
            //    case 2:
            //        Console.WriteLine("February, 28 or 29 days, depends on the year : leap or common.");
            //        break;
            //    case 3:
            //        Console.WriteLine("March, 31 days");
            //        break;
            //    case 4:
            //        Console.WriteLine("April, 30 days");
            //        break;
            //    case 5:
            //        Console.WriteLine("May, 31 days");
            //        break;
            //    case 6:
            //        Console.WriteLine("June, 30 days");
            //        break;
            //    case 7:
            //        Console.WriteLine("July, 31 days");
            //        break;
            //    case 8:
            //        Console.WriteLine("August, 31 days");
            //        break;
            //    case 9:
            //        Console.WriteLine("September, 30 days");
            //        break;
            //    case 10:
            //        Console.WriteLine("October, 31 days");
            //        break;
            //    case 11:
            //        Console.WriteLine("November, 30 days");
            //        break;
            //    case 12:
            //        Console.WriteLine("December, 31 days");
            //        break;
            //    default:
            //        Console.WriteLine("Please input a valid number. There are only 12 months in a year.");
            //        break;
            //}




            //Ներմուծեք թիվ ու ասեք՝ արդյոք այ թիվը միանիշ է, երկնիշ, եռանիշ, քառանիշ կամ այլ
            //int a = int.Parse(Console.ReadLine());
            //if (a / 10 == 0)
            //{
            //    Console.WriteLine("unit");
            //}
            //else if (a / 100 == 0)
            //{
            //    Console.WriteLine("tens");
            //}
            //else if (a / 1000 == 0)
            //{
            //    Console.WriteLine("hundreds");
            //}
            //else if (a / 10000 == 0)
            //{
            //    Console.WriteLine("ten hundreds");
            //}
            //else
            //{
            //    Console.WriteLine("other");
            //}




            //Ներմուծեք տաքսու անցած ճանապարհը, արտածեք քանի դրամ արժի երթը
            //double road = double.Parse(Console.ReadLine());
            //if (road >= 1 && road <= 5)
            //{
            //    Console.WriteLine(600);
            //}
            //else
            //{
            //    Console.WriteLine(600 + 100 * (road - 5));
            //}
        }
    }

}
