using System;

namespace TemplateMethod
{
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();

        public abstract void PrimitiveOperation2();

        // The "Template method"
        public void TemplateMethod()
        {
            this.PrimitiveOperation1();
            this.PrimitiveOperation2();
            Console.WriteLine();
        }
    }
}