using System;

namespace Bridge
{
    public class PlainTextFormat : PrinterFormat
    {
        public override void Print(string whatToPrint)
        {
            Console.WriteLine(whatToPrint);
        }
    }
}