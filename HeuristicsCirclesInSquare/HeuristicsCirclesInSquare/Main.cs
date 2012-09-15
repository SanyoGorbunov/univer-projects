using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HeuristicsCirclesInSquare
{
    using CirclesInSquare;
    using HillClimbing;

    public partial class Main : Form
    {
        private int N { get; set; }
        private CiSDecision Benchmark { get; set; }
        private CiSDecision Solution { get; set; }
        private const string IndexColumnName = "Index";
        private const string FirstValueColumnName = "X";
        private const string SecondValueColumnName = "Y";
        private void DisplayDecisionOnDatagrid(DataGridView dg, CiSDecision x)
        {
            dg.Columns.Clear();
            dg.Columns.Add(IndexColumnName, IndexColumnName);
            dg.Columns.Add(FirstValueColumnName, FirstValueColumnName);
            dg.Columns.Add(SecondValueColumnName, SecondValueColumnName);
            dg.Rows.Add(x.Count);

            for (int i = 0; i < x.Count; i++)
            {
                dg[IndexColumnName, i].Value = i + 1;
                dg[FirstValueColumnName, i].Value = x.Coords[i].X;
                dg[SecondValueColumnName, i].Value = x.Coords[i].Y;
            }
        }
        private HLOptions CreateHLOptions()
        {
            HLOptions opt = new HLOptions();
            int iVal; double dVal;
            if (int.TryParse(txtHLK.Text, out iVal))
            {
                opt.K = iVal;
            }
            else
            {
                MessageBox.Show(string.Format("K is not in valid format. {0} is used.", opt.K));
            }
            if (double.TryParse(txtHLEps.Text, out dVal))
            {
                opt.Eps = dVal;
            }
            else
            {
                MessageBox.Show(string.Format("Eps is not in valid format. {0} is used.", opt.Eps));
            }
            if (double.TryParse(txtHLMinEps.Text, out dVal))
            {
                opt.Min = dVal;
            }
            else
            {
                MessageBox.Show(string.Format("Min is not in valid format. {0} is used.", opt.Min));
            }
            if (double.TryParse(txtHLInc.Text, out dVal))
            {
                opt.Inc = dVal;
            }
            else
            {
                MessageBox.Show(string.Format("Inc is not in valid format. {0} is used.", opt.Inc));
            }
            if (double.TryParse(txtHLDec.Text, out dVal))
            {
                opt.Dec = dVal;
            }
            else
            {
                MessageBox.Show(string.Format("Dec is not in valid format. {0} is used.", opt.Dec));
            }
            return opt;
        }
        private void DisplayChartFOnIteration(Chart chart, List<double> fList)
        {
            Series fOnIter = new Series
            {
                ChartType = SeriesChartType.Line
            };
            for (int i = 0; i < fList.Count; i++)
            {
                fOnIter.Points.AddXY(i, fList[i]);
            }

            chart.Series.Clear();
            chart.Series.Add(fOnIter);
            chart.ResetAutoValues();
        }
        private Visualisation vForm = new Visualisation();

        public Main()
        {
            InitializeComponent();
        }

        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtBenchmark.Text, out n))
            {
                N = n;
                Benchmark = CiSDecision.ReadFromFile(n);
                DisplayDecisionOnDatagrid(dgBenchmark, Benchmark);
            }
            else
            {
                MessageBox.Show("N is not valid integer.");
            }
        }

        private void btnHLRun_Click(object sender, EventArgs e)
        {
            HLOptions opt = CreateHLOptions();
            Solution = HLAlgorithm<CiSDecision>.Execute(
                CiSTarget.F,
                new CiSDecisionSpace(N),
                opt);
            DisplayDecisionOnDatagrid(dgSolution, Solution);
            DisplayChartFOnIteration(chartFOnIteration, HLAlgorithm<CiSDecision>.FLog);
        }

        private void btnVisualisation_Click(object sender, EventArgs e)
        {
            vForm.Benchmark = Benchmark;
            vForm.Solution = Solution;
            vForm.Show();
        }
    }
}
