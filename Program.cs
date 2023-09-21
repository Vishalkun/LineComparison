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

            Console.WriteLine("enter the value of y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double length_of_line_1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(length_of_line_1);

            Console.WriteLine("enter the value of a1");
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of a2");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of b1");
            double b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of b2");
            double b2 = Convert.ToDouble(Console.ReadLine());

            double length_of_line_2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine(length_of_line_2);

            Console.WriteLine(length_of_line_2 == length_of_line_1);

            if (length_of_line_1 > length_of_line_2)
            {
                Console.WriteLine("line 1 is greater then line 2");
            }
            else if (length_of_line_1 < length_of_line_2)
            {
                Console.WriteLine("line 2 is greater then line 1");
            }
            else
            {
                Console.WriteLine("two lines are equal");
            }




        }
    }
}