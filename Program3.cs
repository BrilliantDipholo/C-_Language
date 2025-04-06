using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Kabelo Dipholo
2027198551
Practical 3
06 March 2025
 */
namespace MillimetreConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Milimeter Converter!\nEnter the total milimeters: ");//Using the escape character for a new line
            int mm = int.Parse(Console.ReadLine());//This will assign variable km to the number of milimeters entered by the user
            int km = mm / 1000000;//This will assign variable km to the number of kilometers
            int m = (mm%1000000)/1000;//This will assign variable km to the number of meters
            int cm = (mm%100)/10;//This will assign variable km to the number of centimeters
            int newmm = mm%10;//This will assign variable km to the number of milimeters

            Console.WriteLine($"{mm} mm is equal to :");
            Console.WriteLine($"{km} km,{m} m,{cm} cm,{newmm} mm");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();//This will keep the console open until the user presses any key
        }
    }
}
