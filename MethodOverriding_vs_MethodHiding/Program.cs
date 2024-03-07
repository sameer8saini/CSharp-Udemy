
BaseClass baseClass = new DerivedClass();
baseClass.Print();


public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("This is the base class print method");
    }
}

public class DerivedClass : BaseClass
{
    //// Method Hiding
    public new void Print()
    {
        Console.WriteLine("This is the derived class print method");
    }

    //// Method Overriding
    //public override void Print()
    //{
    //    Console.WriteLine("This is the derived class print method");
    //}
}