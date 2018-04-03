using System;
using Patterns.Behavioral.Strategy.StrategyLaws;

namespace Patterns.Behavioral.Strategy.CountriesLaws
{
    public class BrazilLaws : StrategyBrazil
    {
        public override void ExecuteLaw()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Just wait.
        /// </summary>
        public override void Waiting()
        {
            
        }

        public override bool WasSentencedFirstInstance()
        {
            return true;
        }

        public override bool WasSentencedSecondInstance()
        {
            return true;
        }
    }
}
