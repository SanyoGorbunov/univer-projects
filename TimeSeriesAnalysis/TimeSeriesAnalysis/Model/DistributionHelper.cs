using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeSeriesAnalysis.Model
{
    static class DistributionHelper
    {
        public static double GetNormalDistributionQuantile(double alpha)
        {
            double t = Math.Sqrt((-2 * Math.Log(alpha / 2)));
            double c0 = 2.515517, c1 = 0.802853, c2 = 0.010328;
            double d1 = 1.432788, d2 = 0.1832297, d3 = 0.001308;
            double val = t - (c0 + c1 * t + c2 * t * t) / (1 + d1 * t +
                d2 * t * t + d3 * t * t * t);
            return val;
        }

        public static double GetStudentDistributionQuantile(double alpha, double v)
        {
            double u = GetNormalDistributionQuantile(alpha / 2)
                , u3 = u * u * u
                , u5 = u3 * u * u
                , u7 = u5 * u * u
                , u9 = u7 * u * u
                , g1 = (u3 + u) / 4
                , g2 = (5 * u5 + 16 * u3 + 3 * u) / 96
                , g3 = (3 * u7 + 19 * u5 + 17 * u3 - 15 * u) / 384
                , g4 = (79 * u9 + 779 * u7 + 1482 * u5
                    - 1920 * u3 - 945 * u) / 92160;
            double q = u + g1 / v + g2 / v / v + g3 / v / v / v
                + g4 / v / v / v / v;
            return q;
        }
    }
}
