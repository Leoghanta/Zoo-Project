using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
    // Derived Class
    internal class Cockerel : Animal
    {
        // All fields and methods from the base class
        // are now part of this class.

        public Cockerel() {
            Name = "Cockerel";
            Noise = "Bok Bok Boks";
            NumberOfLegs = 2;
            Skin = "Downy";
        }
    }
}

