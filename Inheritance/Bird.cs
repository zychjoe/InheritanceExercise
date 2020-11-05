using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsLiving = true;
            Legs = 2;
            HasTail = true;
            CanSwim = false;
        }

        public bool CanFly { get; set; } = true;
        public bool HasFeathers { get; set; } = true;
        public bool CanSing { get; set; } = true;

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"Specialty:{CanSing} : Singing");
        }
    }
}
