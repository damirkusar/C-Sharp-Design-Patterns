using System;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var army = new Army();
            var ninjaArmy = new NinjaArmy();

            Console.WriteLine("Generic Army");
            foreach (var fighter in army.GetArmy())
            {
                Console.WriteLine(fighter);
            }

            Console.WriteLine();

            Console.WriteLine("Ninja Army");
            foreach (var fighter in ninjaArmy.GetArmy())
            {
                Console.WriteLine(fighter);
            }

            Console.ReadLine();
        }
    }
}
