using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Sorry, D < 0, no decisions(");
            }
            else
                if (D == 0)
            {
                double x = (-b / (2 * a));
                Console.WriteLine("The discriminant is zero. Answer is " + x + ".");
            }
            else
            {
                double x1 = ((-b - Math.Sqrt(D)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(D)) / (2 * a));
                Console.WriteLine("Discriminant is " + D + ". The answers are " + x1 + ", " + x2);
            }
        }
    }
}
