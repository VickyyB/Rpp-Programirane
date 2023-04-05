using System;
using System.Linq;

namespace Masiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = dim[0];
            int cols = dim[1];

            

            int[,] arr = new int[rows, cols];
            for (int i = 0; i < rows; i++) 
            {
                int[] input = Console.ReadLine().Split("; ").Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = input[j];
                }
            }
            //izvejdane
           
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] > 20)
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                    
                }
                
            }
        }
    }
}
