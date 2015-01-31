namespace Composite
{
    public abstract class Component
    {
        protected Component(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public abstract void Add(Component c);

        public abstract void Remove(Component c);

        public abstract void Display(int depth);
    }
}