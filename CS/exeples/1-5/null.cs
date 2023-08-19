using System;

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
            int? i = null;
            print(i.HasValue);
            print(i.GetValueOrDefault(1));
            print(i.GetValueOrDefault());
            print(i ??= 55);
            print(i);
        }
    }
}