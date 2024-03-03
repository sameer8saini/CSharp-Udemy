namespace Method_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program programObj = new Program();
            double lengthOfRec1 = 10;
            double width = 5;
            double result = programObj.CalculateAreaOfRectangle(lengthOfRec1, width);

            Console.WriteLine($"Area of rectangle with length of {lengthOfRec1} and " +
                $"width of {width} is {result}");
        }


        public double CalculateAreaOfRectangle(double length, double width)
        {
            double area = length * width;
            return area;
            //  return length * width
        }


    }
}
