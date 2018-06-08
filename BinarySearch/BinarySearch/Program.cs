//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Yifan Xu">
//     Main part of the program with all the flashy algorithms.
// </copyright>
//-----------------------------------------------------------------------
namespace BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Main Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main Class
        /// </summary>
        /// <param name="args">Build arguments (unused)</param>
        public static void Main(string[] args)
        {
            Console.ReadLine();
        }

        /// <summary>
        /// Binary Search for a position of a number given. -1 if unknown
        /// </summary>
        /// <param name="array">Array of numbers to search in</param>
        /// <param name="number">The number that is being searched for</param>
        /// <returns>One of the positions of the queried number. -1 if the number is not included in the array</returns>
        public static int BinarySearch(int[] array, int number)
        {
            array.BubbleSort();
            var root = CreateBinaryTree(array);
            return BinarySearch(root, number);
        }

        /// <summary>
        /// Binary Search for a position of a number given. -1 if unknown
        /// </summary>
        /// <param name="root">Root of the binary tree</param>
        /// <param name="number">Number that is queried for</param>
        /// <returns>One of the positions of the queried number. -1 if the number is not included in the tree</returns>
        public static int BinarySearch(Node root, int number)
        {
            if (root == null)
            {
                return -1;
            }

            if (root.Data == number)
            {
                return root.Position;
            }

            if (root.Data < number)
            {
                return BinarySearch(root.RightNode, number);
            }

            return BinarySearch(root.LeftNode, number);
        }

        /// <summary>
        /// Create a binary tree given a sorted array of data
        /// </summary>
        /// <param name="data">Sorted Data that will be contained in the binary tree</param>
        /// <returns>The root of a constructed binary tree</returns>
        public static Node CreateBinaryTree(int[] data)
        {
            return CreateBinaryTree(0, data);
        }

        /// <summary>
        /// Create a binary tree given a sorted array of data and the shift in position. Used in recursion internally
        /// </summary>
        /// <param name="startingIndex">A arithmetic translation of all positions created in the binary tree</param>
        /// <param name="data">Sorted data that will be contained in the binary tree</param>
        /// <returns>The root of a constructed binary tree</returns>
        public  static Node CreateBinaryTree(int startingIndex, int[] data)
        {
            if (data == null || data.Length == 0)
            {
                return null;
            }

            int middle = data.Length / 2;
            return new Node(startingIndex + middle, data[middle], CreateBinaryTree(startingIndex, data.SubArray(0, middle)), CreateBinaryTree(startingIndex + middle + 1, data.SubArray(middle + 1, (data.Length - 1) / 2)));
        }
    }
}
