using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeuristicsCirclesInSquare.HillClimbing
{
    public interface IDecisionSpace<Decision>
    {
        Decision GetStarted();

        Decision GetNext(Decision current, double eps);
    }
}
