namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{
    // Private field for side A
    private double _a;

    // Property with get and set for side A
    public double A
    {
        get { return _a; }
        set { _a = value; }
    }

    // Constructor that receives name and side A
    public Square(string name, double a) : base(name)
    {
        ValidateA(a);
        _a = a;
    }

    // Validates side A is greater than 0, throws exception otherwise
    private static void ValidateA(double a)
    {
        if (a <= 0)
            throw new ArgumentException($"The side A: {a}, is not valid. Must be greater than 0.");
    }

    // Area = A^2
    public override double GetArea() => _a * _a;

    // Perimeter = 4A
    public override double GetPerimeter() => 4 * _a;
}
