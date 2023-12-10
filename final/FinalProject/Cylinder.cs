public class Cylinder : Solid
{
    private double _radius;
    private double _height;

    public Cylinder(string name, string color, double height, double radius) : base (name, color)
    {
        _height = height;
        _radius = radius;
    }

    public override double GetVolume()
    {
        return _height * _radius * _radius * Math.PI;
    }

    public override double GetSurfaceArea()
    {
        return (2 * _radius * _height * Math.PI) + (2 * _radius * _radius * Math.PI);
    }
}