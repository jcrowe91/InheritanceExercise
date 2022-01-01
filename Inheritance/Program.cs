using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird cardinal = new Bird();
            cardinal.CanSwim = false;
            cardinal.Name = "Cardinal";
            cardinal.Fur = false;
            cardinal.Colors = "Red";
            cardinal.NumOfLegs = 2;
            cardinal.Tail = true;

            Reptile alligator = new Reptile();
            alligator.Fur = false;
            alligator.CanSwim = true;
            alligator.Name = "Alligator";
            alligator.TeethOrFangs = "Teeth";
            alligator.Tail = true;
            alligator.NumOfLegs = 4;

            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


        }
    }
}
