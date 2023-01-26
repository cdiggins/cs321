using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosAndTests
{
    public static class ArrayAndListDemos
    {
        [Test]
        public static void CreateArrays()
        {
            var array1 = new int[] { 1, 2, 3, 4 };
            var array2 = new[] { 1, 2, 3, 4 };
            Assert.AreEqual(array1, array2);
            Console.WriteLine($"The contents of array are {array1}");
            Console.WriteLine("The compiler says the type is an int[]");
            Console.WriteLine($"The type of array1 is {array1.GetType()}");            
        }

        public static int GetMinValue(int[] array)
        {
            Array.Sort(array);
            return array[0];
        }

        [Test]
        public static void SpookyEffects()
        { 
            var xs = new int[] { 17, 3, 512, 99, 9 };
            Console.WriteLine($"The third value is {xs[2]}");
            var min = GetMinValue(xs);
            Console.WriteLine($"The minimum value is {min}");
            Console.WriteLine($"The third value is {xs[2]}");
        }

        [Test]
        public static void ArrayToString()
        {
            var array = new object[] { 'a', 12, "hello", 3.14f };
            Console.WriteLine(string.Join(";", array));
        }

        [Test]
        public static void ManuallyFillingArray()
        {
            var array = new int[100];
            Assert.AreEqual(100, array.Length);
            Assert.AreEqual(0, array[0]);
            Assert.AreEqual(0, array[99]);
            for (var i=0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Assert.AreEqual(0, array[0]);
            Assert.AreEqual(99, array[99]);
        }

        [Test]
        public static void MethodsAreObjectsToo()
        {
            var o = CreateArrays;
            Console.WriteLine($"The object {o} has type {o.GetType()}");
            Console.WriteLine($"Compiler says o is a 'delegate void System.Action()'");
        }
    }
}
