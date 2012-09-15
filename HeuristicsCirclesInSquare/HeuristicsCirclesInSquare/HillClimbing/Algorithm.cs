using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeuristicsCirclesInSquare.HillClimbing
{
    public class Algorithm<T>
    {
        public static T Execute(Func<T, double> target,
            IDecisionSpace<T> space,
            double eps,
            int k,
            double min)
        {
            T x = space.GetStarted();
            double f = target(x);
            do
            {
                bool found = false;
                for (int i = 0; i < k; i++)
                {
                    T y = space.GetNext(x, eps);
                    double fNew = target(y);
                    if (fNew < f)
                    {
                        f = fNew;
                        x = y;
                        found = true;
                        System.Console.WriteLine(x.ToString() + " " + f);
                        break;
                    }
                }
                if (found)
                {
                    eps *= 2;
                }
                else
                {
                    eps /= 2;
                }
            } while (eps > min);
            return x;
        }

    }
}
