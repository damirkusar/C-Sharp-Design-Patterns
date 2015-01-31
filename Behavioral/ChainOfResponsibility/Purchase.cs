namespace ChainOfResponsibility
{
    public class Purchase
    {
        public Purchase(int number, double amount, string purpose)
        {
            this.Number = number;
            this.Amount = amount;
            this.Purpose = purpose;
        }

        public int Number { get; set; }

        public double Amount { get; set; }

        public string Purpose { get; set; }
    }
}