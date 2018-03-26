using Patterns.Structural.Proxy.DTO;
using Patterns.Structural.Proxy.Enums;
using Patterns.Structural.Proxy.Generate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy
{
    public class RealProcess : AbstractProcess
    {
        public override ObjectDTO ExecuteAction(TypeEnum generate)
        {
            var factory = new FactoryGenerate();
            var typeGenerate = factory.TypeImplement(generate);
            return typeGenerate.GenerateObject();
        }
    }
}
