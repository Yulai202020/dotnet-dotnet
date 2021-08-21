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
            try
            {
                String w = Console.ReadLine();
                String e = Console.ReadLine();

                var rand = new Random();

                int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                print(array1);

                String a1 = "1";
                String a2 = "2";

                int a3 = Convert.ToInt32(a1);
                int a4 = Convert.ToInt32(a2);
                int s1 = a3 + a4;

                print(s1);
                print(rand.Next());

                string p = "1";
                int assss;
                print(int.TryParse(p, out assss));
            }
            catch
            {
                print("Error ...");
            }
        }
    }
}