//-----------------------------------------------------------------------
// <copyright file="Node.cs" company="Yifan Xu">
//     Node structure used in Binary Search
// </copyright>
//-----------------------------------------------------------------------
namespace BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Represents a data point in a binary tree
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Initializes a new instance of the Node class
        /// </summary>
        /// <param name="position">Indicates the position of the node if all sorted nodes were to be linearly listed</param>
        /// <param name="data">The data value that the node represents</param>
        /// <param name="leftNode">The smaller child node of this node</param>
        /// <param name="rightNode">The greater child node of this node</param>
        public Node(int position, int data, Node leftNode, Node rightNode)
        {
            this.Position = position;
            this.Data = data;
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
        }

        /// <summary>
        /// Gets or sets the position of the node if all sorted nodes in the tree were to be linearly listed
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the data value that the node represents
        /// </summary>
        public int Data { get; set; }

        /// <summary>
        /// Gets or sets the smaller child node of this node
        /// </summary>
        public Node LeftNode { get; set; }

        /// <summary>
        /// Gets or sets the greater child node of this node
        /// </summary>
        public Node RightNode { get; set; }
    }
}
