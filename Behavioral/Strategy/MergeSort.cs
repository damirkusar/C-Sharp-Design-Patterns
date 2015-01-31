using System;
using System.Collections.Generic;

namespace Strategy
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            // list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}