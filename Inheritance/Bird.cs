using System;
using System.Collections.Generic;
using System.Text;

// DONE -- Create a class Bird
// DONE -- give this class 4 members that are specific to Bird
// DONE -- Set this class to inherit from your Animal Class

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird()
        {

        }
        public bool CanFly { get; set; }
        public string BeakColor { get; set; }
        public string Species { get; set; }
        public bool CanTalk { get; set; }
    }
}
