using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Kabelo Dipholo
 2027198551
 Practical 4
 13 March 2025
 */
namespace BankLoanChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Are you employed?(yes/no):");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "yes")//checks if the user said yes,regardless of whether there was a capital letter or not
            {
                Console.Write("Enter your monthly income: ");
                double monthlyIncome = Convert.ToDouble(Console.ReadLine());
                if (monthlyIncome >= 2000)
                {
                    Console.Write("Enter your credit score: ");
                    double creditScore = Convert.ToDouble(Console.ReadLine());
                    if (creditScore >= 700)
                    {
                        Console.WriteLine("Congratulations! You qualify for the best interest rate loan.");
                    }
                    else if (creditScore >= 600)//Logically the credit score should be less than 700,so here we are just gonna say greater than 600 To check if the credit score is between 600 and 699
                    {
                        Console.WriteLine("Congratulations! You qualify for the standard loan.");
                    }
                    else if (creditScore < 600 && creditScore >= 0)
                    {
                        Console.WriteLine("Sorry,your credit score is too low to qualify for a loan.");
                    }
                    else
                    {
                        Console.WriteLine("Error:Invalid credit score...");//If none of the cases above worked ,then it means that the user entered either a negative number or some characters which are invalid
                    }
                }
                else
                {
                    Console.WriteLine("Sorry,your income is too low to qualify for a loan.");
                }
            }
            else if (answer.ToLower() == "no")//checks if the user said no,regardless of whether there was a capital letter or not
            {
                Console.WriteLine("Sorry,you must have a job to apply for a loan.");
            }
            else
            {
                Console.WriteLine("Invalid choice..please enter yes or no next time.");
            }
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
