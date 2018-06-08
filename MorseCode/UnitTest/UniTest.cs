//-----------------------------------------------------------------------
// <copyright file="UniTest.cs" company="Yifan Xu">
//     UniTest of MorseCode program
// </copyright>
//-----------------------------------------------------------------------

namespace UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MorseCode;

    /// <summary>
    /// The one test class
    /// </summary>
    [TestClass]
    public class UniTest
    {
        /// <summary>
        /// When an empty string is passed through, and empty string is expected to returned.
        /// </summary>
        [TestMethod]
        public void EmptyString()
        {
            string result = Program.TranslateEnglishToMorse(string.Empty);
            Assert.AreEqual(result, string.Empty);
        }

        /// <summary>
        /// Testing single letters
        /// </summary>
        [TestMethod]
        public void SingleLetter()
        {
            Assert.AreEqual(Program.TranslateEnglishToMorse("a"), ".-");
        }

        /// <summary>
        /// Testing multiple letters. Expected 3 space between each letter of morse code
        /// </summary>
        [TestMethod]
        public void MultipleLetters()
        {
            Assert.AreEqual(Program.TranslateEnglishToMorse("ab"), ".-   -...");
        }

        /// <summary>
        /// Testing a character that is not contained in the dictionary. Exception expected
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidSymbol()
        {
            Program.TranslateEnglishToMorse("\\");
        }
        
        /// <summary>
        /// Testing null arguments. Exception expected
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NullString()
        {
            Program.TranslateEnglishToMorse(null);
        }
        
        /// <summary>
        /// Testing adding spaces between letters. 7 spaces expected between words
        /// </summary>
        [TestMethod]
        public void MultipleWords()
        {
            Assert.AreEqual(Program.TranslateEnglishToMorse("ab c"), ".-   -...       -.-.");
        }
    }
}
