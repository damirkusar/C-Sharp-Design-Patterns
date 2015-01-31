using System.Collections.Generic;

namespace Strategy
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}