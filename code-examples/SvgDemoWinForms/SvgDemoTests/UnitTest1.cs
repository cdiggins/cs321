
using SvgDemoWinForms;

namespace SvgDemoTests
{
    public static class Tests
    {
        public static Size Size1 = new Size() { Width = 50, Height = 60 };
        public static Size Size2 = new Size() { Width = 10, Height = 80 };
        public static Point Pt1 = new Point() { X = 3, Y = 10 };
        public static Point Pt2 = new Point() { X = 20, Y = 5 };
        public static Point Pt3 = new Point() { X = 4, Y = 5 };

        public static SvgDocument Doc = new SvgDocument()
        {
            Elements = new List<Element>()
            {
                new Ellipse()
                {
                    Position = Pt1,
                    Size = Size1,
                },
                new Rect()
                {
                    Position = Pt2,
                    Size = Size2
                },
                new Polygon()
                {
                    Points = new List<Point>() { Pt1, Pt2, Pt3 }
                }
            }
        };

        [Test]
        public static void TestJson()
        {
            var txt = Doc.ToJson();
            Console.WriteLine(txt);
            var val = SvgDocument.FromJson(txt);
            txt = val.ToJson();
            Console.WriteLine(txt);
        }
    }
}