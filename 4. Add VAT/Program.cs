using System;
using System.Linq;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split(", ").Select(decimal.Parse).ToArray();
            numbers = numbers.Select(x => x = x * 1.2m).ToArray();
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:F2}");
            }
        }
    }
}
