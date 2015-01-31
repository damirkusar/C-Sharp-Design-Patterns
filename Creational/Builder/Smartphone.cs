using System;
using System.Collections.Generic;

namespace BuilderExample
{
    public class Smartphone
    {
        private readonly string name;
        private readonly List<string> specialParts;

        public Smartphone(string name)
        {
            this.name = name;
            this.specialParts = new List<string>();
        }

        public void AddSpecialPart(string part)
        {
            this.specialParts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("{0} has following special parts assembled", this.name);
            foreach (var specialPart in this.specialParts)
            {
                Console.WriteLine("- {0}", specialPart);
            }
        }
    }
}