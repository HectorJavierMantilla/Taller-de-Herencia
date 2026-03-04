namespace GeometricFigures.Backend;

public class Triangle : Rectangle
{
    // Private field for side C
    private double _c;

    // Private field for height H
    private double _h;

    // Property with get and set for side C
    public double C
    {
        get { return _c; }
        set { _c = value; }
    }

    // Property with get and set for height H
    public double H
    {
        get { return _h; }
        set { _h = value; }
    }

    // Constructor that receives name, sides A, B, C and height H
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        ValidateC(c);
        ValidateH(h);
        _c = c;
        _h = h;
    }

    // Validates side C is greater than 0, throws exception otherwise
    private static void ValidateC(double c)
    {
        if (c <= 0)
            throw new ArgumentException($"The side C: {c}, is not valid. Must be greater than 0.");
    }

    // Validates height H is greater than 0, throws exception otherwise
    private static void ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException($"The height H: {h}, is not valid. Must be greater than 0.");
    }

    // Area = (B * H) / 2
    public override double GetArea() => (B * _h) / 2;

    // Perimeter = A + B + C
    public override double GetPerimeter() => A + B + _c;
}
