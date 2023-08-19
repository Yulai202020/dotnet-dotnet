using System;
// [a == b] ? [a] : [b];
namespace Programm
{
    class Programm
    {
        enum Days
        {
            Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7
        }
        static void print(object a)
        {
            Console.Write(a);
        }
        static void Main(string[] args)
        {            
            string pass = "QwErTy2021привет";
            string a = Console.ReadLine();
            if (a == pass)
            {
                int h = int.Parse(Console.ReadLine());
                if (h < 300)
                {
                    for (int i = 0;i < h+1;i++)
                    {
                        for (int j = 0;j < i;j++)
                        {
                            print("*");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    
                    for (int i = 0;i < h;i++)
                    {
                        for (int j = h;j > i;j--)
                        {
                            print("*");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                } else
                {
                    Console.WriteLine("It's a big number !!!");
                }


            }
        }
    }
}