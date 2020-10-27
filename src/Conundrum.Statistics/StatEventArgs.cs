namespace Conundrum.Statistics
{
    public class StatEventArgs<T>
    {
        public T Type { get; }

        public IStat Stat { get; }

        public StatEventArgs(T type, IStat stat)
        {
            Stat = stat;
            Type = type;
        }
    }
}
