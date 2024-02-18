//int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}


foreach (int element in numbers)
{
    Console.WriteLine(element);
}


string[] words = ["This", "is", "a", "foreach", "loop"];

foreach (string word in words)
{
    Console.Write(word);
    Console.Write(" ");
}