using System;
public class LargestNum{
    public static void Main(String[] args){
        Console.Write("Enter the size of the array: ");
        int size=Convert.ToInt32(Console.ReadLine());
        int[] arr=new int[size];
        int large=0;
        for(int i=0,number=0;i<size;i++){
            Console.Write($"Enter number for index {i}: ");
            number=Convert.ToInt32(Console.ReadLine());
            arr[i]=number;
            if(number>large){
                large=number;
            }
        }
        Console.WriteLine("####################");
        for(int i=0;i<size;i++){
            if(i!=size-1){
                Console.Write($"{arr[i]},");
            }
            else{
                Console.Write($"{arr[i]}\n");
            }
        }
        Console.WriteLine("################");
        Console.Write($"The largest number in the array is: {large}");
        
    }
}