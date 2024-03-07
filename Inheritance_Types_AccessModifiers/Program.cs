Car car1 = new Car
{
    Make = "Honda",
    Model = "Jazz",
    NumberOfDoors = 4
};
car1.Start();
car1.Park();
car1.Stop();


Motorcycle m1 = new Motorcycle
{
    Make = "Honda",
    Model = "CBR",
};
m1.Start();
m1.Wheelie();
m1.Stop();


public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    private int YearRegistered { get; set; }

    public void Start()
    {
        Console.WriteLine("The vehicle has started");
    }

    public void Stop()
    {
        Console.WriteLine("The vehicle has stopped");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void RegisterCar()
    {
        //YearRegistered = 2019;
    }

    public void Park()
    {
        Console.WriteLine("The vehicle has parked itself");
    }
}

public class ElectricCar: Car
{
    public int BatteryCapacity { get; set; }
}

public class Motorcycle : Vehicle
{
    public void Wheelie()
    {
        Console.WriteLine("The motorcycle has performed a wheelie");
    }
}