using System;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // Wait for user
            Console.ReadKey();
        }
    }
}
