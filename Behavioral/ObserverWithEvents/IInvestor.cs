namespace ObserverWithEvents
{
    public interface IInvestor
    {
        void Buy(Stock stock);

        void Update(Stock stock);
    }
}