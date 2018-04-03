using Patterns.Behavioral.Strategy.StrategyLaws;
using System;

namespace Patterns.Behavioral.Strategy.CountriesLaws
{
    public class GermanLaws : StrategyGerman
    {
        public override void ExecuteLaw()
        {
            Console.WriteLine("Gesetze erfolgreich durchgeführt!");
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
