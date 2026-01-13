using System;

namespace StarLifecycleSimulator
{
    public class Star
    {
        // Public read-only properties
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Age { get; private set; }
        public double Brightness { get; private set; }

        // Tracks whether the star has already exploded
        private bool hasExploded = false;

        // Constructor for a star with a known type
        public Star(string name, string type)
        {
            Name = name;
            Type = type;
            Age = 0;
            Brightness = 1.0;
        }

        // Constructor for a star with an unknown type
        public Star(string name) : this(name, "Unknown")
        {
            Console.WriteLine("Type undefined. Defaulting to unknown.");
        }

        // Displays the star's current brightness
        public void Shine()
        {
            Console.WriteLine($"Star {Name} is shining with brightness {Brightness:F2}.");
        }

        // Ages the star and reduces its brightness
        public void GrowOlder()
        {
            Age += 1;
            Brightness *= 0.9;
        }

        // Simulates a supernova event (only once)
        public void Supernova()
        {
            if (hasExploded)
            {
                return;
            }

            hasExploded = true;
            Brightness = 0;

            Console.WriteLine($"Star {Name} has exploded in a supernova.");
        }
    }
}