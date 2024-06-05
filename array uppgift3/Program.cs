using System;

namespace Inlamning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = { "Vad är huvudstaden i Sverige?", "Vad är huvudstaden i Norge?", "Vad är huvudstaden i Danmark?", "Vad är huvudstaden i Finland?" };
            string[] svar = { "Stockholm", "Oslo", "Köpenhamn", "Helsingfors" };

            Console.WriteLine("Välj en fråga (1-4):");
            int val = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine(frågor[val]);
            string användarSvar = Console.ReadLine();

            if (användarSvar.ToLower() == svar[val].ToLower())
            {
                Console.WriteLine("Rätt!");
            }
            else
            {
                Console.WriteLine("Fel!");
            }
        }
    }
}
