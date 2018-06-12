//-----------------------------------------------------------------------
// <copyright file="CalculationTest.cs" company="Yifan Xu">
//     No copyright lol
// </copyright>
//-----------------------------------------------------------------------
namespace HomeworkTest
{
    using System;
    using Homework_6_8;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests for the calculation function
    /// </summary>
    [TestClass]
    public class CalculationTest
    {
        /// <summary>
        /// Test the calculation given a null string
        /// </summary>
        [TestMethod]
        public void NullString()
        {
            Assert.IsFalse(Program.Calculate(null, out double a));
        }

        /// <summary>
        /// Test the calculation given an empty string
        /// </summary>
        [TestMethod]
        public void EmptyString()
        {
            Assert.IsFalse(Program.Calculate(string.Empty, out double a));
        }

        /// <summary>
        /// Test the method given a string that is not an expression
        /// </summary>
        [TestMethod]
        public void RandomString()
        {
            Assert.IsFalse(Program.Calculate("this is not an expression", out double a));
        }

        /// <summary>
        /// Test the method given an invalid string with an operator
        /// </summary>
        [TestMethod]
        public void InvalidStringWithOperator()
        {
            Assert.IsFalse(Program.Calculate("This+Bad", out double a));
        }

        /// <summary>
        /// Test the method given an expression containing integers
        /// </summary>
        [TestMethod]
        public void IntegerExpression()
        {
            Assert.IsTrue(Program.Calculate("1+5", out double a));
            Assert.AreEqual(6.0, a);
        }

        /// <summary>
        /// Test the method given an expression containing doubles
        /// </summary>
        [TestMethod]
        public void DoubleExpression()
        {
            Assert.IsTrue(Program.Calculate("1.2+5.7", out double a));
            Assert.AreEqual(6.9, a);
        }

        /// <summary>
        /// Test the method given an expression containing hex
        /// </summary>
        [TestMethod]
        public void HexExpression()
        {
            Assert.IsTrue(Program.Calculate("0xA2+0x3C", out double a));
            Assert.AreEqual(222.0, a);
        }

        /// <summary>
        /// Test the method given an expression containing mixedExpressions
        /// </summary>
        [TestMethod]
        public void MixedExpression()
        {
            Assert.IsTrue(Program.Calculate("12.3+0xA2", out double a));
            Assert.AreEqual(174.3, a);
        }
    }
}
