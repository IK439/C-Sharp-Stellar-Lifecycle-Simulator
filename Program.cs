using System;

namespace StarLifecycleSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a star with a known type
            Star sun = new Star("Sirius", "G-Type");

            // Display the star's current brightness
            sun.Shine();

            // Age the star and reduce its brightness
            sun.GrowOlder();

            // Display the updated brightness
            sun.Shine();

            // Trigger a supernova event
            sun.Supernova();

            // Create a star with an unknown type
            Star unknownStar = new Star("Mystery Star");

            // Show the star's brightness
            unknownStar.Shine();

            // Age the star
            unknownStar.GrowOlder();
        }
    }
}