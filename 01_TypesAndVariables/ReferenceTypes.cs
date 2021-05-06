using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Andrew";
            string lastName = "McKasson";

            //Cancatenation
            string concatenatedFullName = firstName + ' ' + lastName;
            Console.WriteLine(concatenatedFullName);

            //Compositing
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(compositeFullName);

            //Interpolation
            string interpolatedFullName = $"{firstName} \"The Goat\" {lastName} is the best...";
            Console.WriteLine(interpolatedFullName);
        }

        [TestMethod]
        public void Collections()
        {
            //Arrays
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample, "?" };

            string firstString = stringArray[0];
            Console.WriteLine(firstString);

            //Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("Hello");
            listOfIntegers.Add(23);
            listOfStrings.Add("World");
            Console.WriteLine(listOfIntegers[0]);
            Console.WriteLine(listOfStrings[1]);
            listOfStrings.Remove(listOfStrings[0]);
            Console.WriteLine(listOfStrings[0]);

            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm next");
            firstInFirstOut.Enqueue("I'm last");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            string whosFirstNow = firstInFirstOut.Peek();
            Console.WriteLine(whosFirstNow);

            //Dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(001, "EFA office");

            string badgeDoor = keyAndValue[001];

            Console.WriteLine(badgeDoor);

            //SortedLists
            //HashSets
            //Stack
        }
    }
}
