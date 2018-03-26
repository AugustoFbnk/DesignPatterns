using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Iterator
{
    public class Aggregate : IAggregate
    {
        private ArrayList _items = new ArrayList();
        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }
        public object this[int index]
        {
            get { return _items[index]; }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public void Add(object o)
        {
            _items.Add(o);
        }
    }
}
