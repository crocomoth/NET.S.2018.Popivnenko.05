using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Popivnenko._05
{
    /// <summary>
    /// Allows basic functionality of working with polynomials.
    /// </summary>
    public class Polynomial
    {
        private double[] coefficients;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="coefficients">Coefficients of polynomial starting from lowest power of variable.</param>
        public Polynomial(double[] coefficients)
        {

            this.coefficients = coefficients ?? throw new ArgumentNullException(nameof(coefficients));
            if (this.coefficients.Length == 0)
            {
                throw new ArgumentException("array was empty", nameof(coefficients));
            }
            
        }

        /// <summary>
        /// Overriden operator +.
        /// </summary>
        /// <param name="left">Polynomial which is left to +.</param>
        /// <param name="right">Polynomial which is right to +.</param>
        /// <returns>Sum of polynomials corresponding to basic math.</returns>
        public static Polynomial operator +(Polynomial left,Polynomial  right)
        {
            return Sum(left, right);
        }

        /// <summary>
        /// Overriden operator -.
        /// </summary>
        /// <param name="left">Polynomial which is left to -.</param>
        /// <param name="right">Polynomial which is right to -.</param>
        /// <returns>Substraction of polynomials corresponding to basic math.</returns>
        public static Polynomial operator -(Polynomial left,Polynomial right)
        {
            return Sub(left, right);
        }

        /// <summary>
        /// Overriden operator *.
        /// </summary>
        /// <param name="left">Polynomial which is left to *.</param>
        /// <param name="right">Polynomial which is right to *.</param>
        /// <returns>Multiplication of polynomials corresponding to basic math.</returns>
        public static Polynomial operator *(Polynomial left,Polynomial right)
        {
            return Multiply(left, right);
        }

        /// <summary>
        /// Checks are polynomials even.
        /// </summary>
        /// <param name="left">Polynomial which is left to ==.</param>
        /// <param name="right">Polynomial which is right to ==.</param>
        /// <returns>True if they are even, false otherwise.</returns>
        public static bool operator ==(Polynomial left, Polynomial right)
        {
            return AreEven(left, right);
        }

        /// <summary>
        /// Checks are polynoms not even.
        /// </summary>
        /// <param name="left">Polynomial which is left to !=.</param>
        /// <param name="right">Polynomial which is right to !=.</param>
        /// <returns>True if they are not even, false otherwise.</returns>
        public static bool operator !=(Polynomial left, Polynomial right)
        {
            return !AreEven(left, right);
        }

        /// <summary>
        /// Getter of an coefficients array.
        /// </summary>
        /// <returns>Coefficients as double array.</returns>
        public double[] GetCoefficientsAsArray()
        {
            double[] result = this.coefficients;
            
            return result;
        }


        #region Private Methods
        private static bool AreEven(Polynomial left,Polynomial right)
        {
            if (left.coefficients.Length != right.coefficients.Length)
            {
                return false;
            }
            for (int i = 0;i < left.coefficients.Length;i++)
            {
                if (left.coefficients[i] != right.coefficients[i])
                {
                    return false;
                }
            }
            return true;
        }

        private static Polynomial Multiply(Polynomial left,Polynomial right)
        {
            double[] smallerArray = FindSmallerArray(left.coefficients, right.coefficients);
            double[] biggerArray = FindBiggerArray(left.coefficients, right.coefficients);


            double[] resultArray = new double[biggerArray.Length + smallerArray.Length - 1];

            for (int i = 0;i < smallerArray.Length; i++)
            {
                for (int j = 0;j < biggerArray.Length; j++)
                {
                    resultArray[i + j] += smallerArray[i] * biggerArray[j];
                }
            }


            
            return new Polynomial(resultArray);
        }

        private static Polynomial Sub(Polynomial left, Polynomial right)
        {
            double[] smallerArray = FindSmallerArray(left.coefficients, right.coefficients);
            double[] biggerArray = FindBiggerArray(left.coefficients, right.coefficients);


            double[] resultArray = new double[biggerArray.Length];

            for (int i = 0; i < smallerArray.Length; i++)
            {
                resultArray[i] = smallerArray[i] - biggerArray[i];
                if (smallerArray.Equals(right.coefficients))
                {
                    resultArray[i] = -resultArray[i];
                }
            }
            for (int i = smallerArray.Length; i < biggerArray.Length; i++)
            {
                resultArray[i] = biggerArray[i];
                if (biggerArray.Equals(right.coefficients))
                {
                    resultArray[i] = -biggerArray[i];
                }
            }
            
            return new Polynomial(resultArray);
        }

        private static Polynomial Sum(Polynomial left, Polynomial right)
        {
            double[] smallerArray = FindSmallerArray(left.coefficients,right.coefficients);
            double[] biggerArray = FindBiggerArray(left.coefficients,right.coefficients);
            

            double[] resultArray = new double[biggerArray.Length];

            for (int i=0;i<smallerArray.Length;i++)
            {
                resultArray[i] = smallerArray[i] + biggerArray[i];
            }
            for (int i = smallerArray.Length;i<biggerArray.Length;i++)
            {
                resultArray[i] = biggerArray[i];
            }
            
            return new Polynomial(resultArray);
        }

        private static double[] FindSmallerArray(double[] first,double[] second)
        {
            if (first.Length <= second.Length)
            {
                return first;
            }
            return second;
        }

        private static double[] FindBiggerArray(double[] first,double[] second)
        {
            if (first.Length <= second.Length)
            {
                return second;
            }
            return first;
        }
        #endregion Private Methods

        #region Overrides

        /// <summary>
        /// Returns polynomial in classic form.
        /// </summary>
        /// <returns>String that represents Polynomial.</returns>
        public override string ToString()
        {
            string result = String.Empty;
            for (int i = coefficients.Length - 1;i > 0;i--)
            {
                if (coefficients[i] >= 0)
                {
                    result += "+";
                }
                result += coefficients[i].ToString();
                result += "x^" + i.ToString();
            }
            if (coefficients[0] >= 0)
            {
                result += "+";
            }
            result += coefficients[0];
            return result;
        }

        /// <summary>
        /// Checks are two polynomials equal.
        /// </summary>
        /// <param name="obj">Object to be checked.</param>
        /// <returns>True if they are equal, false otherwise.</returns>
        public override bool Equals(object obj)
        {
            var polynom = obj as Polynomial;
            if (polynom != null)
            {
                return AreEven(this, polynom);
            }
            return false;
            
        }

        /// <summary>
        /// Returns hash code of an object.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion Overrides
    }
}
