namespace GeometricFigures.Backend;

public class Rectangle : Square
{
    // Private field for side B
    private double _b;

    // Property with get and set for side B
    public double B
    {
        get { return _b; }
        set { _b = value; }
    }

    // Constructor that receives name, side A and side B
    public Rectangle(string name, double a, double b) : base(name, a)
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

    // Area = A * B
    public override double GetArea() => A * _b;

    // Perimeter = 2 * (A + B)
    public override double GetPerimeter() => 2 * (A + _b);
}
