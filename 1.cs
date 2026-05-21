using System;

namespace Task5_1_Zoo
{
    public class Eagle : Bird
    {
        public Eagle(string name, string diet, string location, double weight, int age, string colour, string species, double wingspan)
            : base(name, diet, location, weight, age, colour, species, wingspan)
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine($"{name} whistles sharply.");
        }

        public override void eat()
        {
            Console.WriteLine($"{name} eats 1lb of fish.");
        }

        public override void fly()
        {
            Console.WriteLine($"{name} flies high above the zoo.");
        }

        public override void move()
        {
            Console.WriteLine($"{name} glides through the air.");
        }
    }
}
