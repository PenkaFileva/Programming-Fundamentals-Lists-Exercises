using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var arr = Console.ReadLine();          

            while (!(arr == "Odd" || arr == "Even"))
            {
                var tokens = arr.Split();
                var command = tokens[0];
                if (command == "Delete")
                {
                    var element = int.Parse(tokens[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        var currentElement = list[i];
                        if (currentElement == element)
                        {
                            list.Remove(currentElement);
                            i = i - 1;
                        }
                    }
                }
                else if (command == "Insert")
                {
                    var element = int.Parse(tokens[1]);
                    var position = int.Parse(tokens[2]);
                    list.Insert(position, element);
                }
                arr = Console.ReadLine();

            }
            if (arr == "Odd")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var currentElement = list[i];
                    if (currentElement % 2 == 0)
                    {
                        list.Remove(currentElement);
                        i = i - 1;
                    }
                }
            }
            else if (arr == "Even")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    var currentElement = list[i];
                    if (currentElement % 2 != 0)
                    {
                        list.Remove(currentElement);
                        i = i - 1;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
