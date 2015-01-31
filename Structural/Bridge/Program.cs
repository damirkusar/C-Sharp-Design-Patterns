using System;

namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Printer printer = new Epson(new HtmlFormat());
            printer.PrintSettings();

            printer.SetFormat(new PlainTextFormat());
            printer.PrintSettings();

            Console.ReadLine();
        }
    }
}
