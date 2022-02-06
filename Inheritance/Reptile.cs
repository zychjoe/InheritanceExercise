using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public double Length { get; set; }
        private bool ColdBlooded;
        private bool CanChangeColor;
        public string Diet { get; set; }


        public Reptile(int age, bool isFemale, bool cold, bool changeColor, string hungrySound)
        {
            Age = age;
            IsFemale = isFemale;
            ColdBlooded = cold;
            CanChangeColor = changeColor;
            HungrySound = hungrySound;
        }

        public string CanYouChangeColor()
        {
            return CanChangeColor ? "Oh, yes!" : "Sadly, no";
        }
    }
}
