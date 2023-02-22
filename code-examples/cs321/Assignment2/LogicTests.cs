using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class LogicTests
    {
        // With ternary operators
        public static bool Or(bool a, bool b) => a ? true : b;
        public static bool Xor(bool a, bool b) => a ? Not(b) : b;
        public static bool And(bool a, bool b) => a ? b : false;
        public static bool NotA(bool a, bool b) => Not(a);
        public static bool NotB(bool a, bool b) => Not(b);
        public static bool Not(bool b) => b ? false : true;
        public static bool Nor(bool a, bool b) => Not(Or(a, b));
        public static bool Nand(bool a, bool b) => Not(And(a, b));        

        /*
        public static bool Or(bool a, bool b) => Nand(Not(a), Not(b));
        public static bool Xor(bool a, bool b) => a ? Not(b) : b;
        public static bool And(bool a, bool b) => Not(Nand(a, b));
        public static bool NotA(bool a, bool b) => Not(a);
        public static bool NotB(bool a, bool b) => Not(b);
        public static bool Not(bool b) => Nand(b, b);
        public static bool Nor(bool a, bool b) => Not(Or(a, b));
        public static bool Nand(bool a, bool b) => !(a && b);
        */

        [Test]
        public static void TestOperators()
        {
            foreach (var a in new[] { true, false })
            {
                foreach (var b in new[] { true, false })
                {
                    Assert.AreEqual(a || b, Or(a, b));
                    Assert.AreEqual(a ^ b, Xor(a, b));
                    Assert.AreEqual(a && b, And(a, b));
                    Assert.AreEqual(!a, NotA(a, b));
                    Assert.AreEqual(!b, NotB(a, b));
                    Assert.AreEqual(!(a || b), Nor(a, b));
                    Assert.AreEqual(!(a && b), Nand(a, b));
                }
            }
        }
    }
}
