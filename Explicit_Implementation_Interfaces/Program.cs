
IPolygon I1 = new Rectangle();
I1.Print();


public class Rectangle : IPolygon
{
    public double CalculateArea()
    {
        Console.WriteLine("This is implementation for CalculateArea");
        return 0d;
    }
}


public interface IPolygon
{
    public void Print()
    {
        Console.WriteLine("This is the Implementation from IPolygon interface");
    }

    double CalculateArea();
}