namespace SimplePainterApplication;

public enum ShapeType
{
    Ellipse,
    Rect,
}

public class Shape
{
    public Color StrokeColor;
    public float StrokeThickness;
    public float X;
    public float Y;
    public float Width;
    public float Height;
    public Color FillColor;
    public bool Filled;
    public ShapeType Type;
}