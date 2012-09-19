using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSeriesAnalysis.Model
{
    using Common;

    public static class RandomExcerptChecker
    {
        public class Result
        {
            public Result(double quantile, double statistics)
            {
                Quantile = quantile;
                Statistics = statistics;
                IsRandom = Math.Abs(Statistics) <= Quantile;
            }

            public double Quantile { get; private set; }
            public double Statistics { get; private set; }
            public bool IsRandom { get; private set; }
        }

        public static Result TestSignsMethod(List<double> excerpt)
        {
            double l = 0,
                m = (excerpt.Count - 1) / 2,
                d = (excerpt.Count + 1) / 12;
            for (int i = 0; i < excerpt.Count-1; i++)
            {
                if (excerpt[i] == excerpt[i + 1])
                {
                    l += 0.5;
                }
                else if (excerpt[i] > excerpt[i + 1])
                {
                    l += 1;
                }
            }
            double u = (l - m) / Math.Sqrt(d);
            double q = DistributionHelper.GetNormalDistributionQuantile(TimeSeriesEnvironment.Current.Alpha);
            return new Result(q, u);
        }
        public static Result TestSpearmanMethod(List<double> excerpt)
        {
            double[,] h = new double[excerpt.Count - 1, excerpt.Count - 1];
            for (int i = 0; i < excerpt.Count - 1; i++)
            {
                for (int j = i + 1; j < excerpt.Count; j++)
                {
                    if (excerpt[i] == excerpt[j])
                    {
                        h[i, j - 1] = 0.5;
                    }
                    else if (excerpt[i] < excerpt[j])
                    {
                        h[i, j - 1] = 1;
                    }
                }
            }
            double v = 0;
            for (int i = 0; i < excerpt.Count - 1; i++)
            {
                for (int j = i + 1; j < excerpt.Count; j++)
                {
                    v += (j - 1) * h[i, j - 1];
                }
            }
            double rc = 1 - 12 * v / excerpt.Count / (excerpt.Count * excerpt.Count - 1);
            double d = 1.0 / (excerpt.Count - 1);
            double s = rc / Math.Sqrt(d);
            double q = DistributionHelper.GetNormalDistributionQuantile(TimeSeriesEnvironment.Current.Alpha);
            return new Result(q, s);
        }
        public static List<double> GetCorrelogram(List<double> excerpt, int k)
        {
            // sum of all elements
            double sum = excerpt.Sum();
            // init lsum (only left elements) and rsum (only right elements)
            // theirs size will be decreased
            double lsum = sum, rsum = sum;
            List<double> crl = new List<double> { 1 };
            for (int i = 1; i <= k; i++)
            {
                // subtract last left element from rsum
                rsum -= excerpt[i - 1];
                // subtract last right element from lsum 
                lsum -= excerpt[excerpt.Count - i];
                // reduction of sum by dividing by N-K
                double rusum = rsum / (excerpt.Count - i), lusum = lsum / (excerpt.Count - i);
                // abv is expression in numerator

                double abv = 0, lund = 0, rund = 0;
                for (int j = 0; j < excerpt.Count - i; j++)
                {
                    abv += (excerpt[j] - lusum) * (excerpt[j + i] - rusum);
                    lund += (excerpt[j] - lusum) * (excerpt[j] - lusum);
                    rund += (excerpt[j + i] - rusum) * (excerpt[j + i] - rusum);
                }
                double und = Math.Sqrt(rund * lund);
                double val = abv == und ? 1.0 : abv / und;
                crl.Add(val);
            }
            return crl;
        }
        public static Result TestCorrelation(double r, int n, int k)
        {
            double q = DistributionHelper.GetStudentDistributionQuantile(
                TimeSeriesEnvironment.Current.Alpha,
                n - k - 2);
            double t = r * Math.Sqrt(n - k - 2) / Math.Sqrt(1 - r * r);
            return new Result(q, t);
        }
    }
}
