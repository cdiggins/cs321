using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace SvgDemoWinForms
{
    public class Element
    {
        public string Name { get; set; } 
        public string Id { get; set; }

        public Element()
        {
            Id = GetHashCode().ToString();
            Name = GetType().Name;
        }
    }

    public class Def : Element
    { }

    public class ColorServer : Def
    {
        public double Opacity { get; set; }
    }

    public class SolidColor : ColorServer
    {
        public Color Color { get; set; }
    }

    public class GradientStop
    {
        public double Offset { get; set; }
        public Color Color { get; set; }
        public double Opacity { get; set; } = 1;

        // https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/transform
        //public Transform Transform;
    }

    public class LinearGradient : ColorServer
    {
        public List<GradientStop> Stops { get; set; } = new();
    }

    public class Line : SimpleShape
    {
        public Point Start { get; set; }
        public Point End { get; set; }
    }

    public enum LineCap
    {
        Butt,
        Square,
        Round,
    }

    public enum LineJoin
    {
        Miter,
        Round,
        Bevel,
    }

    public class Color
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }
    }
    
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class Size
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Shape : Element
    {
        public Color StrokeColor { get; set; }
        public double StrokeWidth { get; set; }
        public Color FillColor { get; set; }
    }

    public class SimpleShape : Element
    {
        public Point Position { get; set; }
        public Size Size { get; set; }
    }

    public class Ellipse : SimpleShape
    {
    }

    public class Rect : SimpleShape
    {
    }

    public class PolyLine : Shape
    {
        public List<Point> Points { get; set; }
    }

    public class Polygon : Shape
    {
        public List<Point> Points { get; set; }
    }

    public class Text : Element
    {
        public string Family { get; set; }
        public string Style { get; set; }
        public string Contents { get; set; }
    }

    public class Fill
    {
        public Color Color { get; set; }
    }

    public class Viewport
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Settings
    {
        public List<string> RecentFiles { get; set; }
    }

    public class Document
    {
        public List<Element> Elements { get; set; } = new();

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, 
                Formatting.Indented, 
                new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
        }

        public static Document? FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Document>(json,
                new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
        }
    }
}
