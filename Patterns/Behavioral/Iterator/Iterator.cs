using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Iterator
{
    public class Iterator : IIterator
    {
        private Aggregate _aggregate;
        int index;

        public Iterator(Aggregate aggregate)
        {
            this._aggregate = aggregate;
            index = -1;
        }

        public bool HasNext()
        {
            index++;
            return index < _aggregate.Count;
        }

        public object Current
        {
            get
            {
                if (index < _aggregate.Count)
                    return _aggregate[index];
                else
                    throw new InvalidOperationException();
            }
        }
    }
}
