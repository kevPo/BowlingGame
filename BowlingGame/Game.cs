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

        public void Roll(int pins)
        {
            Score += pins;
        }

        public int GetScore()
        {
            return Score;
        }

    }
}
