
// This is for Default constructors
//Car obj1 = new Car();

Car obj1 = new Car("Honda", "Jazz");

obj1.PrintCarName();


public class Car
{
    public string Make;
    public string Model;

    // Default Constructor
    //public Car()
    //{
    //    Make = "Tesla";
    //    Model = "Model Y";
    //}


    public Car(string makeValue, string modelValue)
    {
        Make = makeValue;
        Model = modelValue;
    }


    public void PrintCarName()
    {
        Console.WriteLine($"The car is a {Make} {Model}");
    }
}