using System;

namespace State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var elon = new Account("Elon");
            elon.CancelSubsription();

            elon.UpdateStatus();
            elon.UpdateStatus();
            elon.UpdateStatus();

            elon.CancelSubsription();
            elon.UpdateStatus();

            elon.CancelSubsription();

            Console.ReadKey();
        }
    }
}
