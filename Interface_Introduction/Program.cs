Rectangle rect1 = new Rectangle();
rect1.Length = 5;
rect1.Width = 10;
double perimeterOfRect1 = rect1.CalculatePerimeter();
double areaOfRect1 = rect1.CalculateArea();
Console.WriteLine($"The area and perimeter of a rectangle is {areaOfRect1}, {perimeterOfRect1}");


Triangle t1 = new Triangle();
t1.SideOne = 9;
t1.SideTwo = 11;
t1.SideThree = 16;
double perimeterOft1 = t1.CalculatePerimeter();
double areaOft1 = t1.CalculateArea();
Console.WriteLine($"The area and perimeter of a triangle is {areaOft1}, {perimeterOft1}");



public class Rectangle : IPolygon
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double CalculateArea()
    {
        return Length * Width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

public class Triangle : IPolygon
{
    public double SideOne { get; set; }
    public double SideTwo { get; set; }
    public double SideThree { get; set; }

    public double CalculateArea()
    {
        double s = (SideOne + SideTwo + SideThree) / 2;
        return Math.Sqrt(s * (s - SideOne) * (s - SideTwo) * (s - SideThree));
    }

    public double CalculatePerimeter()
    {
        return SideOne + SideTwo + SideThree;
    }
}


public interface IPolygon
{
    double CalculateArea();
    double CalculatePerimeter();
}