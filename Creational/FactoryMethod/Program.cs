using System;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Document resume = new Resume();
            Document report = new Report();

            resume.ShowPages();
            report.ShowPages();

            Console.ReadLine();
        }
    }
}
