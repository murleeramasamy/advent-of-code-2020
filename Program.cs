using AdventOfCode._2020_Day_1;
using AdventOfCode._2020_Day_2;
using AdventOfCode._2020_Day_3;
using AdventOfCode._2020_Day_4;
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
            Console.WriteLine();

            // Day 2
            string day2FilePath = @"C:\Users\musomanu\source\advent-of-code-2020\2020-Day-2\PasswordPhilosophyInput.txt";

            PasswordPhilosophy passwordPhilosophy = new PasswordPhilosophy(day2FilePath);
            var numberOfValidPasswords = passwordPhilosophy.GetValidPasswordsCount();
            var numberOfValidPasswordsRevised = passwordPhilosophy.GetValidPasswordsCountRevised();

            Console.WriteLine($"Day 2: Number of valid passwords: {numberOfValidPasswords}");
            Console.WriteLine($"Day 2: Number of valid passwords (revised policy): {numberOfValidPasswordsRevised}");
            Console.WriteLine();

            // Day 3
            string day3FilePath = @"C:\Users\musomanu\source\advent-of-code-2020\2020-Day-3\TobogganTrajectoryInput.txt";

            TobogganTrajectory tobogganTrajectory = new TobogganTrajectory(day3FilePath);
            var numberOfTreesEncountered = tobogganTrajectory.TreesEncountered(0, 0, 3, 1);
            var numberofTreesEncountered_1 = tobogganTrajectory.TreesEncountered(0, 0, 1, 1);
            var numberofTreesEncountered_2 = tobogganTrajectory.TreesEncountered(0, 0, 3, 1);
            var numberofTreesEncountered_3 = tobogganTrajectory.TreesEncountered(0, 0, 5, 1);
            var numberofTreesEncountered_4 = tobogganTrajectory.TreesEncountered(0, 0, 7, 1);
            var numberofTreesEncountered_5 = tobogganTrajectory.TreesEncountered(0, 0, 1, 2);
            var numberofTreesEncounteredProduct = numberofTreesEncountered_1 * numberofTreesEncountered_2 * numberofTreesEncountered_3 * numberofTreesEncountered_4 * numberofTreesEncountered_5;

            Console.WriteLine($"Day 3: Number of trees encountered: {numberOfTreesEncountered}");
            Console.WriteLine($"Day 3: Number of trees encountered (all slopes product): {numberofTreesEncounteredProduct}");
            Console.WriteLine();

            // Day 4
            string day4FilePath = @"C:\Users\musomanu\source\advent-of-code-2020\2020-Day-4\PassportProcessingInput.txt";

            PassportProcessing passportProcessing = new PassportProcessing(day4FilePath);
            var numberOfValidPassports = passportProcessing.GetValidPassportsCount();
            var numberOfValidPassportsRevised = passportProcessing.GetValidPassportsCountRevised();

            Console.WriteLine($"Day 4: Number of valid passports: {numberOfValidPassports}");
            Console.WriteLine($"Day 4: Number of valid passports (revised validation): {numberOfValidPassportsRevised}");
            Console.WriteLine();
        }
    }
}
