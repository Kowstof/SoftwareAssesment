using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WelcomeMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME");
            Console.WriteLine("------------------");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Date of Birth (dd/mm/yyyy): ");
            DateTime bday = DateTime.Parse(Console.ReadLine());
            int age = DateTime.Today.Year - bday.Year;

            Console.Clear();
            Console.WriteLine("Creating account...");
            Thread.Sleep(1500);
            Console.Clear();

            if (age < 18)
            {
                Console.WriteLine("Sorry, underage persons are not authorized to use this pogram.");
                Console.ReadKey();
            }
            else if (age >= 18 && age < 40)
            {
                Console.WriteLine($"Welcome, {name}. You seem to be in the prime of your life.");
                Console.ReadKey();
            }
            else if (age >= 40 && age < 100)
            {
                Console.WriteLine($"Good morning, {name}. Have you taken your Inner Health Plus today?");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Whoa {name}, you're {age} years old? Statistically, you should be dead. If you're not, welcome, your carriage is awaiting outside.");
                Console.ReadKey();
            }
        }
    }
}
