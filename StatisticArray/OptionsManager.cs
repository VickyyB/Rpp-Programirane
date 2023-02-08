using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticArray
{
    public static class OptionsManager
    {
        public static int CountLess100(int[] arr)
        {
            return arr.Count(x => x < 100);
        }

        public static int MaxNum(int[] arr)
        {
            return arr.Max();
        }

        public static void ChetniChisla(int[] arr)
        {
            var result = arr.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }

        public static int SumChetniChisla(int[] arr)
        {
            return arr.Where(x => x % 2 == 0).Sum();
        }

        public static int[] ReverseArr(int[] arr)
        {
            return arr.Reverse().ToArray();
        }

        public static void PrintArr(int[] arr)
        {
            Console.WriteLine(string.Join(", ",arr));
        }
    }
}
