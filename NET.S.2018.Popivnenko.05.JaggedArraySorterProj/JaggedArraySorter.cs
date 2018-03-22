using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Popivnenko._05.JaggedArraySorterProj
{
    /// <summary>
    /// Allows to sort jagged arrays in different way
    /// </summary>
    public static class JaggedArraySorter
    {
        /// <summary>
        /// Sorts rows by their max elem in descending order.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        public static void SortByMaxElemInRowDescending(int[][] array)
        {
            int count = 0;
            foreach (int[] row in array)
            {
                count++;
            }
            for (int i = 0; i < count;i++)
            {
                for (int j = 0; j< count - 1;j++)
                {
                    if (FindMaxElemInRow(array[j + 1]) > FindMaxElemInRow(array[j]) )
                    {
                        int[] tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts rows by their max elem in ascending order.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        public static void SortByMaxElemInRowAscending(int[][] array)
        {
            int count = 0;
            foreach (int[] row in array)
            {
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (FindMaxElemInRow(array[j + 1]) < FindMaxElemInRow(array[j]))
                    {
                        int[] tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts rows by their sum of elements in the row in ascending order.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        public static void SortBySumOfRowAscending(int[][] array)
        {
            int count = 0;
            foreach (int[] row in array)
            {
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (FindSumOfRow(array[j + 1]) < FindSumOfRow(array[j]))
                    {
                        int[] tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts rows by their sum of elements in descending order.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        public static void SortBySumOfRowDescending(int[][] array)
        {
            int count = 0;
            foreach (int[] row in array)
            {
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (FindSumOfRow(array[j + 1]) > FindSumOfRow(array[j]))
                    {
                        int[] tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }


        /// <summary>
        /// Sorts rows by their min elem in descending order.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        public static void SortByMinElemInRowDescending(int[][] array)
        {
            int count = 0;
            foreach (int[] row in array)
            {
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (FindMinElemInRow(array[j + 1]) > FindMinElemInRow(array[j]))
                    {
                        int[] tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts rows by their min elem in ascending order.
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        public static void SortByMinElemInRowAscending(int[][] array)
        {
            int count = 0;
            foreach (int[] row in array)
            {
                count++;
            }
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (FindMinElemInRow(array[j + 1]) < FindMinElemInRow(array[j]))
                    {
                        int[] tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
        }

        #region Private Helpers
        private static int FindMaxElemInRow(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            int result = Int32.MinValue;
            for (int i =0;i<array.Length;i++)
            {
                if (array[i] > result)
                {
                    result = array[i];
                }
            }
            return result;
        }

        private static int FindMinElemInRow(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            int result = Int32.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < result)
                {
                    result = array[i];
                }
            }
            return result;
        }

        private static int FindSumOfRow(int[] array)
        {
            if (array == null)
            {
               throw new ArgumentNullException(nameof(array));
            }
            int result = 0;
            for (int i=0;i<array.Length;i++)
            {
                result += array[i];
            }
            return result;
        }
        #endregion Private Helpers
    }
}
