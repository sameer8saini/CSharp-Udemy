public class Program
{
    public static void Main()
    {
        Add(1.1d, 2.2d);
    }

    public static void Add(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        Console.WriteLine($"The result is {result}");
    }

    // Different order of types
    public static void Add(double firstNumber, int secondNumber)
    {
        double result = firstNumber + secondNumber;
        Console.WriteLine($"The result is {result}");
    }

    // Different order of types
    public static void Add(int firstNumber, double secondNumber)
    {
        double result = firstNumber + secondNumber;
        Console.WriteLine($"The result is {result}");
    }


    // This is method overloading
    // Passing different types of parameters
    public static void Add(double firstNumber, double secondNumber)
    {
        double result = firstNumber + secondNumber;
        Console.WriteLine($"The result is {result}");
    }


    // This is method overloading
    // Passing different number of parameters
    public static void Add(int firstNumber, int secondNumber, int thirdNumber)
    {
        int result = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine($"The result is {result}");
    }







}