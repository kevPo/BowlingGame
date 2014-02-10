using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BowlingGame.Tests
{
    [TestFixture]
    public class GameTests
    {
        private Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void GutterGame()
        {
            RollMany(20, 0);
            Assert.That(game.GetScore(), Is.EqualTo(0));
        }

        [Test]
        public void AllOnes()
        {
            RollMany(20, 1);
            Assert.That(game.GetScore(), Is.EqualTo(20));
        }

        [Test]
        public void TestOneSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(17, 0);

            Assert.That(game.GetScore(), Is.EqualTo(16));
        }

        private void RollMany(int rolls, int pins)
        {
            for (var i = 0; i < rolls; i++)
                game.Roll(pins);
        }


    }
}
