using System;

namespace Facade
{
    public class Facade
    {
        private readonly SubSystemOne one;
        private readonly SubSystemTwo two;
        private readonly SubSystemThree three;
        private readonly SubSystemFour four;

        public Facade()
        {
            this.one = new SubSystemOne();
            this.two = new SubSystemTwo();
            this.three = new SubSystemThree();
            this.four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            this.one.MethodOne();
            this.two.MethodTwo();
            this.four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            this.two.MethodTwo();
            this.three.MethodThree();
        }
    }
}