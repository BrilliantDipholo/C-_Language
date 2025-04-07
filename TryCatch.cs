using System;
					
public class Program
{
	public static void Main()
	{
		try{
			Console.Write("Enter first number:");
			int num1=int.Parse(Console.ReadLine());
			Console.Write("Enter second number:");
			int num2=int.Parse(Console.ReadLine());
			double ans=num1/(double)num2;
			Console.WriteLine("Your answer is:"+ans.ToString("0.00"));
		}
		catch(DivideByZeroException){
			Console.WriteLine("\n Error:Divide by Zero error");
		}
		catch(FormatException){
			Console.WriteLine("\n Error:Invalid input");
		}
	}
}