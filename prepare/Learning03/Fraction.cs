using System;

public class Fraction

{
    private int _num;
    private int _den;

    public Fraction()
    {
        _num = 1;
        _den = 1;

    }

    public Fraction (int wholeNumber)
    {
        _num = wholeNumber;
        _den = 1;

    }

    public Fraction (int numerator, int denominator)
    {
        _num = numerator;
        _den = denominator;

    }
public int GetTop()
{
    return _num;

}
 public void SetTop(int numerator)
 {
    _num = numerator;

 }
 
 public int GetBottom()
 {
    return _den;

 }

 public void SetBottom(int denominator)
 {
    _den = denominator;

 }
     public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_num}/{_den}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_num / (double)_den;
    }


}





