public class Pyramid : Solid
{
    private double _height;
    private double _length;
    private double _width;
    
    //This is a rectangular pyramid
    public Pyramid(string name, string color, double height, double length, double width) : base (name, color)
    {
        _height = height;
        _length = length;
        _width = width;
    }

    public override double GetVolume()
    {
        return _length * _width * _height / 3;
    }

    public override double GetSurfaceArea()
    {
        return (_length * _height) + (_length * _width) + (_width * _height);
    }
}