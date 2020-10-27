namespace Conundrum.Statistics
{
    /// <summary>
    /// Interface that describe a statistic in a RPG system
    /// </summary>
    public interface IStat
    {
        /// <summary>
        /// Get the base value of a stat
        /// </summary>
        int BaseValue { get; }

        /// <summary>
        /// Get the value with all bonuses applied
        /// </summary>
        float Value { get; }

        /// <summary>
        /// Get the value added by the differents bonuses
        /// </summary>
        float BonusesValue { get; }

         /// <summary>
        /// Add a new bonus to the stat
        /// </summary>
        /// <param name="bonus">The bonus to add</param>
        /// <returns>The current stat</returns>
        IStat AddBonus(StatModifier bonus);
        
        /// <summary>
        /// Remove the bonus to the stat
        /// </summary>
        /// <param name="bonus">The bonus to remove</param>
        /// <returns>The current stat</returns>
        IStat RemoveBonus(StatModifier bonus);
    }
}
