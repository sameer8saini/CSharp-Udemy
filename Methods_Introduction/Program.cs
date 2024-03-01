namespace Methods_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call Instance Method
            Program programRef = new Program();
            programRef.PrintCurrentYear();

            // Call Static Method
            Program.PrintDate();
        }

        public void PrintCurrentYear()
        {
            DateTime currentDateTime = DateTime.Now;

            int currentYear = currentDateTime.Year;

            Console.WriteLine(currentYear);
        }

        public static void PrintDate()
        {
            DateTime dateToday = DateTime.Now;
            Console.WriteLine(dateToday);
        }
    }
}
