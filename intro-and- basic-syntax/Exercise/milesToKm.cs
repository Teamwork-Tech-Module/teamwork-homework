using System;

namespace _03.Miles_to_KM
{
    class Program
    {
		Confirmed by moyseev
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", distance * 1.60934);    
        }
    }
}
