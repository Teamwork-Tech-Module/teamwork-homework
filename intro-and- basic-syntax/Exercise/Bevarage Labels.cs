using System;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args) 
        {
            string nameOfBeverage = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContentPer100 = double.Parse(Console.ReadLine());
            double sugarContentPer100 = double.Parse(Console.ReadLine());

            double energyContentTotal = (volume / 100) * energyContentPer100;
            double sugarContentTotal = (volume / 100) * sugarContentPer100;

            Console.WriteLine($"{volume}ml {nameOfBeverage}:");
            Console.WriteLine($"{energyContentTotal}kcal, {sugarContentTotal}g sugars");

        }
    }
}