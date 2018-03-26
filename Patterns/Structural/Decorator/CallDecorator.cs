using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    public class CallDecorator
    {
        public void Call()
        {
            //Component base
            var component = new Component();
            Console.WriteLine(component.BehaviorDefault());
            Console.ReadKey();

            //using behavior A
            var componentA = new ComponentADecotator(component);
            Console.WriteLine("Using behavior A");
            Console.ReadKey();
            Console.WriteLine(componentA.BehaviorDefault());
            Console.ReadKey();
            Console.WriteLine(componentA.BehaviorAddedA());
            Console.ReadKey();

            //using behavior B
            var componentB = new ComponentBDecorator(component);
            Console.WriteLine("using behavior b");
            Console.ReadKey();
            Console.WriteLine(componentB.BehaviorDefault());
            Console.ReadKey();
            Console.WriteLine(componentB.BehaviorAddedB());
            Console.ReadKey();

            //using Behavior additiona A with default B
            var componentAdditionalADefaultB = new ComponentADecotator(componentB);
            Console.WriteLine(componentAdditionalADefaultB.BehaviorDefault());
            Console.ReadKey();
            Console.WriteLine(componentAdditionalADefaultB.BehaviorAddedA());
            Console.ReadKey();
        }

    }
}
