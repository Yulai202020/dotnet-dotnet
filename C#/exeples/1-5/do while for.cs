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
            print("Input str1 : ");

            string w = Console.ReadLine();

            print("Input str1 : ");

            string e = Console.ReadLine();
            String str1 = w + "!!!";
            String str2 = e + " !!!";
            int q = 10;

            do
            {
                print(str1);
            } while (q-- > 0);
            for (int i = 0; i < 10; i++)
            {
                print(str2);
            }

            q = 0;
            while (q++ < 10)
            {
                print(str1);
            }
        }
    }
}