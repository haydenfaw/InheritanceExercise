using System;
using System.Collections.Generic;
using System.Text;

// DONE -- Create a class Reptile
// DONE -- give this class 4 members that are specific to Reptile
// DONE -- Set this class to inherit from your Animal Class

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile()
        {

        }
        public int TongueLengthInches { get; set; }
        public int PreferredTankTempF { get; set; }
        public bool CanRegrowTail { get; set; }
        public bool CanChangeColors { get; set; }
    } 
}
