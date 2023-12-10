public class Cone : Solid
{
    private double _height;
    private double _radius;
    private double _slant;

    public Cone(string name, string color, double height, double radius, double slant) : base (name, color)
    {
        _height = height;
        _radius = radius;
        _slant = slant;
    }

    public override double GetVolume()
    {
        return _height * _radius * _radius * Math.PI / 3;
    }

    public override double GetSurfaceArea()
    {
        return (_radius * _radius * Math.PI) + (_radius * _slant * Math.PI);
    }
}