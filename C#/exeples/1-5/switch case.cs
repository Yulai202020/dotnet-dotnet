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
            int b = 12;
            switch (a == b)
            {
                case false:
                    print("False");
                    break;
                case true:
                    print("True");
                    break;
            }
        }
    }
}