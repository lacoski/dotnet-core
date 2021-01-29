using System;
using functionSample;

namespace MultiFileSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FunctionUtils func = new FunctionUtils();
            int a = 4, b = 8;
            int c = func.Add(a, b);

            Console.WriteLine("{0} + {1} = {2}", a, b, c); 
        }
    }
}
