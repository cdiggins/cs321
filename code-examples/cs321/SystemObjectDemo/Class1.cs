using System;
using System.IO;

namespace SystemObjectDemo
{
    public static class ObjectDemo
    {
        public static void DemoObjects()
        {
            object a = "hello";
            string b = "Hello";
            double c = 3.14;    
            object[] xs = { a, b, c };
            var i = 0;
            foreach (var x in xs)
            {
                Console.WriteLine($"Value {i++} is {x} and is of type {x.GetType()}");
            }
        }

        public static void DemoDir(string folder)
        {
            var fs = Directory.GetFiles(folder);
            foreach (var f in fs)
            {
                var fi = new FileInfo(f);
                Console.WriteLine(FileInfo.Create(fi));
            }
        }
    }
}
