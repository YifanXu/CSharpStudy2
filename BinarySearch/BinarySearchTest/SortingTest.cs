//-----------------------------------------------------------------------
// <copyright file="SortingTest.cs" company="Yifan Xu">
//     Tests for the sorting part of the program
// </copyright>
//-----------------------------------------------------------------------
namespace BinarySearchTest
{
    using System;
    using BinarySearch;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests for the sorting part of the program
    /// </summary>
    [TestClass]
    public class SortingTest
    {
        /// <summary>
        /// Test the method with a null array
        /// </summary>
        [TestMethod]
        public void SortingEmptyArray()
        {
            int[] array = new int[0];
            array.BubbleSort();
            Assert.IsTrue(array.Length == 0);
        }

        /// <summary>
        /// Check when there is only 1 item in array
        /// </summary>
        [TestMethod]
        public void SortingOneItemArray()
        {
            int[] original = new int[] { 3 };
            original.BubbleSort();
            Assert.AreEqual(original.Length, 1);
            Assert.AreEqual(original[0], 3);
        }

        /// <summary>
        /// Check when the array is sorted but ran through the method anyways
        /// </summary>
        [TestMethod]
        public void SortingAlreadySortedArray()
        {
            int[] expected = new int[] { 1, 2, 3, 5 };
            int[] sorted = new int[] { 1, 2, 3, 5 };
            sorted.BubbleSort();
            Assert.IsTrue(this.CompareArrayContent(sorted, expected));
        }

        /// <summary>
        /// Check when given a completely inverted array
        /// </summary>
        [TestMethod]
        public void SortingInvertlySortedArray()
        {
            int[] sorted = new int[] { 5, 4, 2, 1, 0 };
            sorted.BubbleSort();
            int[] expected = new int[] { 0, 1, 2, 4, 5 };
            Assert.IsTrue(this.CompareArrayContent(sorted, expected));
        }

        /// <summary>
        /// Check when given a array with duplicated elements
        /// </summary>
        [TestMethod]
        public void SortingDuplicateElements()
        {
            int[] sorted = new int[] { 4, 5, 2, 3, 2, 0 };
            sorted.BubbleSort();
            int[] expected = new int[] { 0, 2, 2, 3, 4, 5 };
            Assert.IsTrue(this.CompareArrayContent(sorted, expected));
        }

        /// <summary>
        /// Compare two arrays to see if two array have equal content
        /// </summary>
        /// <param name="arrayA">A array in comparison</param>
        /// <param name="arrayB">B array in comparison</param>
        /// <returns>If the two arrays have the same content</returns>
        private bool CompareArrayContent(int[] arrayA, int[] arrayB)
        {
            if (object.ReferenceEquals(arrayA, arrayB))
            {
                return true;
            }

            if (arrayA == null || arrayB == null)
            {
                if (arrayA == null && arrayB == null)
                {
                    return true;
                }

                return false;
            }

            if (arrayA.Length != arrayB.Length)
            {
                return false;
            }

            for (int i = 0; i < arrayA.Length; i++)
            {
                if (arrayA[i] != arrayB[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
