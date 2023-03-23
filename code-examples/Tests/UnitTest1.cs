using System.Drawing;
using System.Xml.Serialization;
using SimplePainterApplication;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public record ShapeRecord(
            Color StrokeColor,
            float StrokeThickness,
            float X,
            float Y,
            float Width,
            float Height,
            Color FillColor,
            bool Filled,
            ShapeType Type
        );


        public static readonly Shape MyShape = new Shape()
        {
            FillColor = System.Drawing.Color.Blue,
            StrokeColor = Color.SaddleBrown,
            StrokeThickness = 2,
            X = 5,
            Y = 10,
            Width = 12,
            Height = 13,
            Filled = true,
            Type = ShapeType.Ellipse,
        };

        [Test]
        public void TestReflection()
        {
            var t = MyShape.GetType();
            foreach (var fi in t.GetFields())
            {
                var name= fi.Name;
                var value = fi.GetValue(MyShape);
                Console.WriteLine($"Field {name} has value {value}");
            }
        }


        [Test]
        public void Test1()
        {
            var xs = new XmlSerializer(typeof(Shape));
            var sw = new StringWriter();
            xs.Serialize(sw, MyShape);
            var text = sw.ToString();
            Console.WriteLine(text);

            var tr = new StringReader(text);
            var tmp = xs.Deserialize(tr);
            
            Console.WriteLine(tmp);
        }
    }
}