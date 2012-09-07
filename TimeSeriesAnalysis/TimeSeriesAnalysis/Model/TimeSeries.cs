using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSeriesAnalysis.Model
{
    class TimeValuePair
    {
        public int Time { get; set; }
        public double Value { get; set; }
    }

    class TimeSeries
    {
        public List<TimeValuePair> Data { get; set; }

        public int Count
        {
            get
            {
                return Data.Count;
            }
        }
        public List<double> Excerpt
        {
            get
            {
                return Data.Select(tv => tv.Value).ToList();
            }
        }
    }
}
