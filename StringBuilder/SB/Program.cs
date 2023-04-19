using System;
using System.Text;

namespace SB
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            result.Append(text);

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "Exit")
                {
                    break;
                }

                switch (input[0])
                {
                    case "Аppend":
                        {
                            result.Append(input[1]);
                            break;
                        }

                    case "Remove":
                        {
                            int index = int.Parse(input[1]);
                            int number = int.Parse(input[2]);
                            result.Remove(index, number);
                            break;
                        }

                    case "Insert":
                        {
                            int index = int.Parse(input[1]);
                            string element = input[2];
                            result.Insert(index, element);
                            break;
                        }

                    case "Replace":
                        {
                            string element = input[1];
                            string element1 = input[2];
                            result.Replace(element, element1);
                            break;
                        }
                    default:
                        break;
                }
            }
            Console.WriteLine(result.ToString());
            Console.WriteLine("Finish!");
        }
    }
}
