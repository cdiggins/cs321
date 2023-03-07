using NUnit.Framework;

namespace Midterm
{
    public enum Align 
    { 
        Left, Right, Center, None 
    };

    public class Vector
    {
        public Vector(int x, int y) { _x = x; _y = y; }
        private int _x, _y;
        public int X => _x;
        public int Y => _y;
        public Vector Half => new(X / 2, Y / 2);
        public override string ToString() => $"{X}, {Y}";
    }

    public class Shape
    {
        public Vector Pos = new(0, 0);
        public Vector Size = new(0, 0);
        public int Left => Pos.X;
        public int Right => Left + Size.X;
        public int MidX => Left + Size.X / 2;
        public override string ToString() => $"I am a Shape at {Pos} with size {Size}";
    }

    public class Box : Shape
    { 
        private List<Shape> _children = new();
        public Box(Vector pos, Vector size) => (Pos, Size) = (pos, size);                
        public IReadOnlyList<Shape> Children => _children;                 
        public void AddChild(Shape shape) => _children.Add(shape);         
        public override string ToString() => $"I am a Box at {Pos} with size {Size}";
    }

    public class Ellipse : Shape
    {
        public Ellipse(Vector pos, Vector radii) => (Pos, Size) = (pos, radii);
        public int RadiusX => Size.X;
        public int RadiusY => Size.Y;
    }

    public class Circle
    {
        public Circle(Vector pos, int radius) => (Pos, Radius) = (pos, radius);
        public Vector Pos { get; }
        public int Radius { get; }
        public override string ToString() => $"I am a Circle at {Pos} with radius {Radius}";
    }

    public static class Tests
    {
        public static void AlignChild(Box parent, Shape child, Align align)
        {
            var x = child.Pos.X;
            if (align == Align.Left) x = parent.Left;
            if (align == Align.Right) x = parent.Right - child.Size.X;
            if (align == Align.Center) x = parent.MidX - child.Size.X / 2;
            child.Pos = new(x, child.Pos.Y);
        }

        [Test]
        public static void TestAlign()
        {
            // TODO: fill me out. 
        }
    }
}