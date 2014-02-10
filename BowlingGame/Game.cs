using System;
using System.Collections.Generic;

namespace BowlingGame
{
    public class Game
    {
        private List<Int32> Rolls;

        public Game()
        {
            Rolls = new List<Int32>();
        }

        public void Roll(Int32 pins)
        {
            Rolls.Add(pins);
        }

        public Int32 GetScore()
        {
            var score = 0;
            var rollIndex = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                var strike = false;

                if (IsStrike(rollIndex))
                {
                    score += CalculateStrikeScore(rollIndex);
                    strike = true;
                }
                else if (IsSpare(rollIndex))
                    score += CalculateSpareScore(rollIndex);
                else
                    score += CalculateNonMarkingScore(rollIndex);

                if (strike)
                    rollIndex++;
                else
                    rollIndex += 2;
            }

            return score;
        }

        private bool IsStrike(Int32 rollIndex)
        {
            return Rolls[rollIndex] == 10;
        }

        private int CalculateStrikeScore(Int32 rollIndex)
        {
            return 10 + Rolls[rollIndex + 1] + Rolls[rollIndex + 2];
        }

        private bool IsSpare(Int32 rollIndex)
        {
            return Rolls[rollIndex] + Rolls[rollIndex + 1] == 10;
        }
        
        private int CalculateSpareScore(Int32 rollIndex)
        {
            return 10 + Rolls[rollIndex + 2];
        }

        private int CalculateNonMarkingScore(Int32 rollIndex)
        {
            return Rolls[rollIndex] + Rolls[rollIndex + 1];
        }
    }
}
