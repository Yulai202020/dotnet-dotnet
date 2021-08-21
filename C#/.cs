using System;
using System.Linq;
// [a == b] ? [a] : [b];
namespace Programm
{
    class Program_2_0
    {
        static void q_2021( )
        {
            Console.WriteLine(1);
        }
        public int qwerty = 0;
        private int qwer = 1;
        static void Main()
        {
            Program mc = new Program();
            mc.q_2021();
        }
    }
    class Programm
    {
        static void print(object a)
        {
            Console.WriteLine(a);
        }

        enum Days
        {
            Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7
        }

        static void newref(ref int a)
        {
            print(a)
        }

        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            print(array1.Where(i => i % 2 == 0).Sum());
            print(array1.Where(i => i % 2 == 0).Min());
            print(array1.Where(i => i % 2 == 0).Max());

            print("");
            print(array1.Where(i => i % 2 != 0).Sum());
            print(array1.Where(i => i % 2 != 0).Min());
            print(array1.Where(i => i % 2 != 0).Max());

            print("");
            print(array1.Sum());
            print(array1[^1]);

            int[] a = array1[..3];

            print(a);
            // int ToInt32 = 0;
            // do {
            //     print("Иди !!! ");
            //     Console.Write(ToInt32);
            //     print("");
            // } while (ToInt32++ < 10);
        }
    }
}
// 29 - end