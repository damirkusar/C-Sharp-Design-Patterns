using System;

namespace State
{
    public class SilverState : IState
    {
        public IState Update()
        {
            Console.WriteLine("Upgraded to Gold State");
            return new GoldState();
        }

        public IState Cancel()
        {
            Console.WriteLine("Subscription Canceled. You are now a Freemium user.");
            return new FreemiumState();
        }
    }
}