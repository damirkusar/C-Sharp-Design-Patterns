using System;
using System.Collections.Generic;

namespace Strategy
{
    public class SortedList
    {
        private readonly List<string> list = new List<string>();
        private SortStrategy sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            this.list.Add(name);
        }

        public void Sort()
        {
            this.sortstrategy.Sort(this.list);

            // Iterate over list and display results
            foreach (var name in this.list)
            {
                Console.WriteLine(" " + name);
            }

            Console.WriteLine();
        }
    }
}