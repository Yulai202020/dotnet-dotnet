using System;

namespace Programm
{
    class Programm
    {
        static void print(object str)
        {
            System.Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Console.Write("┌───────────────┬───────────────┬───────────────┬───────────────┬───────────────┬───────────────┐\n");
            int[,] array = new int[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    array[j, i] = i + j;
                    Console.Write("|\t" + array[j, i] + "\t");
                    if (j == 5)
                    {
                        Console.Write("|");
                    }

                }
                print("");
            }
            Console.Write("└───────────────┴───────────────┴───────────────┴───────────────┴───────────────┴───────────────┘\n");
        }
    }
}