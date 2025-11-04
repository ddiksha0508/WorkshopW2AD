public class Circle
{
    public const double PI = 3.14;
    public double CalculateArea(double r)
    {
        return PI * r * r;
        
    }
    public double CalculatePerimeter(double r)
    {
        return 2 * PI * r;
    }
    static void Main(string[] Args)
    {
        Console.WriteLine($"Value of P1: {Circle.PI}");

        Circle c = new Circle();
        double r = 4;
        Console.WriteLine($"The area is : {c.CalculateArea(r)}");
        Console.WriteLine($"The perimeter is : {c.CalculatePerimeter(r)}");
    }
}