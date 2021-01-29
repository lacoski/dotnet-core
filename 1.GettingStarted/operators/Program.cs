using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = a + b;
            Console.WriteLine("{0} + {1} = {2}", a.ToString(), b.ToString(), c.ToString());

            c = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, c);

            c = a * b;
            Console.WriteLine("{0} * {1} = {2}", a.ToString(), b.ToString(), c.ToString());

            c = a / b;
            Console.WriteLine("{0} / {1} = {2}", a.ToString(), b.ToString(), c.ToString());

            c = a % b;
            Console.WriteLine("{0} % {1} = {2}", a.ToString(), b.ToString(), c.ToString());

            c = a++;        
            Console.WriteLine("{0} ++ = {1}", a.ToString(), c.ToString());

            c = b--;
            Console.WriteLine("{0} -- = {1}", a.ToString(), c.ToString());

            a = 6;
            b = 4;
            bool check = (a >= b);
            Console.WriteLine("({0} >= {1}) is {2}", a, b, check.ToString());

            check = (a <= b);
            Console.WriteLine("({0} <= {1}) is {2}", a, b, check.ToString());

            check = (a == b);
            Console.WriteLine("({0} == {1}) is {2}", a, b, check.ToString());

            check = (a != b);
            Console.WriteLine("({0} != {1}) is {2}", a, b, check.ToString());
        }
    }
}
