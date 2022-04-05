using System;

namespace MethodsExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color in the whole world?");
            string color = Console.ReadLine();

            Console.WriteLine("Cool Cool, not my favorite color. But enough about your lame" +
                 " color choice, what is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("HMMMM I'm really not liking these answers, I only like your name so far. What is your" +
                " favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"{name} cannot match their shoes with their {color} shirt. They have horrible" +
                $" taste in fashion, I mean who really dresses like that?! The {animal} is their favorite animal, I" +
                $" don't like it I got chased by one of them, and ew. At least they listen to {band}, so I guess" +
                $" they aren't all that bad. I'll rate them a 5 out of 10. And that's being genorous. Hopefully" +
                $" you'll match on Tinder, but I mean you don't have that much to choose from. <_<");
        }
    }
}
