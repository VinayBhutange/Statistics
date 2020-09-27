using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            Stats stats = new Stats();
            if (numbers.Count > 0)
            {
                if (numbers.Contains(float.NaN))
                {
                    numbers.RemoveAll(float.IsNaN);
                }
                stats.average = numbers.Average();
                stats.max = numbers.Max();
                stats.min = numbers.Min();
            }

            return stats;
        }
    }
}
