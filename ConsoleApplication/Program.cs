using Core;

namespace ConsoleApplication;

internal static class Program
{
    // Сервис для генерации случайных треугольников:
    // https://matematika-club.ru/generator-treugolnikov
    private static void Main()
    {
        // Невозможный треугольник.
        Console.WriteLine("Impossible triangle:");
        CreateAndLogTriangle(16, 17, 33);
        
        // Обычный треугольник.
        Console.WriteLine($"{Environment.NewLine}Regular triangle:");
        CreateAndLogTriangle(10, 14, 20);
        
        // Прямоугольный треугольник.
        Console.WriteLine($"{Environment.NewLine}Right triangle:");
        CreateAndLogTriangle(16, 12, 20);
        
        Console.Write($"{Environment.NewLine}To terminate the program, press any key...");
        Console.ReadKey();
    }

    private static void CreateAndLogTriangle(double side1, double side2, double side3)
    {
        var resultOfCreatingTriangle = TriangleFactory.Create(side1, side2, side3);

        if (resultOfCreatingTriangle.IsFailed)
        {
            Console.WriteLine($"\tError. Detail: {resultOfCreatingTriangle.Errors[0].Message}.");
            
            return;
        }

        var triangle = resultOfCreatingTriangle.Value;
        
        Console.WriteLine($"\tTriangle: {triangle}.");
    }
}