
Car car1 = new Car();
car1.Make = "Honda";
car1.Model = "Jazz";
car1.YearRegistered = 2020;
car1.NumberOfDoors = 4;
car1.Start();
car1.Park();
car1.Stop();


Motorcycle m1 = new Motorcycle();
m1.Make = "Honda";
m1.Model = "CBR";
m1.YearRegistered = 2019;
m1.Start();
m1.Wheelie();
m1.Stop();

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


public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void Park()
    {
        Console.WriteLine("The vehicle has parked itself");
    }
}

public class Motorcycle : Vehicle
{
    public void Wheelie()
    {
        Console.WriteLine("The motorcycle has performed a wheelie");
    }
}