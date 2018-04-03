using Patterns.Behavioral.Strategy.Interface;

namespace Patterns.Behavioral.Strategy.StrategyLaws
{
    public abstract class StrategyUsa : IStrategyLaws
    {
        public void Judgement()
        {
            if (WasSentenced()) { ExecuteLaw(); }
        }
        public abstract void ExecuteLaw();
        public abstract bool WasSentenced();
    }
}
