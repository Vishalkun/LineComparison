namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of x1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of x2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of y1");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double length_of_line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(length_of_line);
        }
    }
}