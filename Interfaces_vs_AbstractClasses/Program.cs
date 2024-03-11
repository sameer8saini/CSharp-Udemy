


public abstract class Shape
{
    public int Number;

    public abstract void Method();
}

public interface IShape
{
    // Allowed
    private static int Number;

    private void Method()
    {
        Console.WriteLine("This is a method");
    }


    // Not Allowed
    //public int Number;
}


public class C1 : I1, I2, IShape
{

}

public abstract class C2
{

}



public interface I1
{

}

public interface I2
{

}
