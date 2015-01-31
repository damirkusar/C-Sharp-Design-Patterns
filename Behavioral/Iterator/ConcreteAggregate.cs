using System.Collections;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList items = new ArrayList();

        public int Count
        {
            get { return this.items.Count; }
        }

        public object this[int index]
        {
            get { return this.items[index]; }
            set { this.items.Insert(index, value); }
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}