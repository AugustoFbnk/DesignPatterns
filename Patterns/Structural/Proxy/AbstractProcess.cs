using Patterns.Structural.Proxy.DTO;
using Patterns.Structural.Proxy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy
{
    public abstract class AbstractProcess
    {
        public abstract ObjectDTO ExecuteAction(TypeEnum generate);
    }
}
