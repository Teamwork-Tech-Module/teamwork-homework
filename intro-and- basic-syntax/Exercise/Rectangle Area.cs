using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double rectangleArea = w * h;

            Console.WriteLine($"{rectangleArea:f2}");
        }
    }
}
