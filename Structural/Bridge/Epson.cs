using System;

namespace Bridge
{
    public class Epson : Printer
    {
        public Epson(PrinterFormat printerFormat)
            : base(printerFormat)
        {
        }

        public override void PrintSettings()
        {
            Console.WriteLine("--- {0} --- ", this.GetFormat().GetType().Name);
            this.GetFormat().Print("Epson Settings...");
        }
    }
}