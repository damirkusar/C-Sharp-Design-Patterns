using System;

namespace Proxy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var proxy = new MathProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            Console.ReadKey();
        }
    }
}
