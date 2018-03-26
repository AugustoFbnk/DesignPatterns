using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Iterator
{
    public interface IIterator
    {
        object Current { get; }
        bool HasNext();
    }
}
