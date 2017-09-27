using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var line = Console.ReadLine();
            while (line != "print")
            {
                var tokens = line.Split();
                var command = tokens[0];
                if (command == "add")
                {
                    var index = int.Parse(tokens[1]);
                    var element = int.Parse(tokens[2]);
                    list.Insert(index, element);
                }
                else if (command == "addMany")
                {
                    var index = int.Parse(tokens[1]);
                    var element = new List<int>();
                    for (int i = 2; i < tokens.Length; i++)
                    {
                        var currentItem = int.Parse(tokens[i]);
                        element.Add(currentItem);
                    }
                    list.InsertRange(index, element);
                }
                else if (command == "contains")
                {
                    var element = int.Parse(tokens[1]);
                    var index = -1;
                    if (list.Contains(element))
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == element)
                            {
                                index = i;
                                break;
                            }
                        }
                    }
                    Console.WriteLine(index);
                }
                else if (command == "remove")
                {
                    var index = int.Parse(tokens[1]);
                    list.RemoveAt(index);

                }
                else if (command == "shift")
                {
                    var count = int.Parse(tokens[1]) % list.Count;
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (command == "sumPairs")
                {
                    var pairsSum = new List<int>();
                    for (int i = 0; i < list.Count; i+=2)
                    {
                        var currentElement = list[i];
                        var nextElement = 0;
                        if (i < list.Count -1)
                        {
                            nextElement = list[i + 1];
                        }
                        var elementSum = currentElement + nextElement;
                        pairsSum.Add(elementSum);
                    }
                    list = pairsSum;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"[{String.Join(", ", list)}]");
        }
    }
}
