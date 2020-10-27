using Xunit;

namespace Conundrum.Statistics.Tests
{
    public class StatTests
    {
        [Fact]
        public void BaseValue_WithBonus_DontChange()
        {
            var instance = new Stat(20).AddBonus(new StatModifier(10, 10));
            var result = instance.BaseValue;

            Assert.Equal(20, result);
        }

        [Fact]
        public void Value_WithAddBonuse_Change()
        {
            var instance = new Stat(20).AddBonus(new StatModifier(5, 0f));
            var result = instance.Value;

            Assert.Equal(25, instance.Value);
        } 

        [Fact]
        public void Value_WithMultiplierBonuse_Change()
        {
            var instance = new Stat(20).AddBonus(new StatModifier(0, 1.0f));
            var result = instance.Value;
            
            Assert.Equal(40, instance.Value);
        }
    }
}
