using System;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            //confirmed my maxkaft

            string nameOfChar = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {nameOfChar}");
            Console.WriteLine($"Health: {new string('|', 1)}{new string('|', currentHealth)}{new string('.', maxHealth - currentHealth)}{new string('|', 1)}");
            Console.WriteLine($"Energy: {new string('|', 1)}{ new string('|', currentEnergy)}{new string('.', maxEnergy - currentEnergy)}{new string('|', 1)}");
        }
    }
}
