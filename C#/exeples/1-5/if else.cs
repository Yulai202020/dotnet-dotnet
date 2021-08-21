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
            bool isdea = true;
            int a = int.Parse(Console.ReadLine());

            if (a == 5)
            {
                print("you a dea");
                print("a = 5");
            }
            else
            {
                print("You live");
                print("a != 5");
            }

            // ==
            // !=
            // <
            // >
            // >=
            // <=
        }
    }
}