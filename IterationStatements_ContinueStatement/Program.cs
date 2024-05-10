string[] daysOfWeek = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

Console.WriteLine("Enter a day of the week");
string userInput = Console.ReadLine();


foreach (string day in daysOfWeek)
{
    if (day.Equals(userInput, StringComparison.OrdinalIgnoreCase))
    {
        continue;
    }

    Console.WriteLine(day);
}


Console.WriteLine("End of loop");
