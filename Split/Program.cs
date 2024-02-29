string userInput = "apple,banana,orange,,pineapple";

string tableHeader = "Id|Name|Phone|Email";


//string[] subUserInput = userInput.Split(',');

string[] subUserInput = userInput.Split(',', 100, StringSplitOptions.RemoveEmptyEntries);

foreach (string item in subUserInput)
{
    Console.WriteLine(item);
}