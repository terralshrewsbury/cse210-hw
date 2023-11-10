public class Rectangle : Shape
{
    private double _length = 10;
    private double _width = 5;
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
     public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public override double GetArea()
    {
        return _width * _length;
    }
}