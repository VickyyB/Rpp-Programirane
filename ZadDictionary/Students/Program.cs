using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                var name = input[0];
                if (name == "Finish")
                {
                    break;
                }
                var grade = double.Parse(input[1]);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                    dict[name].Add(grade);
                }
                else
                {
                    dict[name].Add(grade);
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{item.Key} : {string.Join("->", item.Value)} Avarage uspeh: {item.Value.Average():f2}");
            }
        }
    }
}
