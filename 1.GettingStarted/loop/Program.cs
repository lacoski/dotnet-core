using System;

namespace loopExample
{
    class Program
    {
        static void Main(string[] args)
        {

            // while
            int a = 10;
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }

            // for
            for (a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("value of a: {0}", a);
            }

            // do while

            a = 10;
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a = a + 1;
            }
            while (a < 20);

            // break

            a = 10;
            while (a < 20)
            {
                Console.WriteLine("value of a: {0}", a);
                a++;

                if (a > 15)
                {
                    break;
                }
            }

            // continue
            a = 10;

            do
            {
                if (a == 15)
                {
                    a = a + 1;
                    continue;
                }
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            while (a < 20);
        }
    }
}
