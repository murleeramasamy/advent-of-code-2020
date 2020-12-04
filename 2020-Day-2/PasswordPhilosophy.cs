namespace AdventOfCode._2020_Day_2
{
    public class PasswordPhilosophy
    {
        private readonly string[] passwords;

        public PasswordPhilosophy(string filePath)
        {
            this.passwords = System.IO.File.ReadAllLines(filePath);
        }

        public int GetValidPasswordsCount()
        {
            int validPasswordCount = 0;
           
            foreach (string password in passwords)
            {
                if (new PasswordEntry(password).isValid())
                {
                    validPasswordCount++;
                }
            }

            return validPasswordCount;
        }

        public int GetValidPasswordsCountRevised()
        {
            int validPasswordCount = 0;

            foreach (string password in passwords)
            {
                if (new PasswordEntry(password).isValidRevised())
                {
                    validPasswordCount++;
                }
            }

            return validPasswordCount;
        }
    }
}
