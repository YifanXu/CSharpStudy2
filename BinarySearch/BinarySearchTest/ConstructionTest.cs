//-----------------------------------------------------------------------
// <copyright file="ConstructionTest.cs" company="Yifan Xu">
//     Tests for constructing a binary tree
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
    /// Tests for constructing a binary tree
    /// </summary>
    [TestClass]
    public class ConstructionTest
    {
        /// <summary>
        /// Tests constructing a binary tree from a null array
        /// </summary>
        [TestMethod]
        public void ConstructNullArray()
        {
            Assert.IsNull(Program.CreateBinaryTree(null));
        }

        /// <summary>
        /// Tests constructing a binary tree from an empty array
        /// </summary>
        [TestMethod]
        public void ConstructEmptyArray()
        {
            int[] data = new int[0];
            Assert.IsNull(Program.CreateBinaryTree(data));
        }

        /// <summary>
        /// Tests constructing a binary tree from an array of one element
        /// </summary>
        [TestMethod]
        public void ConstructSingleItem()
        {
            int[] data = new int [] { 2 };
            Node root = Program.CreateBinaryTree(data);
            Assert.AreEqual(2, root.Data);
            Assert.AreEqual(0, root.Position);
            Assert.IsNull(root.LeftNode);
            Assert.IsNull(root.RightNode);
        }

        [TestMethod]
        public void ConstructTwoItems()
        {
            int[] data = new int[] { 2, 5 };
            Node root = Program.CreateBinaryTree(data);
            Assert.AreEqual(5, root.Data);
            Assert.AreEqual(1, root.Position);
            Assert.AreEqual(2, root.LeftNode.Data);
            Assert.AreEqual(0, root.LeftNode.Position);
            Assert.IsNull(root.LeftNode.LeftNode);
            Assert.IsNull(root.LeftNode.RightNode);
            Assert.IsNull(root.RightNode);
        }

        [TestMethod]
        public void ConstructThreeItems()
        {
            int[] data = new int[] { 0, 2, 5 };
            Node root = Program.CreateBinaryTree(data);
            Assert.AreEqual(2, root.Data);
            Assert.AreEqual(1, root.Position);
            Assert.AreEqual(0, root.LeftNode.Data);
            Assert.AreEqual(0, root.LeftNode.Position);
            Assert.AreEqual(5, root.RightNode.Data);
            Assert.AreEqual(2, root.RightNode.Position);
            Assert.IsNull(root.LeftNode.LeftNode);
            Assert.IsNull(root.LeftNode.RightNode);
            Assert.IsNull(root.RightNode.LeftNode);
            Assert.IsNull(root.RightNode.RightNode);
        }
    }
}
