using Patterns.Behavioral.Strategy.CountriesLaws;
using Patterns.Behavioral.Strategy.Interface;

namespace Patterns.Behavioral.Strategy
{
    public class CallStrategy
    {
        private void Execute(IStrategyLaws strategy)
        {
            strategy.Judgement();
        }

        public void Call()
        {
            IStrategyLaws[] laws = { new UsaLaws(), new GermanLaws(), new BrazilLaws() };
            foreach (var law in laws) { Execute(law); }
        }
    }
}
