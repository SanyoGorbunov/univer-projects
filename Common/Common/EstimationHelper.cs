using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    static class EstimationHelper
    {
        public static double CalculateExpectedValue(List<double> excerpt)
        {
            return excerpt.Sum() / excerpt.Count;
        }
        public static double CalculateDispersion(List<double> excerpt)
        {
            double ev = CalculateExpectedValue(excerpt);
            return excerpt.Sum(val => (val - ev) * (val - ev)) / (excerpt.Count - 1);
        }
    }
}
