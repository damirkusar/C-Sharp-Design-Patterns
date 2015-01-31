using System;

namespace BuilderExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manufacturer = new Manufacturer();

            var milleniumSmartphoneBuilder = new MilleniumSmartphoneBuilder();
            var waterproofSmartphoneBuilder = new WaterproofSmartphoneBuilder();

            manufacturer.ConstructSmartphone(milleniumSmartphoneBuilder);
            var milleniumSmartphone = milleniumSmartphoneBuilder.GetSmartphone();
            milleniumSmartphone.Show();

            manufacturer.ConstructSmartphone(waterproofSmartphoneBuilder);
            var waterproofSmartphone = waterproofSmartphoneBuilder.GetSmartphone();
            waterproofSmartphone.Show();

            Console.ReadLine();
        }
    }
}
