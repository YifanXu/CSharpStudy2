//-----------------------------------------------------------------------
// <copyright file="Extensions.cs" company="Yifan Xu">
//     Extension file for the BinarySearch
// </copyright>
//-----------------------------------------------------------------------
namespace BinarySearch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Extensions used in the Binary Search Program
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Returns part of an array in an array
        /// </summary>
        /// <param name="array">The original array</param>
        /// <param name="startingIndex">The index where the subarray starts in the original array</param>
        /// <param name="length">The length of the subarray</param>
        /// <returns>A subarray that is part of the original array</returns>
        public static int[] SubArray(this int[] array, int startingIndex, int length)
        {
            if (startingIndex < 0 || startingIndex >= array.Length || length > array.Length - startingIndex)
            {
                return null;
            }

            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = array[startingIndex + i];
            }

            return result;
        }

        /// <summary>
        /// Sort an array from small to large using the method BubbleSort
        /// </summary>
        /// <param name="array">The unsorted array</param>
        public static void BubbleSort(this int[] array)
        {
            for (int dataLeft = array.Length - 1; dataLeft > 0; dataLeft--)
            {
                for (int i = 0; i < dataLeft; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int storage = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = storage;
                    }
                }
            }
        }
    }
}
