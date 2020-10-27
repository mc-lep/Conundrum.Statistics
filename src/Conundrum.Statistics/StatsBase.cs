using System;
using System.Collections.Generic;

namespace Conundrum.Statistics
{
    /// <summary>
    /// Class for grouping statistics
    /// </summary>
    /// <typeparam name="T">The type of the key for each statistics</typeparam>
    public class StatsBase<T>
    {
        /// <summary>
        /// Event raised when a new stat is added
        /// </summary>
        public event EventHandler<StatEventArgs<T>> StatAdded;

        /// <summary>
        /// Event raised when a stat is updated
        /// </summary>
        public event EventHandler<StatEventArgs<T>> StatUpdated;

        private Dictionary<T, IStat> _statistics;

        /// <summary>
        /// Constructor
        /// </summary>
        public StatsBase()
        {
            _statistics = new Dictionary<T, IStat>();
        }

        /// <summary>
        /// Get or set the new statistic
        /// </summary>
        /// <value>The statistic</value>
        public IStat this[T type]
        {
            get { return Get(type); }
            set { Set(type, value); }
        }

        /// <summary>
        /// Add or update a statistic
        /// </summary>
        /// <param name="type">The type of statistic</param>
        /// <param name="statistic">The new statistic</param>
        private void Set(T type, IStat statistic)
        {
            if (_statistics.ContainsKey(type))
            {
                _statistics[type] = statistic;
                StatUpdated?.Invoke(this, new StatEventArgs<T>(type, statistic));
            }
            else
            {
                _statistics.Add(type, statistic);
                StatAdded?.Invoke(this, new StatEventArgs<T>(type, statistic));
            }
        }

        /// <summary>
        /// Get requested the statistic 
        /// </summary>
        /// <param name="type">The type of statistic</param>
        /// <returns>The requested statistic</returns>
        private IStat Get(T type)
        {
            if (_statistics.ContainsKey(type))
            {
                return _statistics[type];
            }

            return Stat.Zero;
        }
    }
}
