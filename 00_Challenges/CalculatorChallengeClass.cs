using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class CalculatorChallengeClass
    {
        public double GetSum(double numOne, double numTwo)
        {
            double sumSolution = numOne + numTwo;
            return sumSolution;
        }

        public double GetSub(double num1, double num2)
        {
            double subSolution = num1 - num2;
            return subSolution;
        }

        public double GetProd(double n1, double n2)
        {
            double prodSolution = n1 * n2;
            return prodSolution;
        }

        public double GetQuot(double var1, double var2)
        {
            double quotSolution = var1 / var2;
            return quotSolution;
        }
    }
}
