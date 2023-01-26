using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        static string[] DaysOfWeek = new[] { "Monday", "Tuesday", "Wednesday", "Thursday"
            , "Friday", "Saturday", "Sunday"};

        static string[] Months = new[]
        {
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"
        };

        public static bool EndsWithY(string s)
        {
            return s.EndsWith("y");
        }

        public static void OutputArray<T>(T[] array)
        {
            var content = string.Join(", ", array);
            Console.WriteLine($"Contents of array is: {content}");
        }

        [Test]
        public static void ListDemo()
        {
            var xs = new List<int>() { 1, 2, 3 };
            xs.Add(4);
            xs.Add(5);
            var content = string.Join(", ", xs);            
            Console.WriteLine($"My list has {xs.Count} items: {content}");
            Console.WriteLine($"My list has the type {xs.GetType()}");
        }

        [Test]
        public static void ArrayResizeDemo()
        {
            var xs = new int[] { 1, 2, 3 };
            var ys = xs;
            OutputArray(xs);
            OutputArray(ys);
            xs[0] = 5;
            ys[1] = 4;
            OutputArray(xs);
            OutputArray(ys);
            Array.Resize(ref xs, 4);
            OutputArray(xs);
            OutputArray(ys);
            xs[0] = 1;
            ys[1] = 2;
            OutputArray(xs);
            OutputArray(ys);
        }

        public static object MyFunc(object x)
        {
            Console.WriteLine($"MyFunc is being called with {x}");
            return x;
        }

        public static bool IsWeekend()
        {
            var dayOfWeek = DateTime.Now.DayOfWeek;
            return dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday;
        }

        public static void PrintAOrB(bool b, object x, object y)
        {
            if (b)
                Console.WriteLine(x);
            else
                Console.WriteLine(y);
        }

        [Test]
        public static void ShortCircuitEvaluationDemo()
        {
            var x = IsWeekend() ? MyFunc("Party") : MyFunc("Work");
            Console.WriteLine(x);
            PrintAOrB(IsWeekend(), MyFunc("Party"), MyFunc("Work"));
        }

        [Test]
        [TestCase(true, true)]
        [TestCase(false, false)]
        [TestCase(true, false)]
        [TestCase(false, true)]
        public static void TestBoolean(bool a, bool b)
        {
            var notA = a ? false : true;
            var notB = b ? false : true;
            var and = a ? b : false;
            var or = a ? true : b;
            var xor = a ? notB : b;

            Assert.AreEqual(!a, notA);
            Assert.AreEqual(!b, notB);
            Assert.AreEqual(a && b, and);
            Assert.AreEqual(a || b, or);
            Assert.AreEqual(a ^ b, xor);
        }

        [Test]
        public static void TestFindIndex3()
        {
            var index = Array.FindIndex(Months, EndsWithY);
            string month; 
            if (index >= 0)
            {
                month = Months[index];
            }
            else
            {
                month = "no month";
            }
            Console.WriteLine($"First month that ends with y is {month}");
        }


        [Test]
        public static void TestFindIndex2()
        {
            var index = Array.FindIndex(Months, EndsWithY);
            var month = index < 0 ? "no month" : Months[index];
            Console.WriteLine($"First month that ends with y is {month}");
        }

        [Test]
        public static void TestFindIndex()
        {
            var index = Array.FindIndex(Months, m => m.EndsWith("y"));
            var month = index < 0 ? "no month" : Months[index];
            Console.WriteLine($"First month that ends with y is {month}");
        }

        // Doesn't compile
        //[Test]
        //public static void TestFindIndexNoCompile()
        //{
        //    var xs = new int[] { 1, 2, 3, 4 };
        //    var index = Array.FindIndex(xs, EndsWithY);
        //    Console.WriteLine($"Found the index {index}");
        //} 

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
