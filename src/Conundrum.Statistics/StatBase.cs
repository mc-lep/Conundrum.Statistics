using System.Collections.Generic;

namespace Conundrum.Statistics
{
    public abstract class StatBase : IStat
    {
        /// <summary>
        /// The default value of a Stat
        /// </summary>
        public static Stat Zero = new Stat(0);

        private List<StatModifier> _bonuses;

        /// <summary>
        /// Get the base value of a stat
        /// </summary>
        public int BaseValue { get; protected set; }

        /// <summary>
        /// Get the value with all bonuses applied
        /// </summary>
        public abstract float Value { get; }

        /// <summary>
        /// Get the value added by the differents bonuses
        /// </summary>
        public float BonusesValue => GetBonusValue();

        public IStat AddBonus(StatModifier bonus)
        {
            _bonuses.Add(bonus);
            return this;
        }

        public IStat RemoveBonus(StatModifier bonus)
        {
            _bonuses.Remove(bonus);
            return this;
        }

        private float GetBonusValue()
        {
            var total = 0.0f;
            var multiplier = 0.0f;

            foreach(var modifier in _bonuses)
            {
                total += modifier.ValueToAdd;
                multiplier += modifier.Multiplier;
            }

            return total + (BaseValue * multiplier);
        }

        protected StatBase()
        {
            _bonuses = new List<StatModifier>();
        }
    }
}
