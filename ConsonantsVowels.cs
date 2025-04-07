using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;	
//.netfiddle
public class Program
{
	
	public class MyProgram{
		public static char Vowel(char v){
			char[] vowels={'a','e','i','o','u'};
            if(Array.IndexOf(vowels,v)<4){
                return vowels[Array.IndexOf(vowels,v)+1];
            }
			return vowels[0];
		}
		public static char Consonant(char c){
			char[] consonants={'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'};
            if(Array.IndexOf(consonants,c)<20){
                return consonants[Array.IndexOf(consonants,c)+1];
            }
			return consonants[0];
		}
		
		public static string encode(string str){
			char[] vowels={'a','e','i','o','u'};
			char[] consonants={'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z'};
			for(int i=0;i<str.Length;i++){
                for(int k=0;k<21;k++){
					if(str[i]==consonants[k]){
						char newLetter;
						newLetter=Consonant(str[i]);
						str=str.Replace(str[i],newLetter);
					}
				}
				for(int j=0;j<5;j++){
					if(str[i]==vowels[j]){
						char newLetter;
						newLetter=Vowel(str[i]);
						str=str.Replace(str[i],newLetter);
					}
				}
				
			}
			return str;
			
		}
	}
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter the text to encode(no uppercase letters).");
		string str=Console.ReadLine();
		int size=str.Length;
		str=MyProgram.encode(str);
		Console.WriteLine(str);
		
	}
}