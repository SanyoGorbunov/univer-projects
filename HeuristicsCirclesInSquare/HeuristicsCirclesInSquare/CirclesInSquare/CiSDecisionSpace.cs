using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeuristicsCirclesInSquare.CirclesInSquare
{
    using HillClimbing;

    public class CiSDecisionSpace: IDecisionSpace<CiSDecision>
    {
        public int N { get; set; }
        private Random random;

        public CiSDecisionSpace(int n)
        {
            N = n;
            random = new Random();
        }

        public CiSDecision GetStarted()
        {
            return new CiSDecision(N);
        }

        public CiSDecision GetNext(CiSDecision current, double eps)
        {
            CiSDecision cpy = current.Copy();
            for (int i = 0; i < N; i++)
            {
                double x = current.Coords[i].X, y = current.Coords[i].Y;
                do
                {
                    x += (random.NextDouble() - 0.5) * eps;
                } while (x < -0.5 || x > 0.5);
                cpy.Coords[i].X = x;
                do
                {
                    y += (random.NextDouble() - 0.5) * eps;
                } while (y < -0.5 || y > 0.5);
                cpy.Coords[i].Y = y;
            }
            return cpy;
        }
    }
}
