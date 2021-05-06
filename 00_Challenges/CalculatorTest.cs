using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            CalculatorChallengeClass calc = new CalculatorChallengeClass();
            Assert.AreEqual(11, calc.GetSum(5, 6));
        }

        [TestMethod]
        public void Subtract()
        {
            CalculatorChallengeClass calc = new CalculatorChallengeClass();
            Assert.AreEqual(11, calc.GetSub(19, 8));
        }

        [TestMethod]
        public void Mult()
        {
            CalculatorChallengeClass calc = new CalculatorChallengeClass();
            Assert.AreEqual(16, calc.GetProd(4, 4));
        }

        [TestMethod]
        public void Quot()
        {
            CalculatorChallengeClass calc = new CalculatorChallengeClass();
            Assert.AreEqual(4, calc.GetQuot(16, 4));
        }
    }
}
