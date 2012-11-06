using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class ConfidenceInterval
    {
        public ConfidenceInterval(double val, Func<double, double> low, Func<double, double> upper, double left, double right)
        {
            Value = val;
            LowerBound = low(val);
            UpperBound = upper(val);

            Left = left;
            Right = right;
        }

        public double Value { get; private set; }
        public double LowerBound { get; private set; }
        public double UpperBound { get; private set; }

        public double Left { get; private set; }
        public double Right { get; private set; }

        public void ChangeValue(double newValue)
        {
            Value = newValue;
        }
    }
}
