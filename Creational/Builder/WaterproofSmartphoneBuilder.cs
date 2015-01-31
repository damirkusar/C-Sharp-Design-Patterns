namespace BuilderExample
{
    public class WaterproofSmartphoneBuilder : SmartphoneBuilder
    {
        private readonly Smartphone smartphone;

        public WaterproofSmartphoneBuilder()
        {
            this.smartphone = new Smartphone("Waterproof Edition");
        }

        public override void BuildSmartPhone()
        {
            this.smartphone.AddSpecialPart("Waterproof Case");
            this.smartphone.AddSpecialPart("Blue Color");
        }

        public Smartphone GetSmartphone()
        {
            return this.smartphone;
        }
    }
}