using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Jacob";

            bool isEqual = age == 41; //the value of isEqual depends on the comparison in the ()

            bool userIsMichael = userName == "Michael";

            Console.WriteLine(isEqual);
            Console.WriteLine(userIsMichael);

            bool isNotEqual = age != 23;
            Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool isGreatThan = age > 36;
            Console.WriteLine(isGreatThan); //False

            bool isLessThan = age < 36;
            Console.WriteLine(isLessThan); //True

            bool isGreaterOrEqual = age >= 41;
            Console.WriteLine(isGreaterOrEqual); //false

            bool isTrue = true;
            bool isFalse = false;

            bool andValue = isTrue && isFalse; // False

            bool anotherAndValue = (age == 25 && userName == "Jacob"); // true
            bool orValue = (age == 25 || userName == "Michael"); // true
        }
    }
}
