Console.WriteLine("Multiplication Table Generator");

Console.WriteLine("Enter the starting number: ");
int startNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the ending number: ");
int endNumber = int.Parse(Console.ReadLine());

for (int i = startNumber; i <= endNumber; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Multiplication Table for {i}");
    Console.WriteLine();

    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i*j}");
    }
}