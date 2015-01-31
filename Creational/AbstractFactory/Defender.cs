using System;
using System.Collections.Generic;

namespace AbstractFactoryExample
{
    public abstract class Defender
    {
        public void DefendsAgainst(List<Attacker> attackers)
        {
            Console.WriteLine("The {0}-Castle gets attacked by:", this.GetType().Name);
            foreach (var attacker in attackers)
            {
                Console.WriteLine("- {0}", attacker.GetType().Name);
            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}