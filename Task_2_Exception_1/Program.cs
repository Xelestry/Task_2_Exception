using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Task_2_Exception_2;

namespace Task_2_Exception_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //make true for skip Task_2_Exception_1
            bool closeProgram = true;

            Console.WriteLine("Number of lines: ");

            while (!closeProgram)
            {
                if (int.TryParse(Console.ReadLine(), out int numberOfLines))
                {
                    List<string> lines = new List<string>();

                    for (int i = 0; i < numberOfLines; i++)
                    {
                        Console.WriteLine($"Enter line number {i + 1}: ");
                        lines.Add(Console.ReadLine());
                    }

                    Console.WriteLine("__________________________________________________________\n\n");

                    for (int i = 0; i < numberOfLines; i++)
                    {
                        string lineWithoutSpaces = lines.ElementAt(i).Replace(" ", "");

                        if (lineWithoutSpaces.Length > 0)
                        {
                            char firstLetter = lineWithoutSpaces[0];
                            Console.WriteLine($"First letter of line {i + 1}: {firstLetter}");
                        }
                        else
                        {
                            Console.WriteLine($"Line {i + 1} is empty! :c");
                        }
                    }

                    closeProgram = true;
                }
                else
                {
                    Console.WriteLine("It's not a number! Please, try again: ");
                }
            }

            // remove comment for Testing Task_2_Exception_2 library
            MyParser.StringToInt("    ", out int targetNumber);
        }
    }
}
