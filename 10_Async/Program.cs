using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to make a meal");
            Console.ReadKey();

            Kitchen kitchen = new Kitchen();           
            Potato potato = new Potato();

            //Synchronously peel the potato
            // cant do other stuff while peeling potato
            potato.Peel();

            //Asynchronously drop the fries
            //async so i can do other things
            var fries = kitchen.FryPotatosAsync(potato);

            //Synchronously assmeble a burger while fries are cooking
            var hamburger = kitchen.AssembleBurger();

            Console.WriteLine("Doing other stuff");

            kitchen.ServeMeal(fries.Result, hamburger);

            Console.ReadKey();

        }
    }
}
