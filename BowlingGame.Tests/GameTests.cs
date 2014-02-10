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
        [Test]
        public void GutterGame()
        {
            var g = new Game();

            for (var i = 0; i < 20; i++)
                g.Roll(0);

            Assert.That(g.GetScore(), Is.EqualTo(0));
        }
    }
}
