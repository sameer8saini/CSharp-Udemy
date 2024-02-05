//string name = null;

//int? age = null;

//age = 27;

//age = null;

string firstName;
string lastName;

bool? hasSubscribed; // True, False, Null
hasSubscribed = null;

if (hasSubscribed.HasValue)
{
    Console.WriteLine("User has chosen a value");
}
else
{
    Console.WriteLine("User has chosen not to answer this question.");
}
