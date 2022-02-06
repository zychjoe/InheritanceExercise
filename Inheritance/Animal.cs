using System;
namespace Inheritance
{
    public class Animal
    {
        public int Age { get; set; }
        internal bool IsFemale;
        public string Habitat { get; set; }
        public bool IsHungry { get; set; }
        internal string HungrySound = "*whimper*";


        internal Animal()
        {
            IsHungry = true;
        }

        public Animal(int age, bool isFemale)
        {
            Age = age;
            IsFemale = isFemale;
            IsHungry = true;
        }

        public Animal(int age, bool isFemale, string habitat)
        {
            Age = age;
            IsFemale = isFemale;
            IsHungry = true;
            Habitat = habitat;
        }

        public void Eat()
        {
            IsHungry = false;
        }

        public string Sex()
        {
            return IsFemale ? "Female" : "Male";
        }

        public string AreYouHungry()
        {
            Random rand = new Random();
            string[] notHungry = { "*cocks its head in confusion*" ,
                                   "*stares blankly*",
                                   "*turns away*",
                                   "*shakes its head side-to-side as if to answer your question*"};

            return IsHungry ? HungrySound : notHungry[rand.Next(0, 4)];
        }

    }
}
