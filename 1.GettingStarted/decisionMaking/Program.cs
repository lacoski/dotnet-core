using System;

namespace decisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            // if
            int a = 10;
            Console.WriteLine("value of a is : {0}", a);
            if (a < 20)
            {
                Console.WriteLine("a is less than 20");
            }

            // if else
            a = 10;
            Console.WriteLine("value of a is : {0}", a);
            if (a < 20)
            {
                Console.WriteLine("a is less than {0}", a);
            }
            else
            {
                Console.WriteLine("a is larger than {0}", a);
            }

            // else if
            a = 100;
            if (a == 10)
            {
                Console.WriteLine("Value of a is 10");
            }
            else if (a == 20)
            {
                Console.WriteLine("Value of a is 20");
            }
            else if (a == 30)
            {
                Console.WriteLine("Value of a is 30");
            }
            else
            {
                Console.WriteLine("None of the values is matching");
            }

            // nested if
            a = 100;
            int b = 200;

            if (a == 100)
            {

                if (b == 200)
                {
                    Console.WriteLine("Value of a is 100 and b is 200");
                }
            }
            Console.WriteLine("Exact value of a is : {0}", a);
            Console.WriteLine("Exact value of b is : {0}", b);

            // switch
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Well done");
                    break;
                case 'D':
                    Console.WriteLine("You passed");
                    break;
                case 'F':
                    Console.WriteLine("Better try again");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);
        }
    }
}
