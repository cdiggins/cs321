using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObjectDemo
{
    public static class Class1
    {
        public static void DemoObjects()
        {
            object a = 42;
            object b = "Hello";
            object c = 3.14;
            object[] xs = { a, b, c };
            foreach (var x in xs)
            {
                Console.WriteLine(x);
            }
        }
    }
}
