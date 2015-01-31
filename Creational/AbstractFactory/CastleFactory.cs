using System.Collections.Generic;

namespace AbstractFactoryExample
{
    public abstract class CastleFactory
    {
        public abstract Defender CreateDefender();

        public abstract List<Attacker> CreateAttackers();
    }
}