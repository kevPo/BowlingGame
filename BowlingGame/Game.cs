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
        public int CurrentRoll { get; set; }
        private List<int> Rolls;

        public Game()
        {
            Rolls = new List<int>();
        }

        public void Roll(int pins)
        {
            Rolls.Add(pins);
        }

        public int GetScore()
        {
            var score = 0;
            for (var roll = 0; roll < Rolls.Count; roll +=2)
            {
                var frameScore = Rolls[roll] + (Rolls[roll+1]);
                if (IsSpare(frameScore))
                {
                    score += frameScore + Rolls[roll + 2];
                }
                else
                {
                    score += frameScore;
                }

            }
            return score;
        }

        private bool IsSpare(int frameScore)
        {
            return frameScore == 10;
        }

    }
}
