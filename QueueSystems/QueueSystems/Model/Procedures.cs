using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Common;

namespace QueueSystems.Model
{
    public class Procedures
    {
        #region Result Classes
        public class ExpIntervalsResult: IDataRowConvertable
        {
            public Hypothesis Hyp { get; private set; }
            public double V { get; private set; }
            public ExpIntervalsResult(double v, Hypothesis h)
            {
                V = v;
                Hyp = h;
            }

            private string[] _headers = new string[] { "V", "Statistics", "Quantile", "Result" };
            public string[] Headers
            {
                get { return _headers; }
            }

            public object[] ToDataRow
            {
                get
                {
                    return new object[] { V, Hyp.Statistics, Hyp.Quantile, Hyp.IsAccepted };
                }
            }
        }

        public class HasTrendResult : IDataRowConvertable
        {
            public Hypothesis Hyp { get; private set; }
            public double W { get; private set; }
            public HasTrendResult(double w, Hypothesis h)
            {
                W = w;
                Hyp = h;
            }

            private string[] _headers = new string[] { "W", "Statistics", "Quantile", "Result" };
            public string[] Headers
            {
                get { return _headers; }
            }

            public object[] ToDataRow
            {
                get
                {
                    return new object[] { W, Hyp.Statistics, Hyp.Quantile, Hyp.IsAccepted };
                }
            }
        }

        public class StatEstimationClassResult: IDataRowConvertable
        {
            public StatEstimationClassResult(int cls, ConfidenceInterval conf)
            {
                Class = cls;
                ConfInterval = conf;
            }

            public int Class { get; private set; }
            public ConfidenceInterval ConfInterval { get; private set; }

            private string[] _headers = new string[] { "Class", "Lower", "Value", "Upper" };
            public string[] Headers
            {
                get { return _headers; }
            }

            public object[] ToDataRow
            {
                get { return new object[] { Class, ConfInterval.LowerBound, ConfInterval.Value, ConfInterval.UpperBound }; }
            }
        }
        public class StatEstimationResult
        {
            public StatEstimationResult(List<StatEstimationClassResult> results)
            {
                Results = results;
            }

            public List<StatEstimationClassResult> Results { get; private set; }
        }

        public class PieceConstIntensityClassResult: IDataRowConvertable
        {
            public PieceConstIntensityClassResult(int cls, ConfidenceInterval conf, int ns)
            {
                Class = cls;
                ConfInterval = conf;
                Number = ns;
            }

            public ConfidenceInterval ConfInterval { get; private set; }
            public int Class { get; private set; }
            public int Number { get; private set; }

            private string[] _headers = new string[] { "Class", "Lower", "Intensity", "Upper" };
            public string[] Headers
            {
                get { return _headers; }
            }

            public object[] ToDataRow
            {
                get { return new object[] { Class, ConfInterval.LowerBound, ConfInterval.Value, ConfInterval.UpperBound }; }
            }
        }
        public class PieceConstIntensityResult
        {
            public PieceConstIntensityResult(List<PieceConstIntensityClassResult> results)
            {
                Results = results;
            }

            public List<PieceConstIntensityClassResult> Results { get; private set; }
        }

        public class ParamEstimation : IDataRowConvertable
        {
            public ParamEstimation(string name, double val)
            {
                Name = name;
                Value = val;
            }

            public string Name { get; private set; }
            public double Value { get; private set; }

            public string[] _headers = new string[] { "Param", "Estimation" };
            public string[] Headers
            {
                get { return _headers; }
            }

            public object[] ToDataRow
            {
                get { return new object[] { Name, Value }; }
            }
        }
        public class OLSResult
        {
            public OLSResult(List<ParamEstimation> parameters, Func<double, List<ParamEstimation>, double> f)
            {
                Parameters = parameters;
                SourceFunction = f;
            }

            public Func<double, double> Function
            {
                get
                {
                    return x => SourceFunction(x, Parameters);
                }
            }

            public List<ParamEstimation> Parameters { get; private set; }
            public Func<double, List<ParamEstimation>, double> SourceFunction { get; private set; }
        }

        public class ProbPieceConstIntensityClassResult : IDataRowConvertable
        {
            public ProbPieceConstIntensityClassResult(List<PieceConstIntensityClassResult> results, int cls, double val)
            {
                Results = results;
                Class = cls;
                Value = val;
            }

            public double Value { get; private set; }
            public int Class { get; private set; }
            public List<PieceConstIntensityClassResult> Results { get; private set; }

            private string[] _headers = new string[] { "Class", "Intesity", "Joined" };
            public string[] Headers
            {
                get { return _headers; }
            }

            public object[] ToDataRow
            {
                get { return new object[] { Class, Value, string.Join(", ", Results.Select(x => x.Class)) }; }
            }
        }
        public class ProbPieceConstIntensityResult
        {
            public ProbPieceConstIntensityResult(List<ProbPieceConstIntensityClassResult> results)
            {
                Results = results;
            }

            public List<ProbPieceConstIntensityClassResult> Results { get; private set; }
        }

        public class CompareTwoStreamsResult : IDataRowConvertable
        {
            public CompareTwoStreamsResult (Hypothesis hyp)
	        {
                Hyp = hyp;
	        }

            public Hypothesis Hyp { get; private set; }

            private string[] _headers = new string[] { "Statistics", "Quantile", "Result" };
            public string[] Headers
            {
                get { return _headers; }
            }

            public object[] ToDataRow
            {
                get { return new object[] { Hyp.Statistics, Hyp.Quantile, Hyp.IsAccepted }; }
            }
        }

        public class CompareStreamsResult : IDataRowConvertable
        {
            public CompareStreamsResult(Hypothesis hyp)
            {
                Hyp = hyp;
            }

            public Hypothesis Hyp { get; private set; }

            private string[] _headers = new string[] { "Statistics", "Quantile", "Result" };
            public string[] Headers
            {
                get { return _headers; }
            }

            public object[] ToDataRow
            {
                get { return new object[] { Hyp.Statistics, Hyp.Quantile, Hyp.IsAccepted }; }
            }
        }
        #endregion

        #region Procedures
        public static ExpIntervalsResult ExpIntervals(Queue q)
        {
            int n = q.Count;
            List<double> sorted = q.OrderBy(v => v).ToList();

            List<double> ds = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double d = i == 0 ? sorted[0] : sorted[i] - sorted[i - 1];
                d *= (n - i);
                ds.Add(d);
            }

            double V = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    V += ds[i] > ds[j] ? 1 : ds[i] == ds[j] ? 0.5 : 0;
                }
            }

            double EV = n * (n - 1) / 4.0;
            double SV = Math.Sqrt((2 * n + 5) * (n - 1) * n / 72);
            double u = (V + 0.5 - EV) / SV;

            return new ExpIntervalsResult(V, Hypothesis.Normal(u));
        }

        public static HasTrendResult HasTrend(Queue q)
        {
            int n = q.Count;

            double W = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    W += q[i] < q[j] ? 1 : q[i] == q[j] ? 0.5 : 0;
                }
            }

            double EW = n * (n - 1) / 4.0;
            double SW = Math.Sqrt((2 * n + 5) * (n - 1) * n / 72);
            double u = (W + 0.5 - EW) / SW;

            return new HasTrendResult(W, Hypothesis.Normal(u));
        }

        public static StatEstimationResult StatEstimation(Queue q, int m)
        {
            int n = q.Count;
            List<double> times = q.ToTime;
            double dt = times.Last() / m;

            List<StatEstimationClassResult> intervals = new List<StatEstimationClassResult>();
            double ua = DistributionHelper.GetNormalDistributionQuantile(Globals.Alpha / 2);
            double constantPart = ua * ua / n / dt / 2;
            
            for (int i = 0; i < m; i++)
            {
                int ns = times.Count(x => x >= dt * i && (i == m - 1 || x < dt * (i + 1)));
                double us = ns / dt / n;
                double difPart = ua * Math.Sqrt(ns + ua * ua / 4) / n / dt;
                ConfidenceInterval cnf = new ConfidenceInterval(us, x => x + constantPart - difPart, x => x + constantPart + difPart, dt * i, dt * (i + 1));
                intervals.Add(new StatEstimationClassResult(i + 1, cnf));
            }

            return new StatEstimationResult(intervals);
        }

        public static PieceConstIntensityResult PieceConstIntensity(Queue q, int m)
        {
            int n = q.Count;
            double min = q.Min();
            double dt = (q.Max() - min) / m;

            int Ns = 0;
            List<PieceConstIntensityClassResult> results = new List<PieceConstIntensityClassResult>();
            for (int i = 0; i < m - 1; i++)
            {
                int ns = q.Count(x => x >= min + dt * i && x < min + dt * (i + 1));
                Ns += ns;
                double val = ns / dt / (n - Ns);

                ConfidenceInterval cnf = new ConfidenceInterval(val,
                    x => x * DistributionHelper.ChiSquareDistributionQuantile(Globals.Alpha / 2, 2 * ns) / ns / 2,
                    x => x * DistributionHelper.ChiSquareDistributionQuantile(1 - Globals.Alpha / 2, 2 * ns) / ns / 2,
                    min + dt * i,
                    min + dt * (i + 1));    

                PieceConstIntensityClassResult res = new PieceConstIntensityClassResult(i + 1, cnf, ns);
                results.Add(res);
            }

            return new PieceConstIntensityResult(results);
        }

        public static OLSResult OLS(PieceConstIntensityResult res)
        {
            int index = 0;
            
            List<double> ts = res.Results.Select(x => (x.ConfInterval.Left + x.ConfInterval.Right) / 2).ToList();

            List<ParamEstimation> parameters = new List<ParamEstimation>();
            Func<double, List<ParamEstimation>, double> f = (t, ps) => ps[0].Value + ps[1].Value * t + ps[2].Value * t * t;

            double _t = ts.Average();
            double _t2 = ts.Average(x => x * x);
            double _t3 = ts.Average(x => x * x * x);
            double _t4 = ts.Average(x => x * x * x * x);
            double _l = res.Results.Average(x => x.ConfInterval.Value);
            var qts = res.Results.Zip(ts, (x, t) => new { Index = t, Value = x.ConfInterval.Value });
            double _lt = qts.Average(x => x.Index * x.Value);
            double _lt2 = qts.Average(x => x.Index * x.Index * x.Value);
            List<double> numParams = SlauSolver.Solve(new List<double[]>
            {
                new double[] { 1, _t, _t2 },
                new double[] { _t, _t2, _t3 },
                new double[] { _t2, _t3, _t4 }
            }, new List<double> {
                _l, _lt, _lt2
            });

            parameters.Add(new ParamEstimation("A", numParams[0]));
            parameters.Add(new ParamEstimation("B", numParams[1]));
            parameters.Add(new ParamEstimation("C", numParams[2]));

            return new OLSResult(parameters, f);
        }

        public static ProbPieceConstIntensityResult ProbPieceIntensity(PieceConstIntensityResult res)
        {
            int i = 0, cls = 0;
            List<ProbPieceConstIntensityClassResult> newlst = new List<ProbPieceConstIntensityClassResult>();
            while (i < res.Results.Count)
            {
                cls++;
                List<PieceConstIntensityClassResult> lst = new List<PieceConstIntensityClassResult>();
                lst.Add(res.Results[i]);
                if (i + 1 == res.Results.Count)
                {
                    newlst.Add(new ProbPieceConstIntensityClassResult(lst, cls, res.Results[i].ConfInterval.Value));
                    break;
                }

                int nextNs = res.Results[i].Number;
                double nextL = res.Results[i].ConfInterval.Value;
                do {
                    int _ns = nextNs, ns = res.Results[i + 1].Number;
                    double _l = nextL, l = res.Results[i + 1].ConfInterval.Value;
                    double t = (l - _l) / Math.Sqrt((_ns - 1) * l * l + (ns - 1) * _l * _l) * Math.Sqrt((ns * _ns * (ns + _ns - 2)) / (ns + _ns));
                    Hypothesis h = Hypothesis.Student(t, ns + _ns - 2);
                    if (h.IsAccepted)
                    {
                        nextNs += ns;
                        nextL = (ns * l + _ns * _l) / (ns + _ns);
                        lst.Add(res.Results[i + 1]);
                        i++;
                    }
                    if (!h.IsAccepted || i + 1 == res.Results.Count)
                    {
                        lst.ForEach(x => x.ConfInterval.ChangeValue(nextL));
                        newlst.Add(new ProbPieceConstIntensityClassResult(lst, cls, nextL));
                        i++;
                        break;
                    }
                } while (true);
            }

            return new ProbPieceConstIntensityResult(newlst);
        }

        public static CompareTwoStreamsResult CompareTwoStreams(Queue q1, Queue q2)
        {
            double t1 = q1.Sum(), t2 = q2.Sum();
            int n1 = q1.Count, n2 = q2.Count;

            double R = n1 * t2 / n2 / t1;
            return new CompareTwoStreamsResult(Hypothesis.Fisher(R, 2 * n2, 2 * n1));
        }

        public static CompareStreamsResult CompareStreams(IEnumerable<Queue> qs)
        {
            int n0 = qs.Sum(x => x.Count);
            double t0 = qs.Sum(x => x.Sum());

            double H = 2 * (qs.Sum(x => x.Count * Math.Log(x.Count / x.Sum())) - n0 * Math.Log(n0 / t0));
            return new CompareStreamsResult(Hypothesis.ChiSquare(H, qs.Count() - 1));
        }
        #endregion

    }
}
