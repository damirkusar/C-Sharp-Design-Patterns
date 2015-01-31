using System;

namespace AbstractFactoryExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CastleFactory haiwa = new HaiwaCastle();
            var battleInHaiwa = new Battle(haiwa);
            battleInHaiwa.Fight();

            CastleFactory katana = new KatanaCastle();
            var battleInKatana = new Battle(katana);
            battleInKatana.Fight();

            Console.ReadLine();
        }
    }
}
