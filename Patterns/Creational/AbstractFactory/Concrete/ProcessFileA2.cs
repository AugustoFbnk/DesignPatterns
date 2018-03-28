using Patterns.Creational.AbstractFactory.Abstract;

namespace Patterns.Creational.AbstractFactory.Concrete
{
    public class ProcessFileA2 : AbstractFileA
    {
        public override void ReadDependenciesFileB(AbstractFileB fileB)
        {
            //Do something
        }
    }
}
