using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // DONE: Create a class Bird
    // DONE: give this class 4 members that are specific to Bird
    // DONE: Set this class to inherit from your Animal Class
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            HowManyLegs = 2;
            LandSeaAir = "Air";
            ClawsOrTalons = "Talons";
        }
        public string Name { get; set; }
        public bool CanFly { get; set; }
        public string FeatherOrNot { get; set; }
        public bool IsMeatEater { get; set; }
    }
}
