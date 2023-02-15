using System;
using System.Linq;

namespace _2zad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            while (true)
            {
                {
                    string[] command = Console.ReadLine().Split();
                    if (command[0] == "END")
                    {
                        break;
                    }
                    switch (command[0])
                    {
                        case "Reverse":
                            Array.Reverse(arr);
                            break;
                        case "Distinct":
                            arr = arr.Distinct().ToArray();
                            break;
                        case "Replace":
                            int index = int.Parse(command[1]);
                            if (index<0 || index>=arr.Length)
                            {
                                Console.WriteLine("Invalid input");
                            }
                            else
                            {
                                string newWord = command[2];
                                arr[index] = newWord;
                            }
                            break;
                        case "Print":
                            {
                                var result = arr.Where(x => x.StartsWith(command[1])).ToArray();
                                Console.WriteLine(string.Join(" ", arr));
                                break;
                            }
                                default:
                                    Console.WriteLine("Invalid input");
                                break;
                            
                    }
                    Console.WriteLine(string.Join(", ", arr));
                }
            }
        }
    }
}

        
    

