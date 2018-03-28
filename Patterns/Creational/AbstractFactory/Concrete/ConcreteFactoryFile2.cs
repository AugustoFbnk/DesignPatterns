using Patterns.Creational.AbstractFactory.Abstract;

namespace Patterns.Creational.AbstractFactory.Concrete
{
    public class ConcreteFactoryFile2 : AbstractFactoryFiles
    {
        public override AbstractFileA GenerateProcessFileA()
        {
            return new ProcessFileA2();
        }

        public override AbstractFileB GenerateProcessFileB()
        {
            return new ProcessFileB2();
        }
    }
}
