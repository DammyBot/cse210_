public class Square : Shape
{
    private double _side;

    public Square(double sideLength, string color) : base(color)
    {
        _side = sideLength;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}