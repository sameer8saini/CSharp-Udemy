string[] daysOfWeek = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

Console.WriteLine("Enter a day of the week");
string userInput = Console.ReadLine();


foreach (var day in daysOfWeek)
{
    if (day.Equals(userInput, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Found the day");
        break;
    }
}

Console.WriteLine("Loop Ended");