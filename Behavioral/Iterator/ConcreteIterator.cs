namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        private readonly ConcreteAggregate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First()
        {
            return this.aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (this.current < this.aggregate.Count - 1)
            {
                ret = this.aggregate[++this.current];
            }

            return ret;
        }

        public override object CurrentItem()
        {
            return this.aggregate[this.current];
        }

        public override bool IsDone()
        {
            return this.current >= this.aggregate.Count;
        }
    }
}