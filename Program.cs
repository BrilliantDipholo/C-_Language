using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Kabelo Dipholo
2027198551
20 March 2025
Section C(Mock Test)
 */
namespace project_MockTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Select an operation:\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\nEnter your choice: ");//This will display the menu to the user so that they can choose from it
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1 || choice == 2 || choice == 3 || choice == 4)//This will check if the user chose the a valid option from the menu 
                {
                    //Only when the user chooses the right option from the menu given, will the code below run
                    Console.WriteLine("Enter 2 numbers to do the calculation");

                    //We will use Double instead of Int because the user can enter a decimal point number that's still greater than zero
                    try
                    {
                        Console.Write("First number: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());//Converting number entered from string to double

                        Console.Write("Second number: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        if (num1 > 0 && num2 > 0)//This will check if Both numbers are greater than zero
                        {
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");//This will display the result
                                    break;
                                case 2:
                                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                                    break;
                                case 3:
                                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                                    break;
                                case 4:
                                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                                    break;
                                
                                 //There is no need for a default case because the choice variable is either 1 or 2 or 3 or 4
                            }
                        }
                        else
                        {
                            Console.WriteLine("Both numbers must be greater than zero");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error:You have to enter number in order to do maths operations given in the menu");//This will display if the user enters a letter or some character instead of a number
                    }
                }
                else
                {
                    Console.WriteLine("Error:Invalid choice..choose option from above");//This will display if the user doesn't choose the right option from the menu
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error:Invalid option..you have to enter a number(1/2/3/4) from the menu");//This will display if the user enteres a letter or some character instead of a number when choosing from the menu
            }
            Console.ReadKey();//Keeps the console open until the user enters a key
        }
    }
}
