namespace BuilderExample
{
    public class MilleniumSmartphoneBuilder : SmartphoneBuilder
    {
        private readonly Smartphone smartphone;

        public MilleniumSmartphoneBuilder()
        {
            this.smartphone = new Smartphone("Millenium Edition");
        }

        public override void BuildSmartPhone()
        {
            this.smartphone.AddSpecialPart("Gold Case");
            this.smartphone.AddSpecialPart("Golden Logo");
        }

        public Smartphone GetSmartphone()
        {
            return this.smartphone;
        }
    }
}