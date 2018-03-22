using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NET.S._2018.Popivnenko._05;
using NET.S._2018.Popivnenko.Polynom;

namespace NET.S._2018.Popivnenko.Polynom.Test
{
    

    [TestClass]
    public class PolynomialTest
    {

        [DataTestMethod]
        [DataRow(new double[] { 1,3,5},new double[] { 1,1,1,1},new double[] { 2,4,6,1})]
        [DataRow(new double[] { 2, 4, 6 }, new double[] { 1, 1, 1, 1 }, new double[] { 3, 5, 7, 1 })]
        [DataRow(new double[] { 1, 1, 1, 1 }, new double[] { 1, 1, 1, 1 }, new double[] { 2, 2, 2, 2 })]
        [DataRow(new double[] { 3, 5 }, new double[] { 1, 1, 1 }, new double[] { 4, 6, 1 })]
        public void Test_OperatorPlus(double[] first,double[] second,double[] result)
        {
            Polynomial firstPolynomial = new Polynomial(first);
            Polynomial secondPolynomial = new Polynomial(second);
            Polynomial actualResult = firstPolynomial + secondPolynomial;
            CollectionAssert.AreEqual(result, actualResult.GetCoefficientsAsArray());
        }

        [DataTestMethod]
        [DataRow(new double[] { 1, 3, 5 }, new double[] { 1, 1, 1, 1 }, new double[] { 0, 2, 4, -1 })]
        [DataRow(new double[] { 1, 3, 5 }, new double[] { 0, 3, 5 }, new double[] { 1, 0, 0 })]
        [DataRow(new double[] { 1, 3, 5 }, new double[] { 1, 1, 1 }, new double[] { 0, 2, 4 })]
        public void Test_OperatorMinus(double[] first, double[] second, double[] result)
        {
            Polynomial firstPolynomial = new Polynomial(first);
            Polynomial secondPolynomial = new Polynomial(second);
            Polynomial actualResult = firstPolynomial - secondPolynomial;
            CollectionAssert.AreEqual(result, actualResult.GetCoefficientsAsArray());
        }

        [DataTestMethod]
        [DataRow(new double[] { -5,1 }, new double[] { 1,4,1 }, new double[] { -5,-19,-1,1 })]
        public void Test_multiply(double[] first, double[] second, double[] result)
        {
            Polynomial firstPolynomial = new Polynomial(first);
            Polynomial secondPolynomial = new Polynomial(second);
            Polynomial actualResult = firstPolynomial - secondPolynomial;
            CollectionAssert.AreEqual(result, actualResult.GetCoefficientsAsArray());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_Null()
        {
            Polynomial polynomial = new Polynomial(null);
        }
    }
}
