using System;

namespace StatisticArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(OptionsManager.CountLess100(arr));
            Console.WriteLine(OptionsManager.MaxNum(arr));
            OptionsManager.ChetniChisla(arr);
            arr = OptionsManager.ReverseArr(arr);
            OptionsManager.PrintArr(arr);
        }
    }
}
