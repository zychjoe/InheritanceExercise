using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird()
            {
                HasFeathers = true,
                CanFly = true,
                CanSing = true
            };

            var snake = new Reptile()
            {
                Legs = 0,
                CanSwim = true
            };

            bird.PrintDetails();
            snake.PrintDetails();
        }
    }
}
