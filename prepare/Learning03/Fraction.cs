using System;
using System.Diagnostics;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        this._top = 1;
        this._bottom = 1;
    }
    public Fraction(int wholenumber)
    {
       this._top = wholenumber;
       this._bottom = 1;
    }
    public Fraction(int top,int bottom)
    {
        this._top=top;
        this._bottom=bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public double GetDecimalValue()
    {
        double result = (double)_top / _bottom;
        return result; 
    }
}

