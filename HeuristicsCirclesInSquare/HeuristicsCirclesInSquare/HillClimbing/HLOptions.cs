using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeuristicsCirclesInSquare.HillClimbing
{
    public class HLOptions
    {
        public HLOptions()
        {
            Inc = 2;
            Dec = 0.5;
            Min = 0.00001;
            Eps = 0.125;
            K = 50;
        }

        public int K { get; set; }
        public double Eps { get; set; }
        public double Min { get; set; }

        public double Inc { get; set; }
        public double Dec { get; set; }
    }
}
