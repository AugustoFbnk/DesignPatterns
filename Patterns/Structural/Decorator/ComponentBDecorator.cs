using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    public class ComponentBDecorator : IComponent
    {
        IComponent BehaviorComponent;
        public ComponentBDecorator(IComponent behaviorComponent)
        {
            BehaviorComponent = behaviorComponent;
        }
        public string BehaviorDefault()
        {
            return "DEFAULT B!";//BehaviorComponent.BehaviorDefault();
        }
        public string BehaviorAddedB()
        {
            return "Executed added behavior B";
        }
    }
}
