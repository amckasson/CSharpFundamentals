using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);

                total = total + 1;
            }

            int someCount = 0;
            bool keepLooping = true;

            while (keepLooping)
            {
                 if(someCount <= 100)
                {
                    Console.WriteLine(someCount);
                    someCount++; //same as someCount = someCount + 1;
                }
                else
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 28;

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Aaron", "Alexandro", "Andrew", "Ben", "Chris" };

            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in this class");
            }

            string myName = "Andrew Joseph McKasson";

            foreach (char letter in myName)
            {
                Console.Write(letter);
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello");
                Console.WriteLine(iterator);
                iterator++;
            }
            while (iterator < 5);
        }
    }
}
