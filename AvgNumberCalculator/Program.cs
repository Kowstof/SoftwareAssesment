using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AvgNumberCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AVERAGE CALCULATOR");
            Console.WriteLine("---------------------");
            Console.Write("Please enter your numbers, separated by spaces: ");
            string number = Console.ReadLine();
            string[] numbers = number.Split(' ');
            float sum = 0;

            foreach (string num in numbers)
            {
                sum += float.Parse(num);
            }
      
            float avg = sum / numbers.Length;

            Console.Clear();
            Console.WriteLine("Calculating...");
            Thread.Sleep(1100);
            Console.Clear();
            Console.WriteLine($"The average of your numbers is {avg}");
            Console.ReadKey();
        }
    }
}
