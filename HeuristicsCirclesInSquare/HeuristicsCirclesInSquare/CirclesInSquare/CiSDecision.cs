using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeuristicsCirclesInSquare.CirclesInSquare
{
    using System.IO;

    public class CiSDecision
    {
        private CiSDecision()
        {
        }
        public CiSDecision(int n)
        {
            Random random = new Random();
            Coords = new List<CiSPoint>();

            for (int i = 0; i < n; i++)
            {
                CiSPoint point = new CiSPoint
                {
                    X = random.NextDouble() - 0.5,
                    Y = random.NextDouble() - 0.5
                };
                Coords.Add(point);
            }
        }
        public CiSDecision Copy()
        {
            CiSDecision x = new CiSDecision();
            x.Coords = new List<CiSPoint>();
            foreach (var point in Coords)
            {
                x.Coords.Add(new CiSPoint
                {
                    X = point.X,
                    Y = point.Y
                });
            }
            return x;
        }

        private static string GetPathToDataFile(int n)
        {
            return Path.GetFullPath(string.Format("{0}../../Data/csq{1}.txt",
                AppDomain.CurrentDomain.BaseDirectory,
                n));
        }
        public static CiSDecision ReadFromFile(int n)
        {
            CiSDecision x = new CiSDecision();
            x.Coords = new List<CiSPoint>();
            string[] vals = File.
                ReadAllText(GetPathToDataFile(n)).Replace('.', ',').
                Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(vals[i * 3]) == i + 1)
                {
                    x.Coords.Add(new CiSPoint
                    {
                        X = double.Parse(vals[i * 3 + 1]),
                        Y = double.Parse(vals[i * 3 + 2])
                    });
                }
            }
            return x;
        }

        public List<CiSPoint> Coords { get; set; }
        public int Count
        {
            get
            {
                return Coords.Count;
            }
        }

        public double R
        {
            get
            {
                return CiSTarget.R(this);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                sb.AppendFormat("{0}. {1:0.000} {2:0.000}\n", i + 1, Coords[i].X, Coords[i].Y);
            }
            return sb.ToString();
        }
    }
}
