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
            string test = "hello";
            newScore.SetInputtedWord(test);
            Assert.AreEqual(test, newScore.GetInputtedWord());
        }

        [TestMethod]
        public void GetSetFinalScore_GetsSetsFinalScore_True()
        {
            Score newScore = new Score();
            int test = 5;
            newScore.SetFinalScore(test);
            Assert.AreEqual(test, newScore.GetFinalScore());
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

        [TestMethod]
        public void LettersIntoPoints_TurnsLettersIntoPoints_True()
        {
            Score newScore = new Score();
            char[] test = {'a', 'b', 'c'};
            newScore.SetInputtedWordLetters(test);
            newScore.LettersIntoPoints();
            Assert.AreEqual(7, newScore.GetFinalScore());
        }

        [TestMethod]
        public void WordIntoPoints_TurnsWordIntoPoints_True()
        {
            Score newScore = new Score();
            string test = "chicken";
            newScore.SetInputtedWord(test);
            newScore.WordIntoLetters();
            newScore.LettersIntoPoints();
            Assert.AreEqual(18, newScore.GetFinalScore());
        }

        [TestMethod]
        public void WordsIntoPoints_TurnsWordsIntoPoints_True()
        {
            Score newScore = new Score();
            string test = "chicken chicken";
            newScore.SetInputtedWord(test);
            newScore.WordIntoLetters();
            newScore.LettersIntoPoints();
            Assert.AreEqual(36, newScore.GetFinalScore());
        }

        [TestMethod]
        public void CapitalWordIntoPoints_TurnsCapitalWordIntoPoints_True()
        {
            Score newScore = new Score();
            string test = "Chicken";
            newScore.SetInputtedWord(test);
            newScore.WordIntoLetters();
            newScore.LettersIntoPoints();
            Assert.AreEqual(18, newScore.GetFinalScore());
        }
    }
}
