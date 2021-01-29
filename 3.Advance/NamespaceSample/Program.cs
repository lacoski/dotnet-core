using System;
using first_space;
using first_space.nested_namespace_cl;

using second_space;

namespace first_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }

    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }

    namespace nested_namespace_cl
    {
        class hjk
        {
            public void func()
            {
                Console.WriteLine("Inside nested_namespace_cl");
            }
        }
    }

}
namespace second_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }

    class efg
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}
class TestClass
{
    static void Main(string[] args)
    {
        first_space.namespace_cl fc = new first_space.namespace_cl();
        second_space.namespace_cl sc = new second_space.namespace_cl();
        fc.func();
        sc.func();


        abc fc1 = new abc();
        efg sc1 = new efg();
        fc1.func();
        sc1.func();

        hjk fun3 = new hjk();
        fun3.func();

    }
}
