using System;
using System.Linq;

namespace SumMatrixEl
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimention = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimention[0];
            int columns = dimention[1];
            int[,] arr = new int[rows, columns];

            //vuvejdane
            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = input[j];
                }
            }
            //izvejdane
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr[i, j]} \t");
            //    }
            //    Console.WriteLine();
            //}

            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sum);
        }
    }
}
