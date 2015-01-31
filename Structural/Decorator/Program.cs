using System;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create ConcreteComponent and two Decorators
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}
