using NET.S._2018.Popivnenko._05;
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
        }
    }
}
