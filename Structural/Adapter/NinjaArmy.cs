using System.Collections.Generic;

namespace Adapter
{
    public class NinjaArmy : Army
    {
        private readonly Dojo dojo;

        public NinjaArmy()
        {
            this.dojo = new Dojo();
        }

        public override ICollection<string> GetArmy()
        {
            return this.dojo.GetNinjas();
        }
    }
}