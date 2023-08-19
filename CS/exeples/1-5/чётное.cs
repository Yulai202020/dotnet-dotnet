using System;

namespace Program2 {
    class Program2
    {
        static void Main()
        {
            int i;
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("чётное");
            }
            else
            {
                Console.WriteLine("не чётное");
            }
        }
    }
}