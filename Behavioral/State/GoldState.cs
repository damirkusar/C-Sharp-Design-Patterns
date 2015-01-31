using System;

namespace State
{
    public class GoldState : IState
    {
        public IState Update()
        {
            Console.WriteLine("You can not upgrade a Gold State");
            return this;
        }

        public IState Cancel()
        {
            Console.WriteLine("Subscription Canceled. You are now a Freemium user.");
            return new FreemiumState();
        }
    }
}