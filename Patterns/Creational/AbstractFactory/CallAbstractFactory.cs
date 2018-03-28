using Patterns.Creational.AbstractFactory.Abstract;

namespace Patterns.Creational.AbstractFactory
{
    public class CallAbstractFactory
    {
        public void Call(AbstractFactoryFiles factory)
        {
            var abstractFileA = factory.GenerateProcessFileA();
            var abstractfileB = factory.GenerateProcessFileB();

            abstractFileA.ReadDependenciesFileB(abstractfileB);
            abstractfileB.ReadDependenciesFileA(abstractFileA);
        }
    }
}
