using System;
namespace CSharp6
{
    public class Car_
    {
        // These fields and methods are called class members

        public string color = "blue";   // feild
        public int maxSpeed = 200;      // feild

        public string color2;           // feild
        public int maxSpeed2;           // feild


        public void fullThrottle()      // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        public string model;
        public string carColor;
        public int year;

        // Constructor: special method that is used to initialize and object
        public Car_()
        {
            model = "Mustang"; // Set the initial value of the Model
        }

        // Constructor with parameters
        public Car_(string modelName)
        {
            model = modelName;
        }

        // Constructor with multiple parameters
        public Car_(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        // Private Modifier
        private string model2 = "Mustang";


    }
}
