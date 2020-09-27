using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class Stats
    {
        public float average;
        public float max;
        public float min;

        public Stats()
        {
            this.average = float.NaN;
            this.min = float.NaN;
            this.max = float.NaN;
        }

    }
}