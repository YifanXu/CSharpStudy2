//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Yifan Xu">
//     No copyright lol
// </copyright>
//-----------------------------------------------------------------------
namespace GuesserTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NumberGuesser;

    /// <summary>
    /// Tests for Basic Guessing Number
    /// </summary>
    [TestClass]
    public class GuesserTest
    {
        private int AdvancedTestsCount = 0;

        /// <summary>
        /// Test the basic guess given a correct guess
        /// </summary>
        [TestMethod]
        public void CorrectGuess()
        {
            Assert.IsTrue(Program.GuessNumber(1, 1));
        }

        /// <summary>
        /// Test the basic guess given an incorrect guess
        /// </summary>
        [TestMethod]
        public void IncorrectGuess()
        {
            Assert.IsFalse(Program.GuessNumber(1, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AdvancedNullDelegate()
        {
            Program.GuessNumberAdvanced(1, null);
        }

        /// <summary>
        /// Test the advanced function given a stream succeed first try
        /// </summary>
        [TestMethod]
        public void AdvancedFirstTry()
        {
            Assert.AreEqual(1, Program.GuessNumberAdvanced(1, AdvFirstTryStream));
        }

        /// <summary>
        /// Data Stream for AdvancedFirstTry()
        /// </summary>
        /// <returns>The data fed into the steam</returns>
        public int AdvFirstTryStream()
        {
            return 1;
        }

        /// <summary>
        /// Test the advanced function given a stream succeed first try
        /// </summary>
        [TestMethod]
        public void AdvancedThirdTry()
        {
            AdvancedTestsCount = 0;
            Assert.AreEqual(3, Program.GuessNumberAdvanced(3, AdvThirdTryStream));
        }

        /// <summary>
        /// Data Stream for AdvancedThirdTry()
        /// </summary>
        /// <returns>The data fed into the steam</returns>
        public int AdvThirdTryStream()
        {
            AdvancedTestsCount++;
            return AdvancedTestsCount;
        }
    }
}
