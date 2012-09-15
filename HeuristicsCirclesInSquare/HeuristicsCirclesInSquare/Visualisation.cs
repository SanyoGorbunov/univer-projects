using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HeuristicsCirclesInSquare
{
    using CirclesInSquare;

    public partial class Visualisation : Form
    {
        public CiSDecision Benchmark { get; set; }
        public CiSDecision Solution { get; set; }

        public Visualisation()
        {
            InitializeComponent();
        }

        private void Visualisation_Activated(object sender, EventArgs e)
        {
            pbSquare.Refresh();
        }

        private void pbSquare_Paint(object sender, PaintEventArgs e)
        {
            double br = Benchmark.R,
                sr = Solution.R;
            Brush bBrush = new SolidBrush(Color.FromArgb(100, Color.Blue)),
                sBrush = new SolidBrush(Color.FromArgb(100, Color.Red));
            int w = (sender as PictureBox).Width,
                h = (sender as PictureBox).Height;
            foreach (var point in Benchmark.Coords)
            {
                e.Graphics.FillEllipse(bBrush,
                    (float)(w * (0.5 + point.X - br)),
                    (float)(h * (0.5 + point.Y - br)),
                    (float)(2 * w * br),
                    (float)(2 * h * br));
            }
            foreach (var point in Solution.Coords)
            {
                e.Graphics.FillEllipse(sBrush,
                    (float)(w * (0.5 + point.X - sr)),
                    (float)(h * (0.5 + point.Y - sr)),
                    (float)(2 * w * sr),
                    (float)(2 * h * sr));
            }
        }
    }
}
