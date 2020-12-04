using System;

namespace AdventOfCode._2020_Day_2
{
    class PasswordEntry
    {
        private readonly int minRange;
        private readonly int maxRange;
        private readonly char policyChar;
        private string password;

        public PasswordEntry(string passwordEntry)
        {
            // TODO: Add checks to make sure the passwords are of expected format
            string[] policyAndPassword = passwordEntry.Split(":");
            string[] rangeAndChar = policyAndPassword[0].Split(" ");
            string[] ranges = rangeAndChar[0].Split("-");

            this.password = policyAndPassword[1].Trim();
            this.policyChar = rangeAndChar[1][0];
            this.minRange = Int32.Parse(ranges[0]);
            this.maxRange = Int32.Parse(ranges[1]);
        }

        public bool isValid()
        {
            var count = this.password.Split(this.policyChar).Length - 1;

            return this.minRange <= count && count <= this.maxRange;
        }

        public bool isValidRevised()
        {
            var minCharPolicy = this.policyChar.Equals(this.password[this.minRange - 1]);
            var maxCharPolicy = this.policyChar.Equals(this.password[this.maxRange - 1]);

            // Exactly one condition should be true
            return minCharPolicy != maxCharPolicy;
        }
    }
}
