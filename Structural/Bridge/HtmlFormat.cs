using System;

namespace Bridge
{
    public class HtmlFormat : PrinterFormat
    {
        public override void Print(string whatToPrint)
        {
            Console.WriteLine("<p>\n\t<em> {0} </em>\n</p>", whatToPrint);
        }
    }
}