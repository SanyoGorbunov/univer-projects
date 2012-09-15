using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeuristicsCirclesInSquare.CirclesInSquare
{
    public static class CiSTarget
    {
        public static double F(CiSDecision x)
        {
            double r = double.MaxValue;
            for (int i = 0; i < x.Count; i++)
            {
                r = Math.Min(r, 0.5 - Math.Abs(x.Coords[i].X));
                r = Math.Min(r, 0.5 - Math.Abs(x.Coords[i].Y));
                for (int j = i + 1; j < x.Count; j++)
                {
                    r = Math.Min(r,
                        0.5 * Math.Sqrt(
                        (x.Coords[i].X - x.Coords[j].X) * (x.Coords[i].X - x.Coords[j].X) +
                        (x.Coords[i].Y - x.Coords[j].Y) * (x.Coords[i].Y - x.Coords[j].Y)));
                }
            }
            return 1.0 - r;
        }
        public static double R(CiSDecision x)
        {
            return 1.0 - F(x);
        }
    }
}
