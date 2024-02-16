
// Print numbers from 1 to 10
//for (int number = 1; number < 11; number++)
//{
//    Console.WriteLine(number);
//}


// Calculate and Print the Sum Of
// First N Natural Numbers
// Take the input from the user

Console.WriteLine("Please enter a number");

int number = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= number; i++)
{
    sum += i;
}

Console.WriteLine($"The total sum from 1 to {number} is {sum}");
