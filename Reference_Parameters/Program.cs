namespace Reference_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program programObj = new Program();

            int i = 10;
            programObj.ReferenceParametersExplained(ref i);
            Console.WriteLine($"Value of i is {i}");
        }

        public void ReferenceParametersExplained(ref int j)
        {
            j = 27;
            Console.WriteLine($"Value of j is {j}");
        }
    }
}
