using System;
using Patterns.Behavioral.Strategy.StrategyLaws;

namespace Patterns.Behavioral.Strategy.CountriesLaws
{
    public class UsaLaws : StrategyUsa
    {
        public override void ExecuteLaw()
        {
            Console.WriteLine("Laws executed successfully!");
        }

        public override bool WasSentenced()
        {
            return Validate();
        }

        /// <summary>
        /// Validate evidenties
        /// </summary>
        /// <returns></returns>
        private bool Validate()
        {
            return true;
        }
    }
}
