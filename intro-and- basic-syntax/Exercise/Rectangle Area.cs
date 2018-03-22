using System;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			//Confirmed by tterzziew
            double width = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double rectangleArea = width * h;

            Console.WriteLine($"{rectangleArea:f2}");
        }
    }
}
