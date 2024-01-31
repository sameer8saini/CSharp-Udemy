#region Boolean Type
//bool isFormComplete = true;
//bool isFormComplete = false;


//bool isFormComplete = default;

//The below will give a compiler error as 
//a declared boolean variable cannot be assigned a string value
//isFormComplete = "123";

//Console.WriteLine(isFormComplete);
#endregion

#region Integral Types

int minPopulation = int.MinValue;
int maxPopulation = int.MaxValue;

Console.WriteLine($"Min value is: {minPopulation}");
Console.WriteLine($"Max value is: {maxPopulation}");

#endregion

#region Floating Types
float float1 = 1234.123456F;
float float2 = 1234.123456f;
double double1 = 1234.1234567D;
double double2 = 1234.1234567d;
decimal decimal1 = 123456.123456978M;
decimal decimal2 = 123456.123456978m;
#endregion