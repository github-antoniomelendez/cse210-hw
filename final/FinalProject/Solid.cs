public abstract class Solid
{
    private string _name;
    private string _color;

    public Solid(string name, string color)
    {
        _name = name;
        _color = color;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetVolume();

    public abstract double GetSurfaceArea();
}