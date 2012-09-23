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
        public static Hypothesis GetHypothesisOfExpDistribution(List<double> excerpt) {
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

        public static Hypothesis GetHypothesisOfTrends(List<double> excerpt)
        {
            int n = excerpt.Count;
            double W = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    W += excerpt[i] < excerpt[j] ? 1 :
                        excerpt[i] == excerpt[j] ? 0.5 : 0;
                }
            }

            double EW = n * (n - 1.0) / 4;
            double DW = Math.Sqrt((2 * n + 5) * (n - 1.0) * (n) / 72);
            double stat = (W + 0.5 - EW) / DW;
            return Hypothesis.Normal(stat);
        }

        public static List<Interval> GetConfIntervalOfQueueParameter(Queue queue, int classCount)
        {
            List<double> times = queue.Time;
            int n = times.Count;

            double width;
            List<Partition> partitions = Partition.Split(times, classCount, out width);
            List<Interval> intervals = new List<Interval>();
            double q = DistributionHelper.GetNormalDistributionQuantile(Globals.Alpha),
                aq = 0.5 * q * q / n / width;
            for (int i = 0; i < classCount; i++)
            {
                int ns = partitions[i].Count;
                Interval interval = new Interval
                {
                    Value = 1.0 * ns / n / width
                };
                double d = q * Math.Sqrt(ns + 0.25 * q * q) / n / width;
                interval.Lower = interval.Value + aq - d;
                interval.Upper = interval.Value + aq + d;
                intervals.Add(interval);
            }

            return intervals;
        }
    }

    class Partition
    {
        private List<double> _events = new List<double>();
        public List<double> Events {
            get
            {
                return _events;
            }
            set
            {
                _events = value;
            }
        }

        private double min = double.NaN;
        public double Min
        {
            get
            {
                return min;
            }
        }
        private double max = double.NaN;
        public double Max
        {
            get
            {
                return max;
            }
        }

        public void AddEvent(double ev)
        {
            if (double.IsNaN(min) || ev < min)
            {
                min = ev;
            }
            if (double.IsNaN(max) || ev > max)
            {
                max = ev;
            }
            _events.Add(ev);
        }

        public int Count
        {
            get
            {
                return Events.Count;
            }
        }
        public double Width { get; set; }

        public static List<Partition> Split(List<double> excerpt, int m, out double width)
        {
            double min = excerpt.Min(),
                max = excerpt.Max();
            width = (max - min) / m;
            List<Partition> partitions = new List<Partition>();
            for (int i = 0; i < m; i++)
            {
                partitions.Add(new Partition
                {
                    Width = width
                });
            }

            foreach (var ev in excerpt)
            {
                int num = (int)Math.Floor((ev - min) / width);
                if (num == m)
                {
                    num--;
                }
                partitions[num].AddEvent(ev);
            }

            return partitions;
        }
    }
}
