using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
    // Derived Class
    internal class Lion : Animal
    {
        // All fields and methods from the base class
        // are now part of this class.

        public Lion() {
            Name = "Lion";
            Noise = "Roars";
            NumberOfLegs = 4;
            Skin = "Furry";
        }
    }
}

