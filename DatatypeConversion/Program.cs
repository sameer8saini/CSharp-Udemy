#region Implicit Conversion Example

//int integerVariable = 40;

//float floatVariable = integerVariable;

//Console.WriteLine(floatVariable);

#endregion

#region Explicit Conversion Example (Typecast operator)

//float floatVariable = 985.87F;

//int intVariable = (int)floatVariable;

//Console.WriteLine(intVariable);
#endregion

#region Explicit Conversion Example (Convert class)

//float floatVariable = 985.87F;
//float floatVariable = 222222222222222222985.87F;

//int intVariable = Convert.ToInt32(floatVariable);

//Console.WriteLine(intVariable);

#endregion

#region Explicit Conversion Example (Parse)

//string stringVariableAge = "50sghj";

//int age = int.Parse(stringVariableAge);

//Console.WriteLine(age);

#endregion

#region Explicit Conversion Example (TryParse)

string stringVariableAge = "100";

//int age = int.Parse(stringVariableAge);


bool result = int.TryParse(stringVariableAge, out int age);


if (result == true)
{
    Console.WriteLine("The conversion was successful" + age);
}
else
{
    Console.WriteLine("The conversion did not happen.");
}


#endregion