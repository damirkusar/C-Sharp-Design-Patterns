using System;

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FighterPrototype ninja = new Ninja("Blue");
            FighterPrototype samurai = new Ninja("Green");

            var copiedNinja = ninja;
            var copiedSamurai = samurai;

            var clonedNinja = ninja.Clone();
            var clonedSamurai = samurai.Clone();

            ninja.Name = "Gold";
            samurai.Name = "Silver";

            Console.WriteLine("Original Ninja");
            Console.WriteLine("----------");
            ninja.ShowFighter();
            Console.WriteLine();

            Console.WriteLine("Copied Ninja");
            Console.WriteLine("----------");
            copiedNinja.ShowFighter();
            Console.WriteLine();

            Console.WriteLine("Cloned Ninja");
            Console.WriteLine("----------");
            clonedNinja.ShowFighter();
            Console.WriteLine();

            Console.WriteLine("Original Samurai");
            Console.WriteLine("----------");
            samurai.ShowFighter();
            Console.WriteLine();

            Console.WriteLine("Copied Samurai");
            Console.WriteLine("----------");
            copiedSamurai.ShowFighter();
            Console.WriteLine();

            Console.WriteLine("Cloned Samurai");
            Console.WriteLine("----------");
            clonedSamurai.ShowFighter();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
