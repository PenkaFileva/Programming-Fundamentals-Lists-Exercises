using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var digits = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var takeNum = digits[0];
            var deleteNum = digits[1];
            var searchNum = digits[2];
            var removeCount = numbers.Count - takeNum;

            numbers.RemoveRange(takeNum, removeCount);
            //Console.WriteLine(String.Join(" ", numbers));
            numbers.RemoveRange(0, deleteNum);
            //Console.WriteLine(String.Join(" ", numbers));
            bool result = false;
            foreach (var item in numbers)
            {               
                if (item == searchNum)
                {
                    result = true;
                }
            }
            if (result)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
                    
            
            
            //Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
