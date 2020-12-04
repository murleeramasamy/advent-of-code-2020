using AdventOfCode._2020_Day_1;
using AdventOfCode._2020_Day_2;
using System;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day 1
            var sum = 2020;
            string day1FilePath = @"C:\Users\musomanu\source\advent-of-code-2020\2020-Day-1\ReportRepairInput.txt";

            ReportRepair reportRepair = new ReportRepair(day1FilePath);
            var twoEntriesProduct = reportRepair.Find2EntriesProduct(sum);
            var threeEntriesProduct = reportRepair.Find3EntriesProduct(sum);

            Console.WriteLine($"Day 1: Product of 2 entries that add upto {sum}: {twoEntriesProduct}");
            Console.WriteLine($"Day 1: Product of 3 entries that add upto {sum}: {threeEntriesProduct}");

            // Day 2
            string day2FilePath = @"C:\Users\musomanu\source\advent-of-code-2020\2020-Day-2\PasswordPhilosophyInput.txt";

            PasswordPhilosophy passwordPhilosophy = new PasswordPhilosophy(day2FilePath);
            var numberOfValidPasswords = passwordPhilosophy.GetValidPasswordsCount();
            var numberOfValidPasswordsRevised = passwordPhilosophy.GetValidPasswordsCountRevised();

            Console.WriteLine($"Day 2: Number of valid passwords: {numberOfValidPasswords}");
            Console.WriteLine($"Day 2: Number of valid passwords (revised policy): {numberOfValidPasswordsRevised}");
        }
    }
}
