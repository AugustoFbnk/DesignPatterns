using Patterns.Structural.Proxy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy
{
    public class CallProxy
    {
        public void Call()
        {
            //Obs1: This implementation follows the proxy concepts, but is not identical wich proposed by GoF
            //Obs2: The factory used in this example is not part of Proxy Pattern.
            var proxy = new ProxyProcess();
            //Instance and call empty
            proxy.ExecuteAction(TypeEnum.Empty);
            //Instance and call filled
            proxy.ExecuteAction(TypeEnum.Filled);
            //Use first instance and call empty
            proxy.ExecuteAction(TypeEnum.Empty);
        }
    }
}
