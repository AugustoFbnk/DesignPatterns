using Patterns.Behavioral.Strategy.Interface;

namespace Patterns.Behavioral.Strategy.StrategyLaws
{
    public abstract class StrategyBrazil : IStrategyLaws
    {
        public void Judgement()
        {
            if (WasSentencedFirstInstance() && WasSentencedSecondInstance())
                while (true)
                    Waiting();
        }
        public abstract void ExecuteLaw();
        public abstract bool WasSentencedFirstInstance();
        public abstract bool WasSentencedSecondInstance();
        public abstract void Waiting();
    }
}
