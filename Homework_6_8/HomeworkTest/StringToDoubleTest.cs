//-----------------------------------------------------------------------
// <copyright file="StringToDoubleTest.cs" company="Yifan Xu">
//     No copyright lol
// </copyright>
//-----------------------------------------------------------------------
namespace HomeworkTest
{
    using System;
    using Homework_6_8;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test the StringToDouble Function
    /// </summary>
    [TestClass]
    public class StringToDoubleTest
    {
        /// <summary>
        /// Test StringToDouble given an emptyString
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void EmptyString()
        {
            Program.StringToDouble(string.Empty);
        }

        /// <summary>
        /// Test StringToDouble given an spaceString
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void SpaceString()
        {
            Program.StringToDouble(" ");
        }

        /// <summary>
        /// Test StringToDouble given only a decimal point
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void DecimalPoint()
        {
            Program.StringToDouble(".");
        }

        /// <summary>
        /// Test StringToDouble given a whole number
        /// </summary>
        [TestMethod]
        public void WholeNumber()
        {
            Assert.AreEqual(1.0, Program.StringToDouble("1"));
        }

        /// <summary>
        /// Test StringToDouble given a whole number with a decimal
        /// </summary>
        [TestMethod]
        public void WholeNumberWithDecimal()
        {
            Assert.AreEqual(1.0, Program.StringToDouble("1."));
        }

        /// <summary>
        /// Test StringToDouble given a decimal
        /// </summary>
        [TestMethod]
        public void Decimal()
        {
            Assert.AreEqual(0.3, Program.StringToDouble(".3"));
        }

        /// <summary>
        /// Test StringToDouble given a mixed number
        /// </summary>
        [TestMethod]
        public void MixedNumber()
        {
            Assert.AreEqual(6.78, Program.StringToDouble("6.78"));
        }

        /// <summary>
        /// Test StringToDouble given a negative decimal
        /// </summary>
        [TestMethod]
        public void NegativeNumber()
        {
            Assert.AreEqual(-7.32, Program.StringToDouble("-7.32"));
        }
    }
}
