using System;
using Patterns.Behavioral.Strategy.Interface;

namespace Patterns.Behavioral.Strategy.StrategyLaws
{
    public abstract class StrategyGerman : IStrategyLaws
    {
        public void Judgement()
        {
            if (WasSentenced()) { ExecuteLaw(); }
        }
        public abstract void ExecuteLaw();
        public abstract bool WasSentenced();
    }
}
