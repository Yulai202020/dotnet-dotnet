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

            int a = 12;
            int b = 13;

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
        }
    }
}