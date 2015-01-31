using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Adapter
{
    public class Army
    {
        public virtual ICollection<string> GetArmy()
        {
            Console.WriteLine("No Generic Army");
            return new Collection<string>();
        }
    }
}