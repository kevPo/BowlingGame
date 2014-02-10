using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        public int Score { get; set; }
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
            for (var rollIndex = 0; rollIndex < Rolls.Count;)
            {
                if (IsStrike(Rolls[rollIndex]))
                {
                    score += GetFrameScore(rollIndex) + (Rolls[rollIndex + 2]);
                    rollIndex++;
                }
                else
                {
                    var frameScore = GetFrameScore(rollIndex);

                    if (IsSpare(frameScore))
                        score += frameScore + Rolls[rollIndex + 2];
                    else
                        score += frameScore;

                    rollIndex+=2;
                }
            }

            return score;
        }

        private int GetFrameScore(int rollIndex)
        {
            return Rolls[rollIndex] + (Rolls[rollIndex + 1]);
        }

        private bool IsStrike(Int32 roll)
        {
            return roll == 10;
        }

        private bool IsSpare(Int32 frameScore)
        {
            return frameScore == 10;
        }

    }
}
