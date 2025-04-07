using System;
using System.Collections.Generic;
public class TwoSum{
    public static void Main(string[] args){
        List<int> nums=new List<int>();
        int num=-1;
        int i=0;
        while(num!=-2){
            Console.WriteLine("#################\nEnter -2 to exit");
            Console.Write($"Enter a number for index {i}: ");
            num=Convert.ToInt32(Console.ReadLine());
            if(num!=-2){
                nums.Add(num);
            }
            i++;
        }
        Console.Write("Enter the target: ");
        int target=Convert.ToInt32(Console.ReadLine());
        bool found=false;
        List<int> first=new List<int>();
        List<int> second=new List<int>();
        for(int k=0;k<nums.Count;k++){
            for(int j=0;j<nums.Count;j++){
                if(k!=j){
                    if(nums[k]+nums[j]==target){
                        if(first.Count<1){
                            Console.WriteLine($"{k} and {j} are the indices of the values that add up to {target}");
                            first.Add(k);
                            second.Add(j);
                        }
                        else{
                            for(int h=0;h<first.Count;h++){
                                if((k==first[h] && j==second[h]) || (j==first[h] && k==second[h])){
                                    continue;
                                }
                                else{
                                    Console.WriteLine($"{k} and {j} are the indices of the values that add up to {target}");
                                    first.Add(k);
                                    second.Add(j);
                                }
                            }
                        }
                        
                        break;
                    }
                }
            }
        }
        
    }
}