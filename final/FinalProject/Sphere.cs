public class Sphere : Solid
{
    private double _radius;

    public Sphere(string name, string color, double radius) : base (name, color)
    {
        _radius = radius;
    }

    public override double GetVolume()
    {
        return 4 * _radius * _radius * _radius * Math.PI / 3;
    }

    public override double GetSurfaceArea()
    {
        return 4 * _radius * _radius * Math.PI;
    }
}