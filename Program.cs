using System;

namespace CSharp6
{
    class Program
    {
        string color = "red";

        static void Main(string[] args)
        {
            /*
             * OOP stands for Object-Oriented Programming.
             * 
             * Procedural programming is about writing procedures or methods that perform operations on the data, 
             * while object-oriented programming is about creating objects that contain both data and methods.
             * 
             * Object-oriented programming has several advantages over procedural programming:
             * OOP is faster and easier to execute
             * OOP provides a clear structure for the programs
             * OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
             * OOP makes it possible to create full reusable applications with less code and shorter development time
             * 
             * Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. 
             * You should extract out the codes that are common for the application, 
             * and place them at a single place and reuse them instead of repeating it.

            */

            Program carOne = new Program();
            Program carTwo = new Program();
            Console.WriteLine(carOne.color);
            Console.WriteLine(carTwo.color);



            Car_ carThree = new Car_();
            Console.WriteLine(carThree.color);
            Console.WriteLine(carThree.maxSpeed);



            // Assigning the feilds as I create the object
            Car_ carFour = new Car_();
            carFour.color2 = "purple";
            carFour.maxSpeed2 = 300;
            Console.WriteLine(carFour.color2);
            Console.WriteLine(carFour.maxSpeed2);

            // Creating multiple in the class
            Car_ Ford = new Car_();
            Ford.model = "Mustang";
            Ford.carColor = "Yellow";
            Ford.year = 2019;

            Car_ Opel = new Car_();
            Opel.model = "Astra";
            Opel.color = "White";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);

            Car_ carFive = new Car_();
            carFive.fullThrottle();     // Call a method in Car_ class


            Car_ carSix = new Car_();
            Console.WriteLine(carSix.model);

            // calling constructors in Car_ class with parameters
            Car_ carSeven = new Car_("Bettle");
            Console.WriteLine(carSeven.model);

            // calling constructors in Car_ class with multiple parameters
            Car_ carEight = new Car_("Bettle", "Pink", 90);
            Console.WriteLine("Model: " + carEight.model + ", Color: " + carEight.color + ", Year: " + carEight.year);

            // This calls a private method and will cause an error
            Car_ carNine = new Car_();
            Console.WriteLine(carSeven.model2);
        }
    }

    // GOOD WAY TO ORGANIZE CODE
    // One class for feilds and methods the other for execution

    /* If the other class doesn't work, I can put it here like this until i figure it out
        class Car_
        {
        public string color = "blue";
        }
    */



    /* Access Modifiers
     * 
     * public	    The code is accessible for all classes
     * private	    The code is only accessible within the same class
     * protected	The code is accessible within the same class, or in a class that is inherited from that class. 
     * internal	    The code is only accessible within its own assembly, but not from another assembly. 
     */

}
