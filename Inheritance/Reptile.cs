using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile :Animal
    {
        // DONE: Create a class Reptile
        // DONE: give this class 4 members that are specific to Reptile
        // DONE: Set this class to inherit from your Animal Class
       public Reptile()
        {
            IsAlive = true;
            HowManyLegs = 4;
            LandSeaAir = "Land";
            ClawsOrTalons = "Claws";
        }
        public bool IsScaly { get; set; }
        public bool IsAsexual    { get; set; }
        public string IsSwimmer   { get; set; }
        public int Teeth  { get; set; }
    }
}