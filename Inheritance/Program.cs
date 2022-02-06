using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Chicken = new Bird(2, true, false, "Cluck, cluck", "grubs");
            Chicken.Color = "white";
            Chicken.Habitat = "Coop";
            Chicken.Wingspan = 3.5;




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile Chameleon = new Reptile(12, false, true, true, "Grawp");
            Chameleon.Diet = "flies";
            Chameleon.Habitat = "Forest";
            Chameleon.Length = 2.2;

            void UserInterface()
            { 
                Console.WriteLine("You can meet my chicken or my chameleon! Which do you want to see?");
                string choice = Console.ReadLine();
                if (choice == "Chicken" || choice == "chicken")
                {
                    MeetChicken();
                }
                else if (choice == "Chameleon" || choice == "chameleon")
                {
                    MeetChameleon();
                }
                else
                {
                    Console.WriteLine("FARMER: I don't understand...");
                    UserInterface();
                }
            }

            void MeetChicken()
            {
                Console.WriteLine($"FARMER: This here's my chicken! It's a {Chicken.Sex()}");
                Console.WriteLine($"It has a wingspan of {Chicken.Wingspan} feet.");
                Console.WriteLine($"It lives in a {Chicken.Habitat} and if people ask if it can fly I say \"{Chicken.CanYouFly()}\"");
                Console.WriteLine($"FARMER: Wanna try to feed it some {Chicken.Prey}? Y or N?");
                string wannaFeed = Console.ReadLine();
                if (wannaFeed == "Y" || wannaFeed == "y")
                {
                    TryToFeed(Chicken);
                }
                else
                {
                    Console.WriteLine("FARMER: Maybe Later.");
                    Console.WriteLine("Wanna meet my Chameleon now? Y or N?");
                    string meetCham = Console.ReadLine();
                    if (meetCham == "Y" || meetCham == "y")
                    {
                        Console.WriteLine("FARMER: Okay!");
                        MeetChameleon();
                    }
                    else
                    {
                        return;
                    }
                }
            }

            void MeetChameleon()
            {
                Console.WriteLine($"FARMER: This here's my chameleon! It's a {Chameleon.Sex()}");
                Console.WriteLine($"It has a length of {Chameleon.Length} feet.");
                Console.WriteLine($"It lives in a {Chameleon.Habitat} and if people ask if it can change colors I say \"{Chameleon.CanYouChangeColor()}\"");
                Console.WriteLine($"FARMER: Wanna try to feed it some {Chameleon.Diet}? Y or N?");
                string wannaFeed = Console.ReadLine();
                if (wannaFeed == "Y" || wannaFeed == "y")
                {
                    TryToFeed(Chameleon);
                }
                else
                {
                    Console.WriteLine("FARMER: Maybe Later.");
                    Console.WriteLine("Wanna meet my Chicken now? Y or N?");
                    string meetChic = Console.ReadLine();
                    if (meetChic == "Y" || meetChic == "y")
                    {
                        Console.WriteLine("FARMER: Okay!");
                        MeetChicken();
                    }
                    else
                    {
                        return;
                    }
                }
            }


            void TryToFeed(Animal an)
            {
                Console.WriteLine("FARMER: Alright!");
                Console.WriteLine("*The farmer turns to the animal.*");
                Console.WriteLine("FARMER: Want some food, lil buddy?");
                Console.WriteLine($"ANIMAL: {an.AreYouHungry()}");
                if (an.IsHungry)
                {
                    Console.WriteLine("FARMER: Okay, here's some tasty food for ya!");
                    an.Eat();
                    UserInterface();
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("FARMER: Are you sure you're not hungry?");
                        Console.WriteLine($"ANIMAL: {an.AreYouHungry()}");
                        Console.WriteLine("FARMER: Hmmm... Doesn't seem hungry. Wanna try again? Y or N?");
                        string yesOrNo = Console.ReadLine();
                        if (yesOrNo == "N" || yesOrNo == "n")
                        {
                            break;
                        }
                    }

                    Console.WriteLine("FARMER: Eh..We'll Try Again Later");
                    UserInterface();
                }
            }



            Console.WriteLine("FARMER: Why hello there! Welcome to my farm. Wanna meet my animals?");
            UserInterface();
            Console.WriteLine("FARMER: Well, Y'all come back now, y'hear?");
        }
    }
}
