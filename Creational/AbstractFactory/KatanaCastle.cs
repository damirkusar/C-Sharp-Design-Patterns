using System.Collections.Generic;

namespace AbstractFactoryExample
{
    public class KatanaCastle : CastleFactory
    {
        public override Defender CreateDefender()
        {
            return new Ninjas();
        }

        public override List<Attacker> CreateAttackers()
        {
            return new List<Attacker> { new Pirates() };
        }
    }
}