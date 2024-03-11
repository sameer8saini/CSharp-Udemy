Circle circleOne = new Circle(5);
double result =  circleOne.CalculateArea();
Console.WriteLine($"The area of circle with radius 5 is {result}");
circleOne.Print();


public abstract class Shape
{
    // Abstract Method
    public abstract double CalculateArea();

    // Concrete Method
    public void Print()
    {
        Console.WriteLine("This is the implementation of the Print method");
    }
}


public class Circle : Shape
{
    public double Radius { get; set; }


    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
