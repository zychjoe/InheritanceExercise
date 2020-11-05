using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsLiving = true;
            Legs = 2;
            HasTail = true;
            CanSwim = false;
        }

        public bool IsColdBlooded { get; set; } = true;
        public string Mobility { get; set; } = "Slither";

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Is Cold-Blooded: {IsColdBlooded}");
            Console.WriteLine($"Mobility: {Mobility}");
        }
    }
}
