using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Iterator
{
    public class CallIterator
    {
        public void Call()
        {
            var aggregate = new Aggregate();
            aggregate.Add("A");
            aggregate.Add("B");
            aggregate.Add("C");
            var iterator = aggregate.CreateIterator();

            while (iterator.HasNext())
            {
                string item = (string)iterator.Current;
                Console.WriteLine(item);
            }
        }
    }
}
