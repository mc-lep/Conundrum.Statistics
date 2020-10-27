using System.Collections.Generic;

namespace Conundrum.Statistics
{
    public class Stat : StatBase
    {
        private List<StatModifier> _bonuses;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="baseValue">The base value of a stat</param>
        public Stat(int baseValue)
        {
            BaseValue = baseValue;
            _bonuses = new List<StatModifier>();
        }

        /// <summary>
        /// Get the value with all bonuses applied
        /// </summary>
        public override float Value => BaseValue + BonusesValue;
    }
}
