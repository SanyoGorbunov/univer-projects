using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using Common;
using QueueSystems.Model;

namespace QueueSystems
{
    public partial class TMO : Form
    {
        private Queue q;
        private Procedures.PieceConstIntensityResult pcir;
        private Procedures.ProbPieceConstIntensityResult ppcir;

        public TMO()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dlgOpen.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                q = FileIO.ReadFromFile<Queue>(dlgOpen.FileName);
                dgQueue.FillTable(q);
                chtQueue.AddChart("Queue", q, true);
            }
        }

        private void btnExpIntervals_Click(object sender, EventArgs e)
        {
            dgResult.FillTable(Procedures.ExpIntervals(q));
        }

        private void btnSetAlpha_Click(object sender, EventArgs e)
        {
            double alpha;
            if (double.TryParse(txtAlpha.Text, out alpha))
            {
                Globals.Alpha = alpha;
            }
            else
            {
                MessageBox.Show("Incorrect numeric expression for Alpha.");
            }
        }

        private void btnHasTrend_Click(object sender, EventArgs e)
        {
            dgResult.FillTable(Procedures.HasTrend(q));
        }

        private void btnStatEstimation_Click(object sender, EventArgs e)
        {
            int m;
            if (int.TryParse(txtClasses.Text, out m))
            {
                var res = Procedures.StatEstimation(q, m);
                dgResult.FillTable(res.Results);
                chtQueue.AddConfIntervals(res.Results.Select(x => x.ConfInterval));
            }
            else
            {
                MessageBox.Show("Incorrect numeric expression for number of classes.");
            }
        }

        private void btnPieceConstIntensity_Click(object sender, EventArgs e)
        {
            int m;
            if (int.TryParse(txtClasses.Text, out m))
            {
                pcir = Procedures.PieceConstIntensity(q, m);
                dgResult.FillTable(pcir.Results);
                chtQueue.AddConfIntervals(pcir.Results.Select(x => x.ConfInterval));
            }
            else
            {
                MessageBox.Show("Incorrect numeric expression for number of classes.");
            }
        }

        private void btnOLS_Click(object sender, EventArgs e)
        {
            var res = Procedures.OLS(pcir);
            dgResult.FillTable(res.Parameters);
            chtQueue.AddChart("Approximation",
                res.Function,
                pcir.Results.First().ConfInterval.Left,
                pcir.Results.Last().ConfInterval.Right,
                2);
        }

        private void btnShowDF_Click(object sender, EventArgs e)
        {
            var res = Procedures.OLS(pcir);
            double sum = 0.0;
            int n = 0;
            chtQueue.AddChart("Distribution Function",
                x =>
                {
                    n++;
                    sum += n * res.Function(x);
                    return 1 - Math.Exp(-sum / n);
                },
                pcir.Results.First().ConfInterval.Left,
                pcir.Results.Last().ConfInterval.Right,
                0.2,
                true);
        }

        private void btnProbPieceConstIntensity_Click(object sender, EventArgs e)
        {
            ppcir = Procedures.ProbPieceIntensity(pcir);
            dgResult.FillTable(ppcir.Results);
            chtQueue.AddConfIntervals(ppcir.Results.SelectMany(x => x.Results).Select(x => x.ConfInterval));
        }

        private void btnShowProbDF_Click(object sender, EventArgs e)
        {
            chtQueue.AddChart("Distribution Function",
                x => {
                    int i = 0;
                    var prt = ppcir.Results[i];
                    double sum = 0;
                    while (x > prt.Results.Last().ConfInterval.Right)
                    {
                        sum += (prt.Value - ppcir.Results[i + 1].Value) * prt.Results.Last().ConfInterval.Right;
                        i++;
                        prt = ppcir.Results[i];
                    }
                    return 1 - Math.Exp(-prt.Value * x - sum);
                },
                ppcir.Results.First().Results.First().ConfInterval.Left,
                ppcir.Results.Last().Results.Last().ConfInterval.Right,
                2,
                true);
        }

        private void btnShowStreams_Click(object sender, EventArgs e)
        {
            Streams frmStreams = new Streams(q);
            frmStreams.Show();
        }

    }
}
