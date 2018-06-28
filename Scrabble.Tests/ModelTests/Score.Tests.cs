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
            int score = newScore.GetLetterScores()['z'];
            Assert.AreEqual(score, 10);
        }

        [TestMethod]
        public void GetSetInputtedWord_GetsSetsInputtedWord_True()
        {
            Score newScore = new Score();
            string test = "Hello";
            newScore.SetInputtedWord(test);
            Assert.AreEqual(test, newScore.GetInputtedWord());
        }

        [TestMethod]
        public void GetSetInputtedWordLetters_GetsSetsInputtedWordLetters_True()
        {
            Score newScore = new Score();
            char[] test = {'a', 'b', 'c'};
            newScore.SetInputtedWordLetters(test);
            Assert.AreEqual(test, newScore.GetInputtedWordLetters());
        }

        [TestMethod]
        public void WordIntoLetters_TurnsWordIntoWordLetters_True()
        {
            Score newScore = new Score();
            string kevin = "kevin";
            newScore.SetInputtedWord(kevin);
            newScore.WordIntoLetters();
            CollectionAssert.AreEqual(kevin.ToCharArray(), newScore.GetInputtedWordLetters());
        }


    }
}
