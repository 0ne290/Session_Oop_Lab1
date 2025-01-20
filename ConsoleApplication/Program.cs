using Core;

namespace ConsoleApplication;

internal static class Program
{
    private static void Main()
    {
        var resultOfCreatingTriangle = TriangleFactory.Create(16, 12, 20);//TriangleFactory.Create(10, 14, 20);//TriangleFactory.Create(16, 17, 8);

        if (resultOfCreatingTriangle.IsFailed)
        {
            Console.WriteLine($"Error. Detail: {resultOfCreatingTriangle.Errors[0].Message}.");
            
            return;
        }

        var triangle = resultOfCreatingTriangle.Value;
        
        Console.WriteLine($"Triangle: {triangle}.");
    }
}