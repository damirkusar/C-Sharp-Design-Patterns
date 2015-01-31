using System;

namespace State
{
    public class FreemiumState : IState
    {
        public IState Update()
        {
            Console.WriteLine("Upgraded to Silver State");
            return new SilverState();
        }

        public IState Cancel()
        {
            Console.WriteLine("You can not cancel a Freemium State");
            return this;
        }
    }
}