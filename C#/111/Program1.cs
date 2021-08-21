using System;

namespace Programm2
{
    class Programm2
    {
        static void print2(object str)
        {
            Console.WriteLine(str);
        }

        static void Foo2(ref int a)
        {
            a += 5;
        }

        static void Main2(string[] args)
        {
            int a = 0;
            Foo2(ref a);
            print2(a);
        }
    }
}