#region Assignment Operator

//int number1 = 10;
//bool isChecked = true;

#endregion

#region Arithmetic Operators

//int number1 = 10;
//int number2 = 6;

//// +
//int result = number1 + number2;
//Console.WriteLine(result);

//// -
//int result = number2 - number1;
//Console.WriteLine(result);

//// *
//int result = number2 * number1;
//Console.WriteLine(result);

//// /
//int result2 = number1 / number2;
//Console.WriteLine(result2); // 1


//// %
//int result3 = number1 % number2;
//Console.WriteLine(result3); // 4


// ++
//int number = 1;
//Console.WriteLine(++number);


// --
//int number = 1;
//Console.WriteLine(number--);
//Console.WriteLine(number);

#endregion

#region Comparison Operators
//int number1 = 10;
//int number2 = 5;

//bool result = number1 == number2;
//Console.WriteLine(result); // False

//result = number1 != number2;
//Console.WriteLine(result); // True

//result = number1 < number2;
//Console.WriteLine(result); // False

//result = number1 > number2;
//Console.WriteLine(result); // True

//number2 = 10;
//result = number1 >= number2;
//Console.WriteLine(result); // True

//number1 = 9;
//result = number1 <= number2;
//Console.WriteLine(result); // True

#endregion

#region Conditional Logical Operators (&&  ||)

//int number1 = 10;
//int number2 = 20;

//bool result1 = number1 == 11; // False
//bool result2 = number2 == 21; // False


////bool result3 = result1 && result2;
//// Both operand have to be True for result3 to be true

//bool result3 = result1 || result2;
//// Any one of the operand have to be True for result3 to be true

//Console.WriteLine(result3);



#endregion

#region Ternary Operator

//int number1 = 10;
//int number2 = 11;

//if (number1 == number2)
//{
//    Console.WriteLine("Numbers are equal");
//}
//else
//{
//    Console.WriteLine("Numbers are not equal");
//}

//string result = number1 == number2 ? "Numbers are equal" : "Numbers are not equal";
//Console.WriteLine(result);

#endregion

#region Null Coalescing Operator

string name = "John Doe";

string result = name ?? "Sameer Saini";

Console.WriteLine(result);
#endregion