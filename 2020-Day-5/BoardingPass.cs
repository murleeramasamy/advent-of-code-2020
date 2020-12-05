using System;
using System.Text.RegularExpressions;

namespace AdventOfCode._2020_Day_5
{
    class BoardingPass
    {
        private readonly string boardingPass;
        private readonly int row;
        private readonly int column;

        public BoardingPass(string boardingPass)
        {
            // Validate the boardingPass is of expected format
            if (boardingPass.Trim().Length != 10 || !new Regex("^[FB]{7}[RL]{3}$").Match(boardingPass.Trim()).Success)
            {
                throw new Exception("Invalid boarding pass");
            }

            this.boardingPass = boardingPass;
            this.row = this.GetRow(0, 0, 127);
            this.column = this.GetColumn(7, 0, 7);
        }

        public int GetSeatId()
        {
            return this.row * 8 + this.column;
        }

        private int GetRow(int index, int startRow, int endRow)
        {
            if (startRow == endRow)
            {
                return startRow;
            }

            if (this.boardingPass[index].Equals('F'))
            {
                return this.GetRow(index + 1, startRow, (startRow + endRow) / 2);
            }
            else
            {
                return this.GetRow(index + 1, ((startRow + endRow) / 2) + 1,  endRow);
            }
        }

        private int GetColumn(int index, int startColumn, int endColumn)
        {
            if (startColumn == endColumn)
            {
                return startColumn;
            }

            if (this.boardingPass[index].Equals('L'))
            {
                return this.GetColumn(index + 1, startColumn, (startColumn + endColumn) / 2);
            }
            else
            {
                return this.GetColumn(index + 1, ((startColumn + endColumn) / 2) + 1, endColumn);
            }
        }
    }
}
