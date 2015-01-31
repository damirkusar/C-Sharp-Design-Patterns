using System;

namespace Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            this.AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        public void AddedBehavior()
        {
            Console.WriteLine("Added behaviour in ConcreteDecoratorB.Operation()");
        }
    }
}