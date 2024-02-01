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

//int minPopulation = int.MinValue;
//int maxPopulation = int.MaxValue;

//Console.WriteLine($"Min value is: {minPopulation}");
//Console.WriteLine($"Max value is: {maxPopulation}");

#endregion

#region Floating Types
//float float1 = 1234.123456F;
//float float2 = 1234.123456f;
//double double1 = 1234.1234567D;
//double double2 = 1234.1234567d;
//decimal decimal1 = 123456.123456978M;
//decimal decimal2 = 123456.123456978m;
#endregion

#region String Types
//// Sameer 
//string name = "Sameer";

//// Using escape character 
//// Output "Sameer"
//string nameWithQuotes = "\"Sameer\"";


//// Print a path
//// C:\qfolder\qfile.txt

//string path = "C:\\qfolder\\qfile.txt";

//// Verbatim string literals
//string path2 = @"C:\qfolder\qfile.txt";

//string multiLineMessage = """
//This is line 1
//    This is line 2
//        This is line 3
//""";

//Console.WriteLine(multiLineMessage);
#endregion


#region Value Types vs Reference Types
int x = 10; // Value Type
int y = x;  // y gets a copy of the value in x
x = 20;     // changing x does not affect y

Console.WriteLine($"x is {x}, y is {y}");
// Output x is 20, y is 10


string name1 = "Sameer Saini"; // name1 is a reference to a string object in the heap
string name2 = name1; // name 2 now references the same string object

name1 = "John Doe"; // // This creates a new string object, and str1 now references the new object

Console.WriteLine($"Name1 is {name1}, Name2 is {name2}");
//(name2 still references the original string)
#endregion
