using System;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> checker = n => n[0] == n.ToUpper()[0];
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => checker(x)).ToArray();
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }

        }
    }
}
