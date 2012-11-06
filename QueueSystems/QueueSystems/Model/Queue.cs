using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Common;

namespace QueueSystems.Model
{
    public class Queue: List<double>, IStringParsable
    {
        public Queue()
        {

        }
        public Queue(IEnumerable<double> values)
        {
            AddRange(values);
        }

        public void Parse(string source)
        {
            Clear();
            foreach (var strVal in source.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                Add(double.Parse(strVal));
            }
        }
        public string ToStringSource()
        {
            return string.Join<double>(" ", this);
        }

        public List<double> ToTime
        {
            get
            {
                double t = 0;
                List<double> times = new List<double>();
                foreach (var val in this)
                {
                    t += val;
                    times.Add(t);
                }
                return times;
            }
        }

        public double Intensity
        {
            get
            {
                return Count / this.Sum();
            }
        }
    }
}
