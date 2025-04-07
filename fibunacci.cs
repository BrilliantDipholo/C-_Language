//fibunacci sequance
//0,1,1,2,3,5,8,13,21,34,55,89,144,..
//intel core i5 , 16gb ram
using System;
namespace fibunacciSeq{
    class Program{
        static void Main(){
            Console.WriteLine("Enter the first number: ");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2=Convert.ToDouble(Console.ReadLine());
            double[] arr=new double[10];
            arr[0]=num1;
            arr[1]=num2;
            double num3=0;
            for(int i=2;i<10;i++){
                num3=num1+num2;
                arr[i]=num3;
                num1=num2;
                num2=num3;
            }
            for(int i=0;i<10;i++){
                Console.Write($"{arr[i]},");
            }
        }
    }
}