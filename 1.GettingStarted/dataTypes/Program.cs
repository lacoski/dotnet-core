using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));

            int number_data = 20;
            string string_data = "demo";

            Console.WriteLine("number_data: {0}", number_data);
            Console.WriteLine("string_data: {0}", string_data);

            dynamic dynamic_data = 20;

            Console.WriteLine("dynamic_data: {0}", dynamic_data);

            dynamic_data = "TEST";

            Console.WriteLine("dynamic_data: {0}", dynamic_data);

            // Convert Type

            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;

            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
        }
    }
}
