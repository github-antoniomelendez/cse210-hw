public class Cube : Solid
{
    private double _side;

    public Cube(string name, string color, double side) : base (name, color)
    {
        _side = side;
    }

    public override double GetVolume()
    {
        return _side * _side * _side;
    }

    public override double GetSurfaceArea()
    {
        return 6 * _side * _side;
    }
}