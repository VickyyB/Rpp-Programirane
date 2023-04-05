using System;
using System.Collections.Generic;
using System.Linq;

namespace Uchenici
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
       
      
   
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                string line = Console.ReadLine();
             
                if (!dict.ContainsKey(line))
                {
                    dict.Add(line, 1);
                }
                else
                {
                    dict[line]++;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            Console.WriteLine($"Subjects count: {dict.Count()}");
        }
    }

}



