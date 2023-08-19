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

            int a = 0;

            a++;
            ++a;
            a--;
            --a;
            a = a + 1;
            a = a - 1;

            print(a);
        }
    }
}