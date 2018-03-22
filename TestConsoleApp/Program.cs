using NET.S._2018.Popivnenko._05;
using NET.S._2018.Popivnenko._05.JaggedArraySorterProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Polynomial polynomial1 = new Polynomial(new double[] { 1, 3, 5});
            Polynomial polynomial2 = new Polynomial(new double[] { 1,1,1 });
            Polynomial smth = polynomial1 - polynomial2;
            smth = new Polynomial(new double[] { 1, 3, 5 });
            string pol = smth.ToString();
            pol += "1";
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };
            JaggedArraySorter.SortByMaxElemInRowAscending(jaggedArray);
            int[][] array = new int[2][];
            array[0] = null;
            array[1] = null;
            JaggedArraySorter.SortBySumOfRowAscending(array);
            pol = smth.ToString();
        }
    }
}
