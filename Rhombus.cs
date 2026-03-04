namespace GeometricFigures.Backend;

public class Rhombus : Square
{
    // Private field for diagonal D1
    private double _d1;

    // Private field for diagonal D2
    private double _d2;

    // Property with get and set for diagonal D1
    public double D1
    {
        get { return _d1; }
        set { _d1 = value; }
    }

    // Property with get and set for diagonal D2
    public double D2
    {
        get { return _d2; }
        set { _d2 = value; }
    }

    // Constructor that receives name, side A and diagonals D1 and D2
    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        ValidateD1(d1);
        ValidateD2(d2);
        _d1 = d1;
        _d2 = d2;
    }

    // Validates diagonal D1 is greater than 0, throws exception otherwise
    private static void ValidateD1(double d1)
    {
        if (d1 <= 0)
            throw new ArgumentException($"The diagonal D1: {d1}, is not valid. Must be greater than 0.");
    }

    // Validates diagonal D2 is greater than 0, throws exception otherwise
    private static void ValidateD2(double d2)
    {
        if (d2 <= 0)
            throw new ArgumentException($"The diagonal D2: {d2}, is not valid. Must be greater than 0.");
    }

    // Area = (D1 * D2) / 2
    public override double GetArea() => (_d1 * _d2) / 2;

    // Perimeter = 4 * A
    public override double GetPerimeter() => 4 * A;
}
