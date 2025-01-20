using FluentResults;

namespace Core;

public static class TriangleFactory
{
    public static Result<Triangle> Create(double side1, double side2, double side3)
    {
        if (side1 >= side2 + side3 || side2 >= side1 + side3 || side3 >= side1 + side2)
            return Result.Fail("triangle is impossible");
        
        var sidesByDescOfLength = new[] { side1, side2, side3 };
        Array.Sort(sidesByDescOfLength, (s1, s2) => s2.CompareTo(s1));
        
        if (Math.Abs(sidesByDescOfLength[0] * sidesByDescOfLength[0] - (sidesByDescOfLength[1] * sidesByDescOfLength[1] + sidesByDescOfLength[2] * sidesByDescOfLength[2])) < 0.0000001)
            return Result.Ok<Triangle>(new RightTriangle(sidesByDescOfLength[0], sidesByDescOfLength[1], sidesByDescOfLength[2]));
        
        return Result.Ok(new Triangle(side1, side2, side3));
    }
}