using System;

// The get accessor returns the property value, while the set accessor assigns a new value. 

public class Fraction
{
    private int _top;
    private int _bottom;

    // Setter
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Setter
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Setter
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter
    public string getFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // "double" data type in the C language that helps in storing high-precision sorts of 
    // floating-point numbers or data in the computer memory.
    // Getter
    public double getDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}