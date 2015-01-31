using System.Collections.Generic;

namespace AbstractFactoryExample
{
    public class Battle
    {
        private readonly Defender defender;
        private readonly List<Attacker> attackers;

        public Battle(CastleFactory castleFactory)
        {
            this.defender = castleFactory.CreateDefender();
            this.attackers = castleFactory.CreateAttackers();
        }

        public void Fight()
        {
            this.defender.DefendsAgainst(this.attackers);
        }
    }
}