Circle.Pi = 4;

Circle circle1 = new Circle(2);
float result1 = circle1.CalculateAreaOfCircle();


Circle circle2 = new Circle(3);
float result2 = circle2.CalculateAreaOfCircle();

Console.WriteLine(result1);
Console.WriteLine(result2);



public class Circle
{
    public static float Pi = 3.141F;
    public int Radius;


    public Circle(int radiusValue)
    {
        Radius = radiusValue;
    }


    public float CalculateAreaOfCircle()
    {
        return Pi * Radius * Radius;
    }
}