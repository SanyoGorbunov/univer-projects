using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeuristicsCirclesInSquare.HillClimbing
{
    public class HLAlgorithm<T>
    {
        private static List<double> _flog = new List<double>();
        public static List<double> FLog
        {
            get
            {
                return _flog;
            }
        }

        public static T Execute(Func<T, double> target,
            IDecisionSpace<T> space,
            HLOptions opt)
        {
            _flog.Clear();

            double eps = opt.Eps;
            T x = space.GetStarted();
            double f = target(x);
            _flog.Add(f);
            do
            {
                bool found = false;
                for (int i = 0; i < opt.K; i++)
                {
                    T y = space.GetNext(x, eps);
                    double fNew = target(y);
                    if (fNew < f)
                    {
                        f = fNew;
                        x = y;
                        found = true;
                        _flog.Add(f);
                        //System.Console.WriteLine(x.ToString() + " " + f);
                        break;
                    }
                }
                if (found)
                {
                    eps *= opt.Inc;
                }
                else
                {
                    eps *= opt.Dec;
                }
            } while (eps > opt.Min);
            return x;
        }

    }
}
