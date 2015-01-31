using System;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var tesla = new Tesla("IBM", 120.00);
            tesla.Attach(new Investor("Sorros"));
            tesla.Attach(new Investor("Berkshire"));

            tesla.Price = 120.10;
            tesla.Price = 121.00;
            tesla.Price = 120.50;
            tesla.Price = 120.75;

            Console.ReadKey();
        }
    }
}
