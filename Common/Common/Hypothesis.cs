﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class Hypothesis
    {
        public Hypothesis(double statistics, double quantile)
        {
            Statistics = statistics;
            Quantile = quantile;
        }
        public static Hypothesis Normal(double statistics)
        {
            double q = DistributionHelper.GetNormalDistributionQuantile(Globals.Alpha / 2);
            return new Hypothesis(statistics, q);
        }
        public static Hypothesis Student(double statistics, double v)
        {
            double q = DistributionHelper.GetStudentDistributionQuantile(Globals.Alpha / 2, v);
            return new Hypothesis(statistics, q);
        }
        public static Hypothesis Fisher(double statistics, double v1, double v2)
        {
            double q = DistributionHelper.GetFisherDistributionQuantile(Globals.Alpha, v1, v2);
            return new Hypothesis(statistics, q);
        }
        public static Hypothesis ChiSquare(double statistics, double v)
        {
            double q = DistributionHelper.ChiSquareDistributionQuantile(Globals.Alpha, v);
            return new Hypothesis(statistics, q);
        }

        public double Statistics
        {
            get;
            private set;
        }
        public double Quantile
        {
            get;
            private set;
        }
        public bool IsAccepted
        {
            get
            {
                return Math.Abs(Statistics) <= Quantile;
            }
        }
    }

    public class Interval
    {
        public double Value { get; set; }

        public double Upper { get; set; }
        public double Lower { get; set; }
    }
}
