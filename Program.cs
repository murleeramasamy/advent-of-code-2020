using AdventOfCode._2020_Day_1;
using System;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 2020;
            string filePath = @"C:\Users\musomanu\source\advent-of-code-2020\2020-Day-1\ReportRepairInput.txt";
            ReportRepair reportRepair = new ReportRepair(filePath);

            var twoEntriesProduct = reportRepair.Find2EntriesProduct(sum);
            var threeEntriesProduct = reportRepair.Find3EntriesProduct(sum);

            Console.WriteLine(twoEntriesProduct);
            Console.WriteLine(threeEntriesProduct);
        }
    }
}
