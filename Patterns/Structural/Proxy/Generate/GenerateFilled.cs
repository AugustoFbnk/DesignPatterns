using Patterns.Structural.Proxy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy.Generate
{
    public class GenerateFilled : IGenerate
    {
        public ObjectDTO GenerateObject()
        {
            return new ObjectDTO()
            {
                propertyBool = true,
                propertyString = "Anything",
                propertyInt = 999

            };
        }
    }
}
