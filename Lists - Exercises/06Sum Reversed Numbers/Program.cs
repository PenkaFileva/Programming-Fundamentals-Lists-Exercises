using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < list.Length; i++)
            {
                var currentNum = list[i];
                var reversedElement = currentNum.ToString();
                var reversedNumArr = reversedElement.Reverse().ToArray();
                var reversedNum = new string(reversedNumArr);
                list[i] = int.Parse(reversedNum);
            }
            Console.WriteLine(list.Sum());
        }
    }
}
