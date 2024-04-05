using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Bird bird1 = new Bird()
            {
                Species = "emperor penguin",
                Color = "black and white",
                Age = 12,
                BloodTemp = "warm-blooded",
                WingSpanCentimeter = 83,
                CanFly = false,
                HasFeathers = true,
                EggColor = "white"
            };
            Bird bird2 = new Bird()
            {
                Species = "blue jay",
                Color = "blue, white, and black",
                Age = 2,
                BloodTemp = "warm-blooded",
                WingSpanCentimeter = 38,
                CanFly = true,
                HasFeathers = true,
                EggColor = "blueish with brown spots"
            };

            Bird[] birdArray = new Bird[] { bird1, bird2 };

            foreach (Bird bird in birdArray)
            {
                bird.BirdDisplay();
            }

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile1 = new Reptile()
            {
                Species = "cobra",
                Color = "dark brown",
                Age = 3,
                BloodTemp = "cold-blooded",
                NumberOfLimbs = 0,
                HasScales = true,
                Fertilization = "internal",
                Reproduction = "ovoviviparous (lay eggs)"
            };

            Reptile reptile2 = new Reptile()
            {
                Species = "viviparous lizard",
                Color = "green",
                Age = 5,
                BloodTemp = "cold-blooded",
                NumberOfLimbs = 4,
                HasScales = false,
                Fertilization = "internal",
                Reproduction = "viviparous (live birth)"
            };

            Reptile[] reptileArray = new Reptile[] { reptile1, reptile2 };

            foreach (Reptile reptile in reptileArray)
            {
                reptile.ReptileDisplay();
            }

        }
    }
}
