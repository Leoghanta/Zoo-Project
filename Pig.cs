using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
    // Derived Class
    internal class Pig : Animal
    {
        // All fields and methods from the base class
        // are now part of this class.

        public Pig() {
            Name = "Pig";
            Noise = "Oinks";
            NumberOfLegs = 4;
            Skin = "Hairy";
        }
    }
}

