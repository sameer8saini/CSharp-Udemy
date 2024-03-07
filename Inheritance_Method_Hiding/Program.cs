
Vehicle car1 = new Car
{
    Make = "Honda",
    Model = "Jazz",
    YearRegistered = 2020,
    NumberOfDoors = 4
};
//((Vehicle)car1).Start();
car1.Start();
//car1.Park();
car1.Stop();



// Base class
public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int YearRegistered { get; set; }

    public void Start()
    {
        Console.WriteLine("The vehicle has started");
    }

    public void Stop()
    {
        Console.WriteLine("The vehicle has stopped");
    }
}

// Derived Class
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void Park()
    {
        Console.WriteLine("The vehicle has parked itself");
    }

    public new void Start()
    {
        Console.WriteLine("The car has started");
    }
}


// Derived Class
public class Motorcycle : Vehicle
{
    public void Wheelie()
    {
        Console.WriteLine("The motorcycle has performed a wheelie");
    }
}