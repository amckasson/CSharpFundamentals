using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class MorningChallenge1
    {
        [TestMethod]
        public void LetsPrint()
        {
            string longWord = "Supercalifragilisticexpialiisocious";
            bool isI = true;
         
            foreach (char letter in longWord)
            {
              
                Console.WriteLine(letter);
            }
            
        }
    }
    [TestClass]

    public class MorningChallenge2
    {
        [TestMethod]
        public void ConstructorChallenge()
        {
            UserClass user = new UserClass("Andrew", "McKasson", 543534, new DateTime(1990, 09, 10));
           
            Console.WriteLine($"Users name is {user.FName} {user.LName}");
            Console.WriteLine(user.FullName);
            Console.WriteLine(user.Age);

        }
    }
    [TestClass]

    public class MorningChallenge3
    {
    }

}
