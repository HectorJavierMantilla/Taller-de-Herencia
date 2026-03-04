namespace GeometricFigures.Backend;

public class Parallelogram : Rectangle
{
    // Private field for height H
    private double _h;

    // Property with get and set for height H
    public double H
    {
        get { return _h; }
        set { _h = value; }
    }

    // Constructor that receives name, sides A, B and height H
    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        ValidateH(h);
        _h = h;
    }

    // Validates height H is greater than 0, throws exception otherwise
    private static void ValidateH(double h)
    {
        if (h <= 0)
            throw new ArgumentException($"The height H: {h}, is not valid. Must be greater than 0.");
    }

    // Area = B * H
    public override double GetArea() => B * _h;

    // Perimeter = 2 * (A + B)
    public override double GetPerimeter() => 2 * (A + B);
}
