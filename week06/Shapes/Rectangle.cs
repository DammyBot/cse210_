public class Rectangle : Shape
{
    private double _width;
    private double _length;

    public Rectangle(double width, double height, string color) : base(color)
    {
        _width = width;
        _length = height;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}