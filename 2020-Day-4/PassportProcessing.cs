using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode._2020_Day_4
{
    class PassportProcessing
    {
        public readonly string[] passportData;

        public PassportProcessing(string filePath)
        {
            this.passportData = System.IO.File.ReadAllLines(filePath);
        }

        public int GetValidPassportsCount()
        {
            var validPassportsCount = 0;
            var startIndex = 0;
            var endIndex = 0;

            foreach (string data in passportData)
            {
                if (data.Trim().Length == 0)
                {
                    if (new Passport(passportData, startIndex, endIndex).isValid())
                    {
                        validPassportsCount++;
                    }

                    // Once a passport data is validated, move startIndex to start of next passport data
                    startIndex = endIndex + 1;
                }

                endIndex++;
            }

            // Process the last passport data
            if (startIndex != endIndex + 1)
            {
                if (new Passport(passportData, startIndex, endIndex).isValid())
                {
                    validPassportsCount++;
                }
            }

            return validPassportsCount;
        }

        public int GetValidPassportsCountRevised()
        {
            var validPassportsCount = 0;
            var startIndex = 0;
            var endIndex = 0;

            foreach (string data in passportData)
            {
                if (data.Trim().Length == 0)
                {
                    if (new Passport(passportData, startIndex, endIndex).isValidRevised())
                    {
                        validPassportsCount++;
                    }

                    // Once a passport data is validated, move startIndex to start of next passport data
                    startIndex = endIndex + 1;
                }

                endIndex++;
            }

            // Process the last passport data
            if (startIndex != endIndex + 1)
            {
                if (new Passport(passportData, startIndex, endIndex).isValidRevised())
                {
                    validPassportsCount++;
                }
            }

            return validPassportsCount;
        }
    }
}
