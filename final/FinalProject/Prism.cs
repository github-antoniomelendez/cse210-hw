public class Prism : Solid
{
    private double _base;
    private double _height;
    private double _apothem;

    //this is a pentagonal prism
    public Prism(string name, string color, double length, double height, double apothem) : base (name, color)
    {
        _base = length;
        _height = height;
        _apothem = apothem;
    }

    public override double GetVolume()
    {
        return 5 * _base * _height * _apothem / 2;
    }

    public override double GetSurfaceArea()
    {
        return (5 * _apothem * _base) + (5 * _base * _height);
    }
}