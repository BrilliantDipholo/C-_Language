using System;
using System.Collections.Generic;
public class BudgetTracker{
    public static void Main(string[] args){
        List<double> incomes=new List<double>();
        List<double> expenseAmounts=new List<double>();
        List<string> expenseNames=new List<string>();
        double income=0;
        int choice=0;
        double totalIncome=0;
        double totalExpense=0;
        while(choice!=4){
            Console.WriteLine("#################\nPersonal Budget Tracker\n1.Add Income\n2.Add Expense\n3.View Balance\n4.Exit\n");
            Console.Write("Enter your Choice: ");
            choice=Convert.ToInt32(Console.ReadLine());
            if(choice==1){
                Console.Write("Enter income amount: R");
                income=Convert.ToDouble(Console.ReadLine());
                incomes.Add(income);
            }
            else if(choice==2){
                Console.Write("Enter the name of the expense: ");
                string expenseName=Convert.ToString(Console.ReadLine());
                Console.Write("Enter the amount of the expense: ");
                double expenseAmount=Convert.ToDouble(Console.ReadLine());
                expenseAmounts.Add(expenseAmount);
                expenseNames.Add(expenseName);
            }
            else if(choice==3){
                totalIncome=0;
                totalExpense=0;
                for(int i=0;i<incomes.Count;i++){
                    totalIncome+=incomes[i];
                }
                for(int i=0;i<expenseAmounts.Count;i++){
                    totalExpense+=expenseAmounts[i];
                }
                Console.WriteLine($"Your Balance is: {totalIncome-totalExpense}");
            }
        }
    }
}