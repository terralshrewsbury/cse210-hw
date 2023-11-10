using System;
using System.Formats.Asn1;

public class Shape
{
    private string _shapename;
    private string _color;

    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetShapeName(string shapeName)
    {
        _shapename = shapeName;
    }
    public string GetShapeName()
    {
        return _shapename;
    }
    public virtual double GetArea(){
        return 0;
    }






}

