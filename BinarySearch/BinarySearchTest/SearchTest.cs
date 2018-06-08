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
        private Node SingleElementTree = new Node(0, 3, null, null);
        private Node DualElementTree = Program.CreateBinaryTree(new int[] { 3, 5 });
        private Node MultiElementTree = Program.CreateBinaryTree(new int[] { 0, 2, 5, 6, 7, 10, 12 });

        [TestMethod]
        public void SearchSingleElement()
        {
            Assert.AreEqual(0, Program.BinarySearch(SingleElementTree, 3));
        }

        [TestMethod]
        public void SearchInvalidSingleElement()
        {
            Assert.AreEqual(-1, Program.BinarySearch(SingleElementTree, 1));
        }

        [TestMethod]
        public void SearchDualElement()
        {
            Assert.AreEqual(0, Program.BinarySearch(DualElementTree, 3));
            Assert.AreEqual(1, Program.BinarySearch(DualElementTree, 5));
        }

        [TestMethod]
        public void SearchInvalidDualElement()
        {
            Assert.AreEqual(-1, Program.BinarySearch(DualElementTree, 1));
        }

        [TestMethod]
        public void SearchMultiElement()
        {
            Assert.AreEqual(0, Program.BinarySearch(MultiElementTree, 0));
            Assert.AreEqual(1, Program.BinarySearch(MultiElementTree, 2));
            Assert.AreEqual(2, Program.BinarySearch(MultiElementTree, 5));
            Assert.AreEqual(3, Program.BinarySearch(MultiElementTree, 6));
            Assert.AreEqual(4, Program.BinarySearch(MultiElementTree, 7));
            Assert.AreEqual(5, Program.BinarySearch(MultiElementTree, 10));
            Assert.AreEqual(6, Program.BinarySearch(MultiElementTree, 12));
        }

        [TestMethod]
        public void SearchInvalidMultiElement()
        {
            Assert.AreEqual(-1, Program.BinarySearch(MultiElementTree, 1));
        }
    }
}
