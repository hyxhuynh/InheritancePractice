using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public int WingSpanCentimeter { get; set; }
        public bool CanFly { get; set;}
        public bool HasFeathers { get; set; }
        public string EggColor { get; set; }
        public void BirdDisplay()
        {
            Console.WriteLine($"This {Species} is {Age} years old and {Color} in color. It is {BloodTemp}. It has a wing size of {WingSpanCentimeter} centimeters. The egg color is {EggColor}. Other features include:" +
                $"\nCan fly: {CanFly} \nHas feathers: {HasFeathers}");
            Console.WriteLine("----------------------");

        }
    }
}
