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

            int[] myarr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int Result = 0;

            for (int i = 0; i < myarr.Length; i++)
            {
                if (myarr[i] % 2 == 0)
                {
                    Result += myarr[i];
                }
            }

            print(Result);
        }
    }
}