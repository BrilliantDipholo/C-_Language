using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PalindromeChecker{
    public static void Main(string[] args){
        Console.Write("Enter your string: ");
        string str=Console.ReadLine().ToLower();
        int size=str.Length;
        char[] fwrd=new char[size];
        char[] bkwrd=new char[size];
        str=str.Remove(str.IndexOf(' '),str.IndexOf(' '));
        bool palindrome=true;
        for(int k=0;k<size;k++){
            if(fwrd[k]!=bkwrd[k]){
                palindrome=false;
                break;
            }
        }
        if(palindrome){
            Console.WriteLine("You have entered a plaindrome !");
        }
        else{
            Console.WriteLine("That's not a plaindrome..");
        }
    }
}