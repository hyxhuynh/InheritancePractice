using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public int NumberOfLimbs { get; set; }
        public bool HasScales { get; set; }
        public string Fertilization { get; set; } //internal
        public string Reproduction { get; set; } // ovoviviparous (lay eggs) or viviparous (live birth). 
        public void ReptileDisplay()
        {
            Console.WriteLine($"This {Species} is {Age} years old and {Color} in color. It is {BloodTemp}. Fertilization is {Fertilization} and reproduction is {Reproduction}. Other features include: \nNumber of Limbs: {NumberOfLimbs} \nHas scales: {HasScales}");
            Console.WriteLine("----------------------");

        }
    }
}
