//-----------------------------------------------------------------------
// <copyright file="MagicalTest.cs" company="Yifan Xu">
//     Tests for binary search algorithm
// </copyright>
//-----------------------------------------------------------------------
namespace BinarySearchTest
{
    using System;
    using BinarySearch;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests for binary search algorithm
    /// </summary>
    [TestClass]
    public class MagicalTest
    {
        /// <summary>
        /// A test array with one element
        /// </summary>
        private int[] singleElementTree = new int[] { 3 };

        /// <summary>
        /// A test array with two elements
        /// </summary>
        private int[] dualElementTree = new int[] { 3, 5 };

        /// <summary>
        /// A test array with odd number of elements
        /// </summary>
        private int[] oddElementTree = new int[] { 0, 3, 5, 6, 7, 10, 12 };

        /// <summary>
        /// A test array with even number of elements
        /// </summary>
        private int[] evenElementTree = new int[] { 0, 3, 5, 6, 7, 9, 10, 12 };

        /// <summary>
        /// Test method when given null data array
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MagicalNullArray()
        {
            Program.MagicalBinarySearch(null, 1);
        }

        /// <summary>
        /// Test method when given empty array
        /// </summary>
        [TestMethod]
        public void MagicalBinarySearch_EmptyArray()
        {
            Assert.AreEqual(-1, Program.MagicalBinarySearch(new int[0], 1));
        }
        
        /// <summary>
        /// Test method when given array with one element
        /// </summary>
        [TestMethod]
        public void MagicalBinarySearch_SingleElement_Found()
        {
            Assert.AreEqual(0, Program.MagicalBinarySearch(this.singleElementTree, 3));
        }

        /// <summary>
        /// Test method when given array with one element and invalid query
        /// </summary>
        [TestMethod]
        public void MagicalBinarySearch_SingleElement_NotFound()
        {
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.singleElementTree, 1));
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.singleElementTree, 20));
        }

        /// <summary>
        /// Test method when given array with two element
        /// </summary>
        [TestMethod]
        public void MagicalDualElement()
        {
            TestFound(2);
        }

        /// <summary>
        /// Test method when given array with two element and invalid query
        /// </summary>
        [TestMethod]
        public void MagicalInvalidDualElement()
        {
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.dualElementTree, 1));
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.dualElementTree, 4));
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.dualElementTree, 8));
        }

        /// <summary>
        /// Test method when given array with two element
        /// </summary>
        [TestMethod]
        public void MagicalOddElement()
        {
            Assert.AreEqual(0, Program.MagicalBinarySearch(this.oddElementTree, 0));
            Assert.AreEqual(1, Program.MagicalBinarySearch(this.oddElementTree, 3));
            Assert.AreEqual(2, Program.MagicalBinarySearch(this.oddElementTree, 5));
            Assert.AreEqual(3, Program.MagicalBinarySearch(this.oddElementTree, 6));
            Assert.AreEqual(4, Program.MagicalBinarySearch(this.oddElementTree, 7));
            Assert.AreEqual(5, Program.MagicalBinarySearch(this.oddElementTree, 10));
            Assert.AreEqual(6, Program.MagicalBinarySearch(this.oddElementTree, 12));
        }

        /// <summary>
        /// Test method when given array with two element and invalid query
        /// </summary>
        [TestMethod]
        public void MagicalInvalidOddElement()
        {
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.oddElementTree, 1));
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.oddElementTree, 4));
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.oddElementTree, 15));
        }

        /// <summary>
        /// Test method when given array with two element
        /// </summary>
        [TestMethod]
        public void MagicalEvenElement()
        {
            Assert.AreEqual(0, Program.MagicalBinarySearch(this.evenElementTree, 0));
            Assert.AreEqual(1, Program.MagicalBinarySearch(this.evenElementTree, 3));
            Assert.AreEqual(2, Program.MagicalBinarySearch(this.evenElementTree, 5));
            Assert.AreEqual(3, Program.MagicalBinarySearch(this.evenElementTree, 6));
            Assert.AreEqual(4, Program.MagicalBinarySearch(this.evenElementTree, 7));
            Assert.AreEqual(5, Program.MagicalBinarySearch(this.evenElementTree, 9));
            Assert.AreEqual(6, Program.MagicalBinarySearch(this.evenElementTree, 10));
            Assert.AreEqual(7, Program.MagicalBinarySearch(this.evenElementTree, 12));
        }

        /// <summary>
        /// Test method when given array with two element and invalid query
        /// </summary>
        [TestMethod]
        public void MagicalInvalidEvenElement()
        {
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.evenElementTree, 1));
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.evenElementTree, 4));
            Assert.AreEqual(-1, Program.MagicalBinarySearch(this.evenElementTree, 15));
        }

        private static void TestFound(int count)
        {
            var times = 10;
            var data = new int[count];
            for(var i=0;i<count;i++)
            {
                data[i] = i * times;
            }

            for(var i=0;i<count;i++)
            {
                Assert.AreEqual(i, Program.MagicalBinarySearch(data, i*times));
            }
        }
    }
}
