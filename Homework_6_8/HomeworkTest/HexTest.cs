//-----------------------------------------------------------------------
// <copyright file="HexTest.cs" company="Yifan Xu">
//     No copyright lol
// </copyright>
//-----------------------------------------------------------------------
namespace HomeworkTest
{
    using System;
    using Homework_6_8;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test HexToInt function
    /// </summary>
    [TestClass]
    public class HexTest
    {
        /// <summary>
        /// Test HexToInt given a null string
        /// </summary>
        [TestMethod]
        public void NullString()
        {
            Assert.IsFalse(Program.TryHexToInt(null, out int a));
        }

        /// <summary>
        /// Test HexToInt given an empty string
        /// </summary>
        [TestMethod]
        public void EmptyString()
        {
            Assert.IsFalse(Program.TryHexToInt(string.Empty, out int a));
        }

        /// <summary>
        /// Test HexToInt given an invalid string
        /// </summary>
        public void InvalidString()
        {
            Assert.IsFalse(Program.TryHexToInt("0xThisWrong", out int a));
        }

        /// <summary>
        /// Test HexToInt given 0x
        /// </summary>
        [TestMethod]
        public void ZeroXString()
        {
            Assert.IsTrue(Program.TryHexToInt("0x", out int a));
            Assert.AreEqual(0, a);
        }

        /// <summary>
        /// Test HexToInt given 0
        /// </summary>
        [TestMethod]
        public void ZeroString()
        {
            Assert.IsTrue(Program.TryHexToInt("0x0", out int a));
            Assert.AreEqual(0, a);
        }

        /// <summary>
        /// Test HexToInt given a single digit
        /// </summary>
        [TestMethod]
        public void SingleDigit()
        {
            Assert.IsTrue(Program.TryHexToInt("0xA", out int a));
            Assert.AreEqual(10, a);
        }

        /// <summary>
        /// Test HexToInt given an multiple digit
        /// </summary>
        [TestMethod]
        public void MultipleDigit()
        {
            Assert.IsTrue(Program.TryHexToInt("0x1AF2", out int a));
            Assert.AreEqual(6898, a);
        }
    }
}
