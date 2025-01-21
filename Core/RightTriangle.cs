namespace Core;

public class RightTriangle : Triangle
{
    internal RightTriangle(double hypotenuse, double cathetus1, double cathetus2) : base(hypotenuse, cathetus1, cathetus2)
    {
        Console.WriteLine("\tDEBUG --> Right triangle constructor: begin.");

        Hypotenuse = hypotenuse;
        Cathetus1 = cathetus1;
        Cathetus2 = cathetus2;
        
        Console.WriteLine("\tDEBUG --> Right triangle constructor: end.");
    }
    
    public override string ToString() => $"is right = true, hypotenuse = {Hypotenuse}, cathetus 1 = {Cathetus1}, cathetus 2 = {Cathetus2}, area = {Area}";

    public override double Area
    {
        get
        {
            Console.WriteLine("\tDEBUG --> Right triangle getter of area: begin.");
            
            if (_area == null)
                _area = Cathetus1 * Cathetus2 / 2;
            
            Console.WriteLine("\tDEBUG --> Right triangle getter of area: end.");

            return _area.Value;
        }
    }
    
    public double Hypotenuse { get; }
    
    public double Cathetus1 { get; }
    
    public double Cathetus2 { get; }
    
    private double? _area;
}