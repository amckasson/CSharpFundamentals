using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        //Vehicles
        [TestMethod]
        public void VehiclePropertiesTests()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";
            Console.WriteLine(firstVehicle.Make);

            firstVehicle.Model = "Accord";
            firstVehicle.Mileage = 125321.4;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);            
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.IsRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.IsRunning);

            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
        }

        [TestMethod]
        public void VehicleConstructorTests()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissan";
            car.Model = "Skyline";
            car.Mileage = 50000;
            car.TypeOfVehicle = VehicleType.Car;

            Console.WriteLine(car.Make + " " + car.Model);

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy", 100000, VehicleType.Plane);
            Console.WriteLine($"I rode on a spaceship, it was the {rocket.Make}");

            rocket.Model = "Constellation";
            Console.WriteLine($"That ship is a {rocket.Model}");
            
        }

        [TestMethod]
        public void GreeterMethodsTests()
        {
            Greeter greeterInstance = new Greeter();

            greeterInstance.SayHello("Brad");

            List<string> students = new List<string>();
            students.Add("Hannah");
            students.Add("Joel");
            students.Add("Jay");
            students.Add("Andrew");

            foreach(string student in students)
            {
                greeterInstance.SayHello(student);
            }

            string greeting = greeterInstance.GetRandomGreeting();
            Console.WriteLine(greeting);
        }

        [TestMethod]
        public void CalculatorTests()
        {
            Calculator calculatorInstance = new Calculator();

            double sum = calculatorInstance.GetSum(3.5, 100.9);
            Console.WriteLine(sum);

            int age = calculatorInstance.CalculateAge(new DateTime(1990, 10, 09));
            Console.WriteLine(age);
        }

        [TestMethod]
        public void IndicatorVehicleTests()
        {
            Indicator indicator = new Indicator();
            //Cannot be set outside of class, private set
            //indicator.isFlashing = true;
            Console.WriteLine(indicator.isFlashing);
            indicator.Turnon();
            Console.WriteLine(indicator.isFlashing);
        }

        // Person
        [TestMethod]
        public void PersonTests()
        {
            Person person = new Person("Michael", "Pabody", new DateTime(2000, 01, 31));

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.FullName);
            Console.WriteLine( person.Age);

           
            //showcase of empty/blank constructors and why they can be bad.
            Person jake = new Person();
            jake.FirstName = "Jacob";
            jake.DateOfBirth = new DateTime(1991, 05, 04);
            Console.WriteLine(jake.FullName);
            Console.WriteLine(jake.Age);

            person.LastName = "Torr";
            Console.WriteLine(person.FullName);

            //This is all tech one line of code under (can tell because of ;)
            //Single statement instance of new'ing up a person
            //Orginize like this for readability
            Person andrew = new Person() 
            { 
                FirstName = "Andrew",
                LastName = "Torr",
                DateOfBirth = new DateTime (1950, 12, 25)
            };

            // Asserting with a test that these two are equal
            Assert.AreEqual("Jacob", jake.FirstName);
            //Comment out because code will fail below, as expected for an example of Assert.
            // Assert.AreNotEqual("Jacob", jake.FirstName);


        }
       
        // Within the scope of the namespace, but outside of a method
        // Field is a type of Variable / it holds some data but is in the entire class
        Person _person = new Person("Luke", "Skywalker", new DateTime(2000, 01, 31));


        [TestMethod]
        public void PersonTransportTest()
        {
            _person.Transport = new Vehicle("X-wing", "Starship", 1000, VehicleType.Plane);
            Console.WriteLine($"{_person.FullName} drives a {_person.Transport.Make}");

            _person.Transport.Make = "T16 Skyhopper";
            Console.WriteLine(_person.Transport.Make);


            //Under is another blank constructor and why it can throw code
            Person blank = new Person();
            Console.WriteLine( $"Fullname: {blank.FullName}");

            Console.WriteLine($"Unset class: {blank.Transport}");
            Console.WriteLine($"Unset struct: {blank.DateOfBirth}");
            Console.WriteLine($"Age: {blank.Age}");
        }

    }
}
