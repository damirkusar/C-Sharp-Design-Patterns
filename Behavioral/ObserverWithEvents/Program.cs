using System;

namespace ObserverWithEvents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var microsoft = new Microsoft(100.02);
            var tesla = new Tesla(250.03);

            var warren = new Investor("Warren");
            var bill = new Investor("Bill");

            warren.Buy(microsoft);
            warren.Buy(tesla);
            bill.Buy(tesla);

            microsoft.Price = 99.8;
            tesla.Price = 250.5;

            Console.ReadKey();
        }
    }
}
