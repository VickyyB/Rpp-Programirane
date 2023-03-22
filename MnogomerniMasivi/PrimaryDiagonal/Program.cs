using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimention = int.Parse(Console.ReadLine());
            int[,] arr = new int[dimention,dimention];

            //vuvejdane
            for (int i = 0; i < dimention; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < dimention; j++)
                {
                    arr[i, j] = input[j];
                }
            }
            int sum = 0;

            for (int i = 0; i < dimention; i++)
            {
                sum += arr[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
