using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    public class ComponentADecotator : IComponent
    {
        IComponent BehaviorComponent;
        public ComponentADecotator(IComponent behaviorComponent)
        {
            BehaviorComponent = behaviorComponent;
        }
        public string BehaviorDefault()
        {
            return BehaviorComponent.BehaviorDefault();
        }
        public string BehaviorAddedA()
        {
            return "Executed added behavior A";
        }
    }
}
