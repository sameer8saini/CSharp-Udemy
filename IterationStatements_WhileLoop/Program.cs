#region While Loop
//Console.WriteLine("Please input a number");

//int userInput = int.Parse(Console.ReadLine());

//int startingNumber = 0;

//while (startingNumber <= userInput)
//{
//    Console.WriteLine(startingNumber);
//    startingNumber = startingNumber + 2;
//}

//Console.WriteLine("End of program.");
#endregion

#region Infinite While Loop

int startingNumber = 0;

while (true)
{
    Console.WriteLine("Please enter a number");
    int userInput = int.Parse(Console.ReadLine());
    startingNumber += userInput;
    Console.WriteLine("Total becomes " + startingNumber);
}


#endregion