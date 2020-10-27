namespace Conundrum.Statistics
{
    public abstract class DependantStat<T> : StatBase
    {
        protected StatsBase<T> Stats { get; }

        public DependantStat(StatsBase<T> stats) : base()
        {
            Stats = stats;
        }
    }
}