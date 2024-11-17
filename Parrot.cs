using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
    // Derived Class
    internal class Parrot : Animal
    {
        // All fields and methods from the base class
        // are now part of this class.

        public Parrot() {
            Name = "Parrot";
            Noise = "says 'Who's a pretty boy then?'";
            NumberOfLegs = 2;
            Skin = "Feathery";
        }
    }
}

