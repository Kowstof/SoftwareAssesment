using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiceSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DICE SIMULATOR");
            Console.WriteLine("--------------------");
            Console.Write("Choose amount of dice to roll: ");
            int dice = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Rolling dice...");
            Thread.Sleep(1000);
            Console.Clear();

            Random rnd = new Random();
            int total = rnd.Next(dice, dice * 6 + 1);

            Console.WriteLine($"Your {dice} dice rolled a total of {total}!");
            Console.ReadKey();
        }
    }
}
