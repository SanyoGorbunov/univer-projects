using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TimeSeriesAnalysis.Model
{
    class TimeValuePair
    {
        public double Time { get; set; }
        public double Value { get; set; }
    }

    class TimeSeries
    {
        public TimeSeries(DataTable dtTS, bool hasTime)
        {
            double timeCounter = 0;
            Data = dtTS.AsEnumerable().Select(row =>
            {
                double time, val;
                if (hasTime)
                {
                    time = double.Parse(row[0].ToString());
                    val = double.Parse(row[1].ToString());
                }
                else
                {
                    time = timeCounter;
                    timeCounter++;
                    val = double.Parse(row[0].ToString());
                }
                return new TimeValuePair
                {
                    Time = time,
                    Value = val
                };
            }).ToList();
        }
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
