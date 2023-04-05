using System;
using System.Collections.Generic;
using System.Linq;

namespace Rechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            //int count = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "PRINT")
                {
                    break;
                }
                string city = input[1];
                string name = input[0];

                if (!dict.ContainsKey(city))
                {
                    dict.Add(city, 1);
                }
                else
                {
                    dict[city]++;
                }
            }

            Console.WriteLine($"Towns count: {dict.Count()}");

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
