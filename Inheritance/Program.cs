using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            var parrot = new Bird();
            parrot.Species = "Parrot";
            parrot.CanFly = true;
            parrot.BeakColor = "black";
            parrot.CanTalk = true;

            var canFly = (parrot.CanFly == true) ? " It can fly, " : " It cannot fly, ";
            var canTalk = (parrot.CanTalk == true) ? "and it can talk." : "and it cannot talk.";

            Console.WriteLine($"Your {parrot.Species} has a {parrot.BeakColor} beak." + canFly + canTalk);
            
            var chameleon = new Reptile();
            chameleon.TongueLengthInches = 20;
            chameleon.PreferredTankTempF = 75;
            chameleon.CanRegrowTail = false;
            chameleon.CanChangeColors = true;

            var regrowTail = (chameleon.CanRegrowTail == true) ? "It can regrow its tail." : "It cannot regrow its tail, ";
            var changeColors = (chameleon.CanChangeColors == true) ? "and it can change colors." : "and it cannot change colors.";
            Console.WriteLine($"Your Chameleon has a tongue that is {chameleon.TongueLengthInches} inches long. It prefers a tank temperature of {chameleon.PreferredTankTempF} degrees fahrenheit.");
            Console.WriteLine(regrowTail + changeColors);
            /*DONE -- Create an object of your Bird class
             *DONE --  give values to your members using the object of your Bird class
             *  
             *DONE -- Creatively display the class member values 
             */

            /*DONE -- Create an object of your Reptile class
             *DONE --  give values to your members using the object of your Reptile class
             *  
             *DONE -- Creatively display the class member values 
             */
        }
    }
}
