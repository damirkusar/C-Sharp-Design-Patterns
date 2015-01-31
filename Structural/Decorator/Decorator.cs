namespace Decorator
{
    public abstract class Decorator : Component
    {
        private Component component;

        public void SetComponent(Component comp)
        {
            this.component = comp;
        }

        public override void Operation()
        {
            if (this.component != null)
            {
                this.component.Operation();
            }
        }
    }
}