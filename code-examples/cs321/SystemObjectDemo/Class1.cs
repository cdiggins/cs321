using System;

namespace SystemObjectDemo
{
    public static class ObjectDemo
    {
        public static void DemoObjects()
        {
            object a = 42;
            object b = "Hello";
            object c = 3.14;
            object[] xs = { a, b, c };
            var i = 0;
            foreach (var x in xs)
            {
                Console.WriteLine($"Value {i++} is {x} and is of type {x.GetType()}");
            }
        }
    }
}
