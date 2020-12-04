using System;
using System.Collections.Generic;

namespace AdventOfCode._2020_Day_1
{
    public class ReportRepair
    {
        private readonly HashSet<int> reportedNumbers;

        public ReportRepair(string filePath)
        {
            this.reportedNumbers = new HashSet<int>();
            this.readInput(filePath);
        }

        private void readInput(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                int number = Int32.Parse(line);

                this.reportedNumbers.Add(number);
            }
        }

        public int Find2EntriesProduct(int sum)
        {
           try
            {
                var (firstNumber, secondNumber) = this.FindEntriesThatAddupToSum(sum);

                return firstNumber * secondNumber;
            }
            catch
            {
                return 0;
            }
        }

        private (int firstNumber, int secondNumber) FindEntriesThatAddupToSum(int sum)
        {
            foreach (int number in this.reportedNumbers)
            {
                int difference = sum - number;

                if (this.reportedNumbers.Contains(difference))
                {
                    return (number, difference);
                }
            }

            throw new Exception($"Cannot find 2 entries that add upto {sum}");
        }

        public int Find3EntriesProduct(int sum)
        {
            foreach (int firstNumber in this.reportedNumbers)
            {
                int difference = sum - firstNumber;

                try
                {
                    var (secondNumber, thirdNumber) = this.FindEntriesThatAddupToSum(difference);

                    return firstNumber * secondNumber * thirdNumber;
                }
                catch
                {
                    // do nothing, just try next number
                }
            }

            throw new Exception($"Cannot find 3 entries that add upto {sum}");
        }
    }
}
