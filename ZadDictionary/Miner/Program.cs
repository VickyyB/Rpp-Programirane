using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "stop")
                {
                    break;
                }
                int n = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(line))
                {
                    dict.Add(line, n);
                }
                else
                {
                    dict[line]+=n;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
