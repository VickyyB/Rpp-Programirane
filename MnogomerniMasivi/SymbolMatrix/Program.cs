using System;

namespace SymbolMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());

            int rows = dimension;
            int colums = dimension;
            int[,] arr = new int[rows, colums];

            //wuwejdane
            for (int i = 0; i < dimension; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            char namirane = char.Parse(Console.ReadLine());
            bool nameren = false;

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if (arr[i, j] == namirane)
                    {
                        Console.WriteLine($"({i}, {j})");
                        nameren = true;
                        break;
                    }
                }
            }
            if (!nameren)
            {
                Console.WriteLine($"{namirane} does not occur in the matrix");
            }
        }
    }
}
        
    

