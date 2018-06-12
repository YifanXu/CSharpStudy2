//-----------------------------------------------------------------------
// <copyright file="WordAppearanceTest.cs" company="Yifan Xu">
//     No copyright lol
// </copyright>
//-----------------------------------------------------------------------
namespace HomeworkTest
{
    using System;
    using Homework_6_8;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test WordAppearance function
    /// </summary>
    [TestClass]
    public class WordAppearanceTest
    {
        /// <summary>
        /// Test the function with a null string
        /// </summary>
        [TestMethod]
        public void NullString()
        {
            Assert.IsNull(Program.WordAppearance(null));
        }

        /// <summary>
        /// Test the function with an empty string
        /// </summary>
        [TestMethod]
        public void EmptyString()
        {
            Assert.AreEqual(0, Program.WordAppearance(string.Empty).Count);
        }

        /// <summary>
        /// Test the function with a null string
        /// </summary>
        [TestMethod]
        public void RegularString()
        {
            var counts = Program.WordAppearance("I wish I do not know but I do know");
            Assert.AreEqual(3, counts["i"]);
            Assert.AreEqual(2, counts["do"]);
            Assert.AreEqual(2, counts["know"]);
            Assert.AreEqual(1, counts["wish"]);
            Assert.AreEqual(1, counts["not"]);
            Assert.AreEqual(1, counts["but"]);
        }
    }
}
