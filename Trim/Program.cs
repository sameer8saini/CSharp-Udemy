
string userInput = "   Some text here    ";
Console.WriteLine(userInput.Trim());
// "Some text here"


string userInput1 = "$$$$$   Some text here    $$$$$";
Console.WriteLine(userInput1.Trim('$'));
// "   Some text here    "


string userInput2 = "$$$$$   Some text here    $$$$$";
Console.WriteLine(userInput2.Trim('$', ' '));
// "Some text here"


string userInput3 = "$$$$$   Some text here    $$$$$";
Console.WriteLine(userInput3.TrimStart('$'));
// "   Some text here    $$$$$"

string userInput4 = "$$$$$   Some text here    $$$$$";
Console.WriteLine(userInput4.TrimEnd('$'));
// "$$$$$   Some text here    "