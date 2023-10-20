using System;

public class Fraction 
{
    private int numerator {get; set;}
    private int denominator {get; set;}
    
    public int Numerator
    {
        get {return numerator;}
        set {numerator = value;}
    }

    public int Denominator
    {
        get {return denominator;}
        set {if (value != 0) 
            {
                denominator = value;
            }
            else
            {
                Console.WriteLine("denominator can not = 0.");
            }
        }
    }

    public Fraction ()
    {
        numerator = 1;
        denominator = 1;
    }

    public Fraction (int top)
    {
        numerator = top;
        denominator = 1;
    }

    public Fraction (int top, int bottom)
    {
        numerator = top;
        denominator = bottom;
    }

    public string GetFractionString()
    {
        return numerator + "/" + denominator;
    }

    public double GetDecimalValue()
    {
        return (double)numerator/denominator;
    }

}