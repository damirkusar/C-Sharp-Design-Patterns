using System.Collections.Generic;

namespace Adapter
{
    public class Dojo
    {
        private readonly List<string> samurais;
        private readonly List<string> ninjas;

        public Dojo()
        {
            this.samurais = new List<string>();
            this.ninjas = new List<string>();

            this.samurais.Add("Hiro");
            this.samurais.Add("Tatsuja");

            this.ninjas.Add("Tokio");
            this.ninjas.Add("Yokohama");
        }

        public ICollection<string> GetNinjas()
        {
            return this.ninjas;
        }

        public ICollection<string> GetSamurais()
        {
            return this.samurais;
        }
    }
}