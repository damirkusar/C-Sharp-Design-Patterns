using System;
using System.Collections.Generic;

namespace Observer
{
    public class Stock
    {
        private readonly List<IInvestor> investors;
        private readonly string symbol;
        private double price;

        public Stock(string symbol, double price)
        {
            this.investors = new List<IInvestor>();
            this.symbol = symbol;
            this.price = price;
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    this.Notify();
                }
            }
        }

        public string Symbol
        {
            get { return this.symbol; }
        }

        public void Attach(IInvestor investor)
        {
            this.investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            this.investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in this.investors)
            {
                investor.Update(this);
            }

            Console.WriteLine(string.Empty);
        }
    }
}