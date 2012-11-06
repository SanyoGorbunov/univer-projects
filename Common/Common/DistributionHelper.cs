using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public static class DistributionHelper
    {
        public static double GetNormalDistributionQuantile(double alpha)
        {
            double t = Math.Sqrt((-2 * Math.Log(alpha)));
            double c0 = 2.515517, c1 = 0.802853, c2 = 0.010328;
            double d1 = 1.432788, d2 = 0.1832297, d3 = 0.001308;
            double val = t - (c0 + c1 * t + c2 * t * t) / (1 + d1 * t +
                d2 * t * t + d3 * t * t * t);
            return val;
        }

        public static double GetStudentDistributionQuantile(double alpha, double v)
        {
            double u = GetNormalDistributionQuantile(alpha)
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

        public static double ChiSquareDistributionQuantile(double alpha, double v)
        {
            double u = GetNormalDistributionQuantile(alpha);
            double q = v * Math.Pow((1 - 2.0 / 9 / v + u * Math.Sqrt(2.0 / 9 / v)), 3);
            return q;
        }

        public static double GetFisherDistributionQuantile(double alpha, double v1, double v2)
        {
            double r2 = 1 / v2, r1 = 1 / v1
                , delta = r1 - r2, sigma = r1 + r2
                , delta3 = Math.Pow(delta, 3)
                , u = GetNormalDistributionQuantile(alpha)
                , u3 = u * u * u
                , u5 = u3 * u * u;
            double z = u * Math.Sqrt(sigma / 2) - (u * u + 2) * delta / 6
                + Math.Sqrt(sigma / 2) * (sigma * (u * u + 3 * u) / 24 + delta * delta * (u3 + 11 * u) / sigma / 72)
                - sigma * delta * (u3 * u + 9 * u * u + 8) / 120
                + delta3 * (3 * u3 * u + 7 * u * u - 16) / 3240 / sigma
                + Math.Sqrt(sigma / 2) * (sigma * sigma / 1920 * (u5 + 20 * u3 + 15 * u)
                + delta3 * delta / 2880 * (u5 + 44 * u3 + 183 * u)
                + delta3 * delta / 155520 / sigma / sigma * (9 * u5 - 284 * u3 - 1513 * u));
            return Math.Exp(2 * z);
        }
    }
}
