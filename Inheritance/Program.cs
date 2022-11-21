using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var eagle = new Bird();
            eagle.Name = "Eagles";
            eagle.CanFly = true;
            eagle.FeatherOrNot = "feathers";
            eagle.IsMeatEater = true;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var chameleon = new Reptile();
            chameleon.IsScaly = false; 
            chameleon.IsAsexual = false;
            chameleon.IsSwimmer = "Not a swimmer";
            chameleon.Teeth = 22;

            var myAnimal = new Animal [] {eagle, chameleon};

            foreach (var animal in myAnimal)
            {
                Console.WriteLine($"Is alive: {animal.IsAlive}");
                Console.WriteLine($"How many Legs: {animal.HowManyLegs}");
                Console.WriteLine($"Lives in: {animal.LandSeaAir}");
                Console.WriteLine($"They have: {animal.ClawsOrTalons}");
                Console.WriteLine($"");
            }
            
        }
    }
}
