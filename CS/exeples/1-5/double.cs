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

            double a = 0.55313553;
            double b = 0.325515;
            double c = 0.3667675625515;
            double result = a + b;
            double result2 = a + (b + c);

            print(a);
            print(b);
            print(c);
            print(result);
        }
    }
}