namespace GeometricFigures.Backend;

public class Circle : GeometricFigure
{
    // Private field for radius R
    private double _r;

    // Property with get and set for radius R
    public double R
    {
        get { return _r; }
        set { _r = value; }
    }

    // Constructor that receives name and radius R
    public Circle(string name, double r) : base(name)
    {
        ValidateR(r);
        _r = r;
    }

    // Validates radius R is greater than 0, throws exception otherwise
    private static void ValidateR(double r)
    {
        if (r <= 0)
            throw new ArgumentException($"The radius R: {r}, is not valid. Must be greater than 0.");
    }

    // Area = PI * R^2
    public override double GetArea() => Math.PI * _r * _r;

    // Perimeter = 2 * PI * R
    public override double GetPerimeter() => 2 * Math.PI * _r;
}
