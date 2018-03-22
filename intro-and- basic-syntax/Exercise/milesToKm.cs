using System;

namespace _03.Miles_to_KM
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", km * 1.60934);    
        }
    }
}
