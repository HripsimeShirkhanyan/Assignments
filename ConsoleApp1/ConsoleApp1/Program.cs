using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ներմուծեք Հայկի, Վահանի ու Արսենի աշխատավարձերը, հաշվեք նրանցից ամենաշատ ստացողը որքան է շատ ստանում ամենաքիչ ստացողից

            Console.WriteLine("Please enter Hayk's salary: ");
            int salaryHayk = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Vahan's salary: ");
            int salaryVahan = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Arsen's salary: ");
            int salaryArsen = int.Parse(Console.ReadLine());
            int highest = (salaryArsen > salaryHayk ? salaryArsen : salaryHayk) > salaryVahan ? (salaryArsen > salaryHayk ? salaryArsen : salaryHayk) : salaryVahan;
            int lawest = (salaryArsen < salaryHayk ? salaryArsen : salaryHayk) < salaryVahan ? (salaryArsen < salaryHayk ? salaryArsen : salaryHayk) : salaryVahan;
            Console.WriteLine($"The difference between the highest and the lawest salaries is {highest - lawest}");



            //Կարծում եմ սրանից ավելի աննորմալ ձևով հնարավոր չէր գրել այս առաջադրանքը :)))
            //Առանձին֊առանձին ներմուծեք DUD և AparanCity  սուպերմարկետներում հացի, կաթի, սուրճի, մածունի, պանրի գները, վերջում ասեք՝ որ սուպերմարկետում է ավելի ձեռնտու առևտուր անելը
            //Console.WriteLine("Prices in DUD supermarket");
            //Console.WriteLine("Please enter the bread price");
            //decimal bread = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the milk price");
            //decimal milk = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the coffee price");
            //decimal coffee = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the curdledMilk price");
            //decimal curdledMilk = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the cheese price");
            //decimal cheese = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("Prices in Aparancity supermarket");
            //Console.WriteLine("Please enter the bread price");
            //decimal bread1 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the milk price");
            //decimal milk1 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the coffee price");
            //decimal coffee1 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the curdledMilk price");
            //decimal curdledMilk1 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the cheese price");
            //decimal cheese1 = decimal.Parse(Console.ReadLine());

            //string result = (bread1 > bread && milk1 > milk && coffee1 > coffee && curdledMilk1 > curdledMilk && cheese1 > cheese) ? "Dud supermarket" : "Aparancity supermarket";
            //Console.WriteLine($"One should buy from a supermarket, where the prices are minimum, so you should do shopping in {result}");





            //Տրված են a,b,c թվերը, գրեք ծրագիր, որը Կարտածի true, եթե տրված թվերից գոնե մեկը հավասար է 1֊ի, հակառակ դեպքում՝ false
            //Կարտածի true, եթե տրված թվերից երկուսը հավասար են երկուսի, Եթե այդպիսի երկարություն ունեցող հատվածներով հնարավոր է կազմել եռանկյունի, կարտածի true, հակառակ դեպքում՝ false

            //Console.WriteLine("First variable: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Second variable: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Third variable: ");
            //int c = int.Parse(Console.ReadLine());
            //string result;
            //result = (a == 1 || b == 1 || c == 1) ? "True" : "False";
            //Console.WriteLine($"The statement, stating that any of the variables is equal to 1, is {result}");
            //result = (a == 2 && b == 2 || a == 2 && c == 2 || b == 2 && c == 2) ? "True" : "False";
            //Console.WriteLine($"The statement, stating that  2 of the variables are equal to 2, is {result}");
            //result = (a + b > c || a + c > b || b + c > a) ? "True" : "False";
            //Console.WriteLine($"The statement, stating that one can make a triangle with the given variables, is {result}");



            //Ներմուծեք եռանիշ թիվ և տպեք դրա նիշերը՝ առանձին - առանձին

            //Console.WriteLine("Enter a three digit number: ");
            //int a = int.Parse(Console.ReadLine());
            //int first_num = a / 100;
            //int second_num = a % 100 / 10;
            //int third_num = a % 10;
            //Console.WriteLine($"First number is: {first_num}, Second number is: {second_num}, Third number is: {third_num}");


            
        }
    }
}
