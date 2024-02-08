

#region If statements

//Console.WriteLine("Start of program");

//Console.WriteLine("Please enter a number");

//int number = int.Parse(Console.ReadLine());


//if (number > 0)
//{
//    Console.WriteLine("The number is positive.");
//}

//Console.WriteLine("End of program.");
#endregion

#region If Else

//Console.WriteLine("Start of program");

//Console.WriteLine("Please enter a number");

//int number = int.Parse(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("The number is positive.");
//}
//else
//{
//    Console.WriteLine("This is not a positive number.");
//}

//Console.WriteLine("End of program.");

#endregion

#region Else If

//Console.WriteLine("Start of program");

//Console.WriteLine("Please enter a number");

//int number = int.Parse(Console.ReadLine());

//if (number > 0)
//{
//    Console.WriteLine("The number is positive.");
//}
//else if (number < 0)
//{
//    Console.WriteLine("This is not a positive number.");
//}
//else
//{
//    Console.WriteLine("This number is 0");
//}

//Console.WriteLine("End of program.");
#endregion

#region Logical AND
//Console.WriteLine("Please enter first name");
//string firstName = Console.ReadLine();

//Console.WriteLine("Please enter last name");
//string lastName = Console.ReadLine();

//if (firstName ==  "John" && lastName == "Doe")
//{
//    Console.WriteLine("The full name is John Doe");
//}

//Console.WriteLine("End of program");

#endregion

#region Logical OR

//Console.WriteLine("Please enter a name");
//string name = Console.ReadLine();

//if (name == "John" || name == "Jacob")
//{
//    Console.WriteLine("The name is either John or Jacob");
//}

//Console.WriteLine("End of program");

#endregion

#region Switch Case

Console.WriteLine("Please enter a day of week");
int dayOfWeek = int.Parse(Console.ReadLine());


//if (dayOfWeek == 1)
//{
//    Console.WriteLine("Monday");
//}
//else if (dayOfWeek == 2)
//{
//    Console.WriteLine("Tuesday");
//}
//else if (dayOfWeek == 3)
//{
//    Console.WriteLine("Wednesday");
//}
//else if (dayOfWeek == 4)
//{
//    Console.WriteLine("Thursday");
//}
//else if (dayOfWeek == 5)
//{
//    Console.WriteLine("Friday");
//}
//else if (dayOfWeek == 6)
//{
//    Console.WriteLine("Saturday");
//}
//else if (dayOfWeek == 7)
//{
//    Console.WriteLine("Sunday");
//}
//else
//{
//    Console.WriteLine("Not a valid day of week");
//}


switch (dayOfWeek)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Weekday");
        break;
    case 6:
    case 7:
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("Not a valid day of week");
        break;
}



#endregion