using System;
using System.Text.RegularExpressions;

namespace AdventOfCode._2020_Day_4
{
    class Passport
    {
        private string birthYear = null;
        private string issueYear = null;
        private string expirationYear = null;
        private string height = null;
        private string hairColor = null;
        private string eyeColor = null;
        private string passportId = null;

        // Ignore countryId
        // private string countryId = null;

        public Passport(string[] passportData, int startIndex, int endIndex)
        {
            while (startIndex != endIndex)
            {
                var data = passportData[startIndex];
                data = data.Trim();

                string[] fieldsPairs = data.Split(" ");
                
                foreach (string fieldPair in fieldsPairs)
                {
                    string[] keyValue = fieldPair.Split(":");

                    this.populateField(keyValue[0], keyValue[1]);
                }

                startIndex++;
            }
        }

        private void populateField(string key, string value)
        {
            switch (key.Trim())
            {
                case "byr":
                    this.birthYear = value;
                    break;

                case "iyr":
                    this.issueYear = value;
                    break;

                case "eyr":
                    this.expirationYear = value;
                    break;

                case "hgt":
                    this.height = value;
                    break;

                case "hcl":
                    this.hairColor = value;
                    break;

                case "ecl":
                    this.eyeColor = value;
                    break;

                case "pid":
                    this.passportId = value;
                    break;

                case "cid":
                default:
                    // Ignore them
                    break;
            }
        }

        public bool isValid()
        {
            return this.birthYear != null && this.issueYear != null && this.expirationYear != null && this.height != null
                && this.hairColor != null && this.eyeColor != null && this.passportId != null;
        }

        public bool isValidRevised()
        {
            var isValid = this.isValid();

            if (!isValid)
            {
                return false;
            }

            // byr (Birth Year) - four digits; at least 1920 and at most 2002.
            var birthYear = Int32.Parse(this.birthYear);
            isValid = isValid && this.birthYear.Trim().Length == 4 && birthYear >= 1920 && birthYear <= 2002;

            // iyr (Issue Year) - four digits; at least 2010 and at most 2020.
            var issueYear = Int32.Parse(this.issueYear);
            isValid = isValid && this.issueYear.Trim().Length == 4 && issueYear >= 2010 && issueYear <= 2020;

            // eyr (Expiration Year) - four digits; at least 2020 and at most 2030.
            var expirationYear = Int32.Parse(this.expirationYear);
            isValid = isValid && this.expirationYear.Trim().Length == 4 && expirationYear >= 2020 && expirationYear <= 2030;

            // hgt (Height) - a number followed by either cm or in:
            // If cm, the number must be at least 150 and at most 193.
            // If in, the number must be at least 59 and at most 76.
            this.height = this.height.Trim();
            if (this.height.Length < 4)
            {
                return false;
            }
            var heightNumber = Int32.Parse(this.height.Substring(0, this.height.Length - 2));
            var metric = this.height.Substring(this.height.Length - 2);
            if (metric.Equals("cm"))
            {
                isValid = isValid && heightNumber >= 150 && heightNumber <= 193;
            }
            else
            {
                isValid = isValid && heightNumber >= 59 && heightNumber <= 76;
            }

            // hcl(Hair Color) - a # followed by exactly six characters 0-9 or a-f.
            isValid = isValid && new Regex("^#([a-f0-9]){6}$").Match(this.hairColor.Trim()).Success;

            // ecl (Eye Color) - exactly one of: amb blu brn gry grn hzl oth.
            var validEyeColors = new string[] { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
            isValid = isValid && Array.IndexOf(validEyeColors, this.eyeColor.Trim()) > -1;

            // pid (Passport ID) - a nine-digit number, including leading zeroes.
            isValid = isValid && this.passportId.Trim().Length == 9 && Int32.TryParse(this.passportId, out _);

            return isValid;
        }
    }
}
