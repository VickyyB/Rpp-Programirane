using System;
using System.Linq;

namespace SumMatrixCo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = dimension[0];
            int colums = dimension[1];
            int[,] arr = new int[rows, colums];

            //wuwejdane
            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < colums; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            //sumirane
            for (int j = 0; j < colums; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += arr[i, j];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
