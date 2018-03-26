using Patterns.Structural.Proxy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy.Generate
{
    public class FactoryGenerate
    {
        public IGenerate TypeImplement(TypeEnum type)
        {
            switch (type)
            {
                case TypeEnum.Empty:
                    return new GenerateEmpty();
                case TypeEnum.Filled:
                    return new GenerateFilled();
                default:
                    return new GenerateDefault();
            }
        }
    }
}
