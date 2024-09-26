using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int a = 0;
        List<float> nums = new List<float>(); 
        while(a==0)
        {
            Console.Write("Enter number : ");
            float num = float.Parse(Console.ReadLine());
            if(num!=0){
                nums.Add(num);
            }
            else{
                float total = nums.Sum();
                int count = nums.Count;
                float average = total/count;
                float large = 0;
                foreach (float n in nums){
                    if(n>large){
                        large = n;
                    }
                }
                Console.WriteLine($"The Sum is {total}");
                Console.WriteLine($"The average is {average}");
                Console.WriteLine($"The largest number is {large}");
                a=1;
            }
            

        }
    }
}