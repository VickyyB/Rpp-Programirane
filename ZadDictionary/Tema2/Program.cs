using System;
using System.Collections.Generic;
using System.Linq;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] curent = Console.ReadLine().Split(' ').ToArray();
                if (curent[0] == "stop")
                {
                    Console.WriteLine("[{0}]", string.Join(", ", input));
                    break;
                }
     
                if (curent[0] == "ins")
                {
                    int index = int.Parse(curent[1]);
                    int element = int.Parse(curent[2]);
                    input.Insert(index, element);
                }
                if (curent[0] == "contains")
                { 
                    int serachedNumber = int.Parse(curent[1]);
                  
                    Console.WriteLine(input.IndexOf(serachedNumber));
                }
                if (curent[0] == "remove")
                {
                    int index = int.Parse(curent[1]);
                    input.RemoveAt(index);
                }
                if (curent[0] == "add")
                {
                    int element = int.Parse(curent[1]);
                    if (!input.Contains(element))
                    {
                        input.Add(element);
                    }
                }
                if (curent[0] == "removeAll")
                {
                    int element = int.Parse(curent[1]);
                    input.RemoveAll(x=>x==element);
                }
                if (curent[0] == "printGreater")
                { 
                    int element = int.Parse(curent[1]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] > element)
                        {
                            Console.Write(input[i] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
