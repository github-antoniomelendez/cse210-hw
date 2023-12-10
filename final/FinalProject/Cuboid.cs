public class Cuboid : Solid
{
    private double _length;
    private double _width;
    private double _height;

    public Cuboid(string name, string color, double length, double width, double height) : base (name, color)
    {
        _length = length;
        _width = width;
        _height = height;
    }

    public override double GetVolume()
    {
        return _length * _width * _height;
    }

    public override double GetSurfaceArea()
    {
        return (4 * _height * _length) + (2 * _height * _width );
    }
}