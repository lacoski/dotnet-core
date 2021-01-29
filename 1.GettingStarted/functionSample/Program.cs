using System;

namespace functionSample
{
    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }

        static void Main(string[] args)
        {
            // Value Parameter
            int a = 4, b = 8;
            int c = Add(a, b);

            Console.WriteLine("{0} + {1} = {2}", a, b, c);

            // Reference parameter
            a = 5;
            b = 10;
            Console.WriteLine("Before call method:");
            Console.WriteLine("a={0},b={1}", a, b);

            Swap(ref a, ref b);

            Console.WriteLine("\nAfter call method:");
            Console.WriteLine("a={0},b={1}", a, b);
            Console.ReadLine();

        }
    }
}
