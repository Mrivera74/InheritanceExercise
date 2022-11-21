using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Animal
    // give this class 4 members that all Animals have in common
    public class Animal
    {

        public Animal()
        {

        }
        public bool IsAlive  { get; set; }    
        public int HowManyLegs { get; set; } 
        public string LandSeaAir { get; set; }
        public string ClawsOrTalons { get; set; }
    }  
}
