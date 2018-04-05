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
            CheckArrayForUselessValues(array);
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
            CheckArrayForUselessValues(array);
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
            CheckArrayForUselessValues(array);
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
            CheckArrayForUselessValues(array);
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
            CheckArrayForUselessValues(array);
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
            CheckArrayForUselessValues(array);
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

        /// <summary>
        /// Allows to sort jagged arrays via <see cref="IComparer"/>.
        /// Sorts arrays in ascending order by default.
        /// throws <see cref="ArgumentNullException"/> case <paramref name="array"/> or <paramref name="comparer"/> is null
        /// </summary>
        /// <param name="array">Array to be sorted.</param>
        /// <param name="comparer">Comparer which will be used to compare rows.</param>
        public static void ComparerSorter(int[][] array,IComparer<int[]> comparer)
        {
            try
            {
                CheckArrayForUselessValues(array);
            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            if (comparer == null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            int count = 0;
            foreach (int[] row in array)
            {
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (comparer.Compare(array[j + 1], array[j]) < 0)
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


        private static void CheckArrayForUselessValues(int[][] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length == 0)
            {
                throw new ArgumentException("array is empty", nameof(array));
            }
            foreach (var row in array)
            {
                if (row == null)
                {
                    throw new ArgumentNullException(nameof(array));
                }
            }
        }
        #endregion Private Helpers
    }
}
