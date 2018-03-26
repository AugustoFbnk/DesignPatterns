using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    sealed class Component : IComponent
    {
        public string BehaviorDefault()
        {
            return "BehaviorExecuted";
        }
    }
}
