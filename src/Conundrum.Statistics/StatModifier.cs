namespace Conundrum.Statistics
{
    /// <summary>
    /// A modifier to apply to a statistic
    /// </summary>
    public class StatModifier
    {
        ///<summary>
        /// Get the multiplier to be applied to the base value
        ///</summary>
        public float Multiplier { get; }

        /// <summary>
        /// Get the value to add to the base value
        /// </summary>
        public int ValueToAdd { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="valueToAdd">The value to add to the base value</param>
        /// <param name="multiplier">The multiplier to be applied to the base value</param>
        public StatModifier(int valueToAdd, float multiplier)
        {
            ValueToAdd = valueToAdd;
            Multiplier = multiplier;
        }
    }
}
