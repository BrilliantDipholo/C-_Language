using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Kabelo Dipholo
2027198551
Practical 2
27 February 2025
*/

namespace RentalIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================\n-Rental Average Calculator-\n===========================");
            Console.Write("Please enter the first rental income: R");
            double income1=Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the second rental income: R");
            double income2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the third rental income: R");
            double income3 = Convert.ToDouble(Console.ReadLine());
            double averageIncome = (income1 + income2 + income3) / 3;
            Console.WriteLine($"===========================\nAverage Rental Income = R{Math.Round(averageIncome,2)}\n===========================\nPress any key to close...");//Here i used \n so that am able to write multiple lines with a single line of code 
            Console.ReadKey();//This will keep the console open 
        }
    }
}
