namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{
    // Property with get and set for the figure name
    public string Name { get; set; }

    // Constructor that receives the name of the figure
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    // Abstract method to calculate the area of the figure
    public abstract double GetArea();

    // Abstract method to calculate the perimeter of the figure
    public abstract double GetPerimeter();

    // Returns a formatted string showing name, area and perimeter
    public override string ToString()
    {
        return $"{Name,-13} => Area.....: {GetArea(),13:N5}   Perimiter: {GetPerimeter(),11:N5}";
    }
}
