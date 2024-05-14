string name = "Sameer";

void MethodOne()
{
    name = "Sameer Saini";
    string anotherVariable = "Some value"; 
}

void MethodTwo()
{
    name = "John Doe";
    //Console.WriteLine(anotherVariable);
    //Console.WriteLine(i);
    //Console.WriteLine(j);

    for (int i = 0; i < 10; i++)
    {
        var j = i + 1;
        Console.WriteLine(i);
        Console.WriteLine(j);
    }
}


MethodOne();
Console.WriteLine(name);
//Console.WriteLine(anotherVariable);
