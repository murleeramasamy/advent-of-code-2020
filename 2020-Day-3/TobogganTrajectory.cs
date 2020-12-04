namespace AdventOfCode._2020_Day_3
{
    class TobogganTrajectory
    {
        private readonly string[] areaMap;

        public TobogganTrajectory(string filePath)
        {
            this.areaMap = System.IO.File.ReadAllLines(filePath);
        }

        public long TreesEncountered(int startRow, int startPos, int rightPos, int downPos)
        {
            long numberOfTrees = 0;
            var maxRows = this.areaMap.Length;
            var rowLength = this.areaMap[0].Length;

            while (startRow < maxRows)
            {
                var row = this.areaMap[startRow];

                if ('#'.Equals(row[startPos]))
                {
                    numberOfTrees++;
                }

                startPos += rightPos;
                startPos %= rowLength;

                startRow += downPos;
            }

            return numberOfTrees;
        }
    }
}
