using System.Security.Cryptography.X509Certificates;

namespace Rot13Tests
{
    public static class Tests
    {
        [Test]
        public static void SmokeTest()
        {
            var stringReader = new StringReader("abc");
            Console.SetIn(stringReader);
            Rot13.Program.Main(Array.Empty<string>());
        }

        [Test]
        public static void Rot13CharTest()
        {
            Assert.AreEqual('1', Rot13.Program.Rot13('1'));
            Assert.AreEqual('a', Rot13.Program.Rot13('n'));
            Assert.AreEqual('A', Rot13.Program.Rot13('N'));
            Assert.AreEqual('m', Rot13.Program.Rot13('z'));
            Assert.AreEqual('M', Rot13.Program.Rot13('Z'));
        }

        [Test]
        public static void Rot13StringTest()
        {
            Assert.AreEqual("Uryyb", Rot13.Program.Rot13("Hello"));
        }
    }
}