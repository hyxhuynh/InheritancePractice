using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // BIRD
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

            // Display to the console
            foreach (Bird bird in birdArray)
            {
                bird.BirdDisplay();
            }

            // REPTILE
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

            // Display to the console
            foreach (Reptile reptile in reptileArray)
            {
                reptile.ReptileDisplay();
            }

        }
    }
}
