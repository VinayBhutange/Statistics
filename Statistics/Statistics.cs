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
                stats.Average = numbers.Average();
                stats.Max = numbers.Max();
                stats.Min = numbers.Min();
            }

            return stats;
        }
    }
}
