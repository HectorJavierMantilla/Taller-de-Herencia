namespace GeometricFigures.Backend;

public class Kite : Rhombus
{
    // Private field for side B
    private double _b;

    // Property with get and set for side B
    public double B
    {
        get { return _b; }
        set { _b = value; }
    }

    // Constructor that receives name, sides A and B, and diagonals D1 and D2
    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
    {
        ValidateB(b);
        _b = b;
    }

    // Validates side B is greater than 0, throws exception otherwise
    private static void ValidateB(double b)
    {
        if (b <= 0)
            throw new ArgumentException($"The side B: {b}, is not valid. Must be greater than 0.");
    }

    // Area = (D1 * D2) / 2
    public override double GetArea() => (D1 * D2) / 2;

    // Perimeter = 2 * (A + B)
    public override double GetPerimeter() => 2 * (A + _b);
}
