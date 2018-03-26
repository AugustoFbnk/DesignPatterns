using Patterns.Structural.Proxy.DTO;
using Patterns.Structural.Proxy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy
{
    public class ProxyProcess : AbstractProcess
    {
        private RealProcess real;
        private ObjectDTO emptyObject;
        private ObjectDTO filledObject;
        public ProxyProcess()
        {
            real = new RealProcess();
        }
        public override ObjectDTO ExecuteAction(TypeEnum generate)
        {
            if (generate == TypeEnum.Empty && emptyObject == null)
                return InstanceAndReturnNew(generate);
            else if (generate == TypeEnum.Filled && filledObject == null)
                return InstanceAndReturnNew(generate);
            else
                return ReturnInstance(generate);
        }
        public ObjectDTO InstanceAndReturnNew(TypeEnum generate)
        {
            var obj = real.ExecuteAction(generate);
            if (generate == TypeEnum.Empty)
            {
                emptyObject = obj;
                return obj;
            }
            else
            {
                filledObject = obj;
                return obj;
            }
        }
        public ObjectDTO ReturnInstance(TypeEnum generate)
        {
            if (generate == TypeEnum.Empty && emptyObject != null)
                return emptyObject;
            else if (generate == TypeEnum.Filled && filledObject != null)
                return filledObject;
            return new ObjectDTO();
        }
    }
}
