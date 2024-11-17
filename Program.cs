namespace Zoo_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> zoo = new List<Animal>();
            zoo.Add(new Lion());
            zoo.Add(new Camel());
            zoo.Add(new Dog());
            zoo.Add(new Cow());
            zoo.Add(new Dolphin());
            zoo.Add(new Parrot());
            zoo.Add(new Pig());
            zoo.Add(new Zebra());

            foreach (Animal a in zoo)
            {
                a.Description();
            }


            // Abstract classes can not be instantiated.
            // Animal animal = new Animal();  // This line would cause an error!
        }
    }
}

