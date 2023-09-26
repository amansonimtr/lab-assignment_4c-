using System;

public enum ShapeType
{
    Circle,
    Square,
    Triangle
}

public class GeometryCalculator
{
    public double CalculateArea(ShapeType shape, double[] parameters)
    {
        switch (shape)
        {
            case ShapeType.Circle:
                if (parameters.Length != 1)
                {
                    throw new ArgumentException("A circle requires one parameter: radius.");
                }
                double radius = parameters[0];
                return Math.PI * radius * radius;

            case ShapeType.Square:
                if (parameters.Length != 1)
                {
                    throw new ArgumentException("A square requires one parameter: side length.");
                }
                double sideLength = parameters[0];
                return sideLength * sideLength;

            case ShapeType.Triangle:
                if (parameters.Length != 2)
                {
                    throw new ArgumentException("A triangle requires two parameters: base and height.");
                }
                double baseLength = parameters[0];
                double height = parameters[1];
                return 0.5 * baseLength * height;

            default:
                throw new ArgumentException("Invalid shape.");
        }
    }
}

class Program
{
    static void Main()
    {
        GeometryCalculator calculator = new GeometryCalculator();

        double circleArea = calculator.CalculateArea(ShapeType.Circle, new double[] { 5.0 });
        Console.WriteLine($"Area of the circle: {circleArea:F2}");

        double squareArea = calculator.CalculateArea(ShapeType.Square, new double[] { 4.0 });
        Console.WriteLine($"Area of the square: {squareArea:F2}");

        double triangleArea = calculator.CalculateArea(ShapeType.Triangle, new double[] { 6.0, 8.0 });
        Console.WriteLine($"Area of the triangle: {triangleArea:F2}");
    }
}
