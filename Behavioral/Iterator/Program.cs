using System;

namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            // Create Iterator and provide aggregate
            var i = new ConcreteIterator(a);

            Console.WriteLine("Iterating over collection:");

            var item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
