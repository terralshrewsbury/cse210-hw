public class Circle : Shape
{
    private double _radius = 5;
    
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public override double GetArea()
    {
        return Math.PI *(_radius*_radius);
    }



}