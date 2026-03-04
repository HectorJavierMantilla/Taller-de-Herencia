namespace GeometricFigures.Backend;

public class Trapeze : Triangle
{
    // Private field for side D (parallel base)
    private double _d;

    // Property with get and set for side D
    public double D
    {
        get { return _d; }
        set { _d = value; }
    }

    // Constructor that receives name, sides A, B, C, D and height H
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        ValidateD(d);
        _d = d;
    }

    // Validates side D is greater than 0, throws exception otherwise
    private static void ValidateD(double d)
    {
        if (d <= 0)
            throw new ArgumentException($"The side D: {d}, is not valid. Must be greater than 0.");
    }

    // Area = (B + D) * H / 2
    public override double GetArea() => (B + _d) * H / 2;

    // Perimeter = A + B + C + D
    public override double GetPerimeter() => A + B + C + _d;
}
