using Patterns.Creational.AbstractFactory.Concrete;

namespace Patterns.Creational.AbstractFactory.Abstract
{
    public abstract class AbstractFactoryFiles
    {
        public abstract AbstractFileA GenerateProcessFileA();
        public abstract AbstractFileB GenerateProcessFileB();
    }
}
