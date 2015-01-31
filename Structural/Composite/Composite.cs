using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : Component
    {
        private readonly List<Component> children = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            this.children.Add(component);
        }

        public override void Remove(Component component)
        {
            this.children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);

            foreach (var component in this.children)
            {
                component.Display(depth + 2);
            }
        }
    }
}