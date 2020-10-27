using Xunit;

namespace Conundrum.Statistics.Tests
{
    public class StatsBaseTests
    {
        private IStat _newStatAdded = null;
        private IStat _statUpdated = null;

        [Fact]
        public void Get_NonexitentStat_GivesZero()
        {
            var instance = new StatsBase<int>();
            var result = instance[1];

            Assert.Equal(Stat.Zero.BaseValue, result.BaseValue);
        }

        [Fact]
        public void Get_ExistingStat_GivesTheStat()
        {
            var instance = new StatsBase<int>();
            instance[1] = new Stat(10);
            var result = instance[1];

            Assert.Equal(10, result.BaseValue);
        }

        [Fact]
        public void Set_NewStat_IndicateThatNewStatIsAdded()
        {
            var instance = new StatsBase<int>();
            instance.StatAdded += OnStatAdded;
            instance[1] = new Stat(10);
           
            Assert.Equal(10, _newStatAdded.BaseValue);
        }

        [Fact]
        public void Set_Stat_IndicateThatStatIsUpdated()
        {
            var instance = new StatsBase<int>();
            instance.StatUpdated += OnStatUpdated;
            instance[1] = new Stat(10);
            instance[1] = new Stat(15);
           
            Assert.Equal(15, _statUpdated.BaseValue);
        }

        private void OnStatAdded(object obj, StatEventArgs<int> newStat)
        {
            _newStatAdded = newStat.Stat;
        }

        private void OnStatUpdated(object obj, StatEventArgs<int> stat)
        {
            _statUpdated = stat.Stat;
        }
    }
}
