using System;

namespace Snake
{
    class Program
    {
        static void Sum(params int[] parameters)
        {
            int result = 0;

            for (int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }

            Console.WriteLine(result);
        }
        static void Foo(params object[] parameters)
        {
            string message = "Type data {0} = {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
        static void Main()
        {
            Sum(1, 2, 3, 4);
            Foo("sdfsd", 3, 'q', 1.78f, true);
        }
    }
}