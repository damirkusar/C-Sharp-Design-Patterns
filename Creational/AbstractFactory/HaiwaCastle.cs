using System.Collections.Generic;

namespace AbstractFactoryExample
{
    public class HaiwaCastle : CastleFactory
    {
        public override Defender CreateDefender()
        {
            return new Samurai();
        }

        public override List<Attacker> CreateAttackers()
        {
            return new List<Attacker> { new Golums(), new Orks() };
        }
    }
}