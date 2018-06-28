using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble;

namespace Scrabble.Tests
{
    [TestClass]
    public class ScoreTest
    {
        [TestMethod]
        public void GetLetterScores_GetsLetterScoresDictionary_Value()
        {
            Score newScore = new Score();
            int score = newScore.GetLetterScores()['a'];
            Assert.AreEqual(score, 1);
        }
    }
}
