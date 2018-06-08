//-----------------------------------------------------------------------
// <copyright file="SearchTest.cs" company="Yifan Xu">
//     Tests for searching in a binary tree structure
// </copyright>
//-----------------------------------------------------------------------
namespace BinarySearchTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BinarySearch;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Tests for searching in a binary tree structure
    /// </summary>
    [TestClass]
    public class SearchTest
    {
        /// <summary>
        /// A test tree with only one element in it
        /// </summary>
        private Node singleElementTree = new Node(0, 3, null, null);

        /// <summary>
        /// A test tree with only two elements in it
        /// </summary>
        private Node dualElementTree = Program.CreateBinaryTree(new int[] { 3, 5 });

        /// <summary>
        /// A test tree with many elements in it
        /// </summary>
        private Node multiElementTree = Program.CreateBinaryTree(new int[] { 0, 2, 5, 6, 7, 10, 12 });

        /// <summary>
        /// Search the single element tree with data
        /// </summary>
        [TestMethod]
        public void SearchSingleElement()
        {
            Assert.AreEqual(0, Program.BinarySearch(this.singleElementTree, 3));
        }

        /// <summary>
        /// Search the single element tree with invalid data
        /// </summary>
        [TestMethod]
        public void SearchInvalidSingleElement()
        {
            Assert.AreEqual(-1, Program.BinarySearch(this.singleElementTree, 1));
        }

        /// <summary>
        /// Search the dual element tree with data
        /// </summary>
        [TestMethod]
        public void SearchDualElement()
        {
            Assert.AreEqual(0, Program.BinarySearch(this.dualElementTree, 3));
            Assert.AreEqual(1, Program.BinarySearch(this.dualElementTree, 5));
        }

        /// <summary>
        /// Search the dual element tree with invalid data
        /// </summary>
        [TestMethod]
        public void SearchInvalidDualElement()
        {
            Assert.AreEqual(-1, Program.BinarySearch(this.dualElementTree, 1));
        }

        /// <summary>
        /// Search the multi element tree with data
        /// </summary>
        [TestMethod]
        public void SearchMultiElement()
        {
            Assert.AreEqual(0, Program.BinarySearch(this.multiElementTree, 0));
            Assert.AreEqual(1, Program.BinarySearch(this.multiElementTree, 2));
            Assert.AreEqual(2, Program.BinarySearch(this.multiElementTree, 5));
            Assert.AreEqual(3, Program.BinarySearch(this.multiElementTree, 6));
            Assert.AreEqual(4, Program.BinarySearch(this.multiElementTree, 7));
            Assert.AreEqual(5, Program.BinarySearch(this.multiElementTree, 10));
            Assert.AreEqual(6, Program.BinarySearch(this.multiElementTree, 12));
        }

        /// <summary>
        /// Search the multi element tree with invalid data
        /// </summary>
        [TestMethod]
        public void SearchInvalidMultiElement()
        {
            Assert.AreEqual(-1, Program.BinarySearch(this.multiElementTree, 1));
        }
    }
}
