namespace Bridge
{
    public abstract class Printer
    {
        private PrinterFormat printerFormat;

        protected Printer(PrinterFormat printerFormat)
        {
            this.printerFormat = printerFormat;
        }

        public abstract void PrintSettings();

        public void SetFormat(PrinterFormat format)
        {
            this.printerFormat = format;
        }

        public PrinterFormat GetFormat()
        {
            return this.printerFormat;
        }
    }
}