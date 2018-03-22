using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Popivnenko._05
{
    public class Polynomial
    {
        private double[] coefficients;

        public Polynomial(double[] coefficients)
        {

            this.coefficients = coefficients ?? throw new ArgumentNullException(nameof(coefficients));
            if (this.coefficients.Length == 0)
            {
                throw new ArgumentException("array was empty", nameof(coefficients));
            }
            this.coefficients.Reverse();
        }

        public static Polynomial operator +(Polynomial left,Polynomial  right)
        {
            return Sum(left, right);
        }

        public static Polynomial operator -(Polynomial left,Polynomial right)
        {
            return Sub(left, right);
        }

        public static Polynomial operator *(Polynomial left,Polynomial right)
        {
            return Multiply(left, right);
        }

        public static bool operator ==(Polynomial left, Polynomial right)
        {
            return AreEven(left, right);
        }

        public static bool operator !=(Polynomial left, Polynomial right)
        {
            return !AreEven(left, right);
        }

        private static bool AreEven(Polynomial left,Polynomial right)
        {
            if (left.coefficients.Length != right.coefficients.Length)
            {
                return false;
            }
            for (int i = 0;i < left.coefficients.Length - 1;i++)
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

            for (int i = 0;i < smallerArray.Length - 1; i++)
            {
                for (int j = 0;i < biggerArray.Length - 1; j++)
                {
                    resultArray[i + j] += smallerArray[i] * biggerArray[j];
                }
            }


            resultArray.Reverse();
            return new Polynomial(resultArray);
        }

        private static Polynomial Sub(Polynomial left, Polynomial right)
        {
            double[] smallerArray = FindSmallerArray(left.coefficients, right.coefficients);
            double[] biggerArray = FindBiggerArray(left.coefficients, right.coefficients);


            double[] resultArray = new double[biggerArray.Length - 1];

            for (int i = 0; i < smallerArray.Length - 1; i++)
            {
                resultArray[i] = smallerArray[i] - biggerArray[i];
                if (smallerArray.Equals(right.coefficients))
                {
                    resultArray[i] = -resultArray[i];
                }
            }
            for (int i = smallerArray.Length; i < biggerArray.Length - 1; i++)
            {
                resultArray[i] = biggerArray[i];
                if (biggerArray.Equals(right.coefficients))
                {
                    resultArray[i] = -biggerArray[i];
                }
            }
            resultArray.Reverse();
            return new Polynomial(resultArray);
        }

        private static Polynomial Sum(Polynomial left, Polynomial right)
        {
            double[] smallerArray = FindSmallerArray(left.coefficients,right.coefficients);
            double[] biggerArray = FindBiggerArray(left.coefficients,right.coefficients);
            

            double[] resultArray = new double[biggerArray.Length-1];

            for (int i=0;i<smallerArray.Length - 1;i++)
            {
                resultArray[i] = smallerArray[i] + biggerArray[i];
            }
            for (int i = smallerArray.Length;i<biggerArray.Length -1;i++)
            {
                resultArray[i] = biggerArray[i];
            }
            resultArray.Reverse();
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
    }
}
