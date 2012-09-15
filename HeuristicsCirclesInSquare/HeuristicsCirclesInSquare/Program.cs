using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HeuristicsCirclesInSquare
{
    using CirclesInSquare;
    using HillClimbing;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //CiSDecision x = Algorithm<CiSDecision>.Execute(CiSTarget.F,
            //    new CiSDecisionSpace(10),
            //    0.125,
            //    25,
            //    0.00001);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
