using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QueueSystems.Model
{
    using Common;
    using System.IO;

    class Queue
    {
        private List<double> _intervals = new List<double>();

        public List<double> Intervals
        {
            get
            {
                return _intervals;
            }
        }
        public List<double> Time
        {
            get
            {
                List<double> time = new List<double>();
                double t = 0;
                foreach (var interval in _intervals)
                {
                    t += interval;
                    time.Add(t);
                }
                return time;
            }
        }
        public int Count
        {
            get
            {
                return _intervals.Count;
            }
        }

        public static Queue ReadFromFile(string filename)
        {
            return ReadFromSource(File.ReadAllText(filename));
        }
        public static Queue ReadFromSource(string source)
        {
            Queue q = new Queue();
            foreach (string strInterval
                in source.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                q._intervals.Add(double.Parse(strInterval));
            }
            return q;
        }
    }

    static class RandomChecker
    {
        public static Hypothesis Procedure1(List<double> excerpt) {
            int n = excerpt.Count;

            List<double> sortedExcerpt = excerpt.OrderBy(x => x).ToList();
            List<double> d = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double di = i == 0 ?
                    sortedExcerpt[i] * (n - i) :
                    (sortedExcerpt[i] - sortedExcerpt[i - 1]) * (n - i);
                d.Add(di);
            }

            double V = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    V += d[i] > d[j] ? 1 :
                        d[i] == d[j] ? 0.5 : 0;
                }
            }

            double EV = n * (n - 1.0) / 4;
            double DV = Math.Sqrt((2 * n + 5) * (n - 1.0) * n / 72);
            double stat = (V + 0.5 - EV) / DV;
            return Hypothesis.Normal(stat);
        }
    }
}
