namespace Core;

public class Triangle
{
    internal Triangle(double side1, double side2, double side3)
    {
        Console.WriteLine("Triangle constructor: begin.");
        
        Perimeter = side1 + side2 + side3;
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
        
        Console.WriteLine("Triangle constructor: end.");
    }

    public override string ToString() => $"is right = false, side 1 = {Side1}, side 2 = {Side2}, side 3 = {Side3}, area = {Area}";

    public virtual double Area
    {
        get
        {
            Console.WriteLine("Triangle getter of area: begin.");
            
            if (_area == null)
            {
                var semiperimeter = Perimeter / 2;
                _area = Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) *
                                  (semiperimeter - Side3));
            }
            
            Console.WriteLine("Triangle getter of area: end.");

            return _area.Value;
        }
    }

    public double Side1 { get; }
    
    public double Side2 { get; }
    
    public double Side3 { get; }
    
    public double Perimeter { get; }

    private double? _area;
}