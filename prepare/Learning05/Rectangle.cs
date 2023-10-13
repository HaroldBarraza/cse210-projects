public class Rectangle : Shape
{
    private double _height;
    private double _length;

    public Rectangle(double height, double length, string color):base(color)
    {
        _height = height;
        _length = length;
    }

    public override double GetArea()
    {
    return _height * _length;
    }
}