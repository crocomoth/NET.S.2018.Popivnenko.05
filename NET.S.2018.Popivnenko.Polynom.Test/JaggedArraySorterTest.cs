using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.S._2018.Popivnenko._05.JaggedArraySorterProj;

namespace NET.S._2018.Popivnenko.Polynom.Test
{
    [TestClass]
    public class JaggedArraySorterTest
    {
        [TestMethod]
        public void SortByMaxNumberAscendingTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };
            int[][] resultArray = new int[3][];
            resultArray[0] = new int[] { 0, 2, 4, 6 };
            resultArray[1] = new int[] { 1, 3, 5, 7, 9 };
            resultArray[2] = new int[] { 11, 22 };
            JaggedArraySorter.SortByMaxElemInRowAscending(jaggedArray);
            for (int i=0;i<3;i++)
            {
                CollectionAssert.AreEqual(resultArray[i], jaggedArray[i]);
            }
            
        }

        [TestMethod]
        public void SortByMaxNumberDescendingTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };
            int[][] resultArray = new int[3][];
            resultArray[2] = new int[] { 0, 2, 4, 6 };
            resultArray[1] = new int[] { 1, 3, 5, 7, 9 };
            resultArray[0] = new int[] { 11, 22 };
            JaggedArraySorter.SortByMaxElemInRowDescending(jaggedArray);
            for (int i = 0; i < 3; i++)
            {
                CollectionAssert.AreEqual(resultArray[i], jaggedArray[i]);
            }
        }

        [TestMethod]
        public void SortByMinValueAscendingTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };
            int[][] resultArray = new int[3][];
            resultArray[0] = new int[] { 0, 2, 4, 6 };
            resultArray[1] = new int[] { 1, 3, 5, 7, 9 };
            resultArray[2] = new int[] { 11, 22 };
            JaggedArraySorter.SortByMinElemInRowAscending(jaggedArray);
            for (int i = 0; i < 3; i++)
            {
                CollectionAssert.AreEqual(resultArray[i], jaggedArray[i]);
            }
        }

        [TestMethod]
        public void SortByMinValueDescendingTest()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };
            int[][] resultArray = new int[3][];
            resultArray[2] = new int[] { 0, 2, 4, 6 };
            resultArray[1] = new int[] { 1, 3, 5, 7, 9 };
            resultArray[0] = new int[] { 11, 22 };
            JaggedArraySorter.SortByMinElemInRowDescending(jaggedArray);
            for (int i = 0; i < 3; i++)
            {
                CollectionAssert.AreEqual(resultArray[i], jaggedArray[i]);
            }
        }

        [TestMethod]
        public void SortByMaxRowSumTestAscending()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };
            int[][] resultArray = new int[3][];
            resultArray[0] = new int[] { 0, 2, 4, 6 };
            resultArray[1] = new int[] { 1, 3, 5, 7, 9 };
            resultArray[2] = new int[] { 11, 22 };
            JaggedArraySorter.SortBySumOfRowAscending(jaggedArray);
            for (int i = 0; i < 3; i++)
            {
                CollectionAssert.AreEqual(resultArray[i], jaggedArray[i]);
            }
        }

        [TestMethod]
        public void SortByMaxRowSumTestDescending()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };
            int[][] resultArray = new int[3][];
            resultArray[2] = new int[] { 0, 2, 4, 6 };
            resultArray[1] = new int[] { 1, 3, 5, 7, 9 };
            resultArray[0] = new int[] { 11, 22 };
            JaggedArraySorter.SortBySumOfRowDescending(jaggedArray);
            for (int i = 0; i < 3; i++)
            {
                CollectionAssert.AreEqual(resultArray[i], jaggedArray[i]);
            }
        }
    }
}
