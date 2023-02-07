using Rot13;
using static Rot13.Program;
using static NUnit.Framework.Assert;

namespace Rot13Tests
{
    public static class Tests
    {
        [Test]
        public static void SmokeTest()
        {
            var stringReader = new StringReader("abc");
            Console.SetIn(stringReader);
            Main(Array.Empty<string>());
        }

        [Test]
        public static void Rot13CharTest()
        {
            That(Program.Rot13('1'), Is.EqualTo('1'));
            That(Program.Rot13('n'), Is.EqualTo('a'));
            That(Program.Rot13('N'), Is.EqualTo('A'));
            That(Program.Rot13('z'), Is.EqualTo('m'));
            That(Program.Rot13('Z'), Is.EqualTo('M'));
        }

        [Test]
        public static void Rot13StringTest()
        {
            That(Program.Rot13("Hello"), Is.EqualTo("Uryyb"));
        }
    }
}