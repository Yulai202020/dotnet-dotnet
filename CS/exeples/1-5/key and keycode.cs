using System;

namespace Programm
{
    class Programm
    {
        static void print(object str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                int keycode = (int)key;
                print($"Enum {key} Key code {keycode} ...");
                if (key == ConsoleKey.Enter)
                {
                    print("Enter");
                }
            }
        }
    }
}