using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2020_Day_5
{
    class BinaryBoarding
    {
        private readonly string[] boardingPasses;
        private readonly List<int> seatIds;

        public BinaryBoarding(string filePath)
        {
            this.boardingPasses = System.IO.File.ReadAllLines(filePath);
            this.seatIds = new List<int>();

            foreach (string boardingPass in this.boardingPasses)
            {
                var seatId = new BoardingPass(boardingPass).GetSeatId();
                this.seatIds.Add(seatId);
            }

            this.seatIds.Sort();
        }

        public int GetHighestSeatId()
        {
            return this.seatIds.Last();
        }

        public int GetMySeatId()
        {
            var previousSeatId = this.seatIds[0];

            for (var currentSeatIndex = 1; currentSeatIndex < this.seatIds.Count; currentSeatIndex++)
            {
                var currentSeatId = this.seatIds[currentSeatIndex];

                if (currentSeatId != previousSeatId + 1)
                {
                    return previousSeatId + 1;
                }

                previousSeatId = currentSeatId;
            }

            throw new Exception("Cannot find my seat id.");
        }
    }
}
