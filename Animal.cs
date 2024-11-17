using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Noise { get; set; }
        public int NumberOfLegs { get; set; }
        public string Skin { get; set; }

        public void Description()
        {
            Console.WriteLine($"Here comes {Name} " +
                              $"strutting towards you on their {NumberOfLegs} legs.");
            Console.WriteLine($"{Name} is {Skin}");
            Speak();
        }
        public void Speak()
        {
            Console.WriteLine($"{Name} {Noise}");
        }
        public void Dance()
        {
            Console.WriteLine($"{Name} busts some moves!");
        }


    }
}


