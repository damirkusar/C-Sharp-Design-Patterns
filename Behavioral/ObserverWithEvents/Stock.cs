namespace ObserverWithEvents
{
    public class Stock
    {
        private string symbole;
        private double price;

        public Stock(string symbole, double price)
        {
            this.Symbole = symbole;
            this.Price = price;
        }

        public delegate void StockHandler(Stock stock);

        public event StockHandler Update;

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
                    this.OnUpdate(this);
                }
            }
        }

        public string Symbole
        {
            get { return this.symbole; }
            set { this.symbole = value; }
        }

        protected virtual void OnUpdate(Stock stock)
        {
            var handler = this.Update;
            if (handler != null)
            {
                handler(stock);
            }
        }
    }
}