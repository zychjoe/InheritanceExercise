using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public double Wingspan { get; set; }
        private bool CanFly;
        public string Color { get; set; }
        public string Prey;

        public Bird(int age, bool isFemale, bool canFly, string hungrySound)
        {
            Age = age;
            IsFemale = isFemale;
            CanFly = canFly;
            HungrySound = hungrySound;
        }

        public  Bird(int age, bool isFemale, bool canFly, string hungrySound, string prey)
        {
            Age = age;
            IsFemale = isFemale;
            CanFly = canFly;
            HungrySound = hungrySound;
            Prey = prey;
        }

        public string CanYouFly()
        {
            return CanFly? "Oh, yes!": "Sadly, no";
        }
    }
}
