using System;
using System.Linq;
using System.Collections.Generic;

namespace ZadDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            //vuvejdame ot edin red
            string[] input = Console.ReadLine().Split().ToArray();
            
            for (int i = 0; i < input.Length; i++)
            {
                //vzimame porednata duma
                string word = input[i].ToLower();
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 1);
                }
                else
                {
                    dict[word]++;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
