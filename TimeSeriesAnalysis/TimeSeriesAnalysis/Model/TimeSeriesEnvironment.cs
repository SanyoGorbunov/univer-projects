using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSeriesAnalysis.Model
{
    public class TimeSeriesEnvironment
    {
        private static TimeSeriesEnvironment _current;
        public static TimeSeriesEnvironment Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new TimeSeriesEnvironment();
                }
                return _current;
            }
        }

        public double Alpha { get; set; }
    }
}
