using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // this is the default value which is one at the numerator and one at the denominator 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

//this gets the fraction as a string 3/6, it is recomputed each time we have anew value
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

//this divides the numerator by the denominator, each time the program runs we can inseret a new value
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}