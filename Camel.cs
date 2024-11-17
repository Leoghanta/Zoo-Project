using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
    // Derived Class
    internal class Camel : Animal
    {
        // All fields and methods from the base class
        // are now part of this class.

        public Camel() {
            Name = "Camel";
            Noise = "spits";
            NumberOfLegs = 4;
            Skin = "has the hump!";
        }
    }
}

