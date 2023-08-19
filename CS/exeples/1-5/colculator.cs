using System;
using System.Threading;

namespace Program{
    class Program
    {
        static void Main()
        {
            double f_v, s_v;
            string ac;
            Console.WriteLine("First number :");
            f_v = double.Parse(Console.ReadLine());
            Console.WriteLine("Second number :");
            s_v = double.Parse(Console.ReadLine());

            Console.WriteLine("Operations '+' '-' '*' '/' :");
            ac = Console.ReadLine();

            switch (ac)
            {
                case "+":
                    Console.WriteLine(f_v + s_v);
                    break;
                case "*":
                    Console.WriteLine(f_v * s_v);
                    break;
                case "-":
                    Console.WriteLine(f_v - s_v);
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine(f_v / s_v);
                    }
                    catch
                    {
                        Console.WriteLine("Error in 0/0 !!!");
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect operation !!!");
                    break;
            }
            Thread.Sleep(500);

        }
    }
}