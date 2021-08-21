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
            print("Type of : enum Days" + Enum.GetUnderlyingType(typeof(Days)));

            Days Days1 = Days.Monday;
            Days Days2 = Days.Tuesday;
            Days Days3 = Days.Wednesday;
            Days Days4 = Days.Thursday;
            Days Days5 = Days.Friday;
            Days Days6 = Days.Saturday;
            Days Days7 = Days.Sunday;

            print(Days1);
            print(Days2);
            print(Days3);
            print(Days4);
            print(Days5);
            print(Days6);
            print(Days7);
        }
    }
}