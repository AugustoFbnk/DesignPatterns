using Patterns.Creational.AbstractFactory.Abstract;

namespace Patterns.Creational.AbstractFactory.Concrete
{
    public class ConcreteFactoryFile1 : AbstractFactoryFiles
    {
        public override AbstractFileA GenerateProcessFileA()
        {
            return new ProcessFileA1();
        }

        public override AbstractFileB GenerateProcessFileB()
        {
            return new ProcessFileB1();
        }
    }
}
