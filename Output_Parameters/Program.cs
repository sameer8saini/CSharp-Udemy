namespace Output_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program programObj = new Program();
            programObj.GetSquareAndCube(5, out int squareResult, out int cubeResult);

            Console.WriteLine($"Square of 5 is {squareResult} and cube is {cubeResult}");
        }


        public void GetSquareAndCube(int number, out int square, out int cube)
        {
            square = number * number;
            cube = number * number * number;
        }

    }
}
