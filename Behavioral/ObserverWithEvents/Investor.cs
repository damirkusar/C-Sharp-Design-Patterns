using System;

namespace ObserverWithEvents
{
    public class Investor : IInvestor
    {
        private readonly string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Buy(Stock stock)
        {
            stock.Update += this.Update;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("{0}' {1} stocks got updated. New Price is: {2}", this.name, stock.Symbole, stock.Price);
        }
    }
}