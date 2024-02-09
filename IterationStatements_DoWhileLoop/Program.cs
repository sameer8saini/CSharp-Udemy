
int startingNumber = 1;
int product;
Console.WriteLine("Please enter a number");
int userInput = int.Parse(Console.ReadLine());

do
{
    product = startingNumber* userInput;
    Console.WriteLine($"{userInput} * {startingNumber} = {product}");
    startingNumber += 1;
}
while (false);

