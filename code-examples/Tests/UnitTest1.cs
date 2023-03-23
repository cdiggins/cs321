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

        [Test]
        public void Test1()
        {
            var shape = new Shape()
            {
                FillColor = System.Drawing.Color.Blue,
                StrokeColor = Color.SaddleBrown,
                StrokeThickness = 2,
                X = 5, Y = 10,
                Width = 12, Height = 13,
                Filled = true,
                Type = ShapeType.Ellipse,
            };
            var xs = new XmlSerializer(typeof(Shape));
            var sw = new StringWriter();
            xs.Serialize(sw, shape);
            var text = sw.ToString();
            Console.WriteLine(text);

            var tr = new StringReader(text);
            var tmp = xs.Deserialize(tr);
            
            Console.WriteLine(tmp);
        }
    }
}