using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TimeSeriesAnalysis
{
    using LINQtoCSV;
    using TimeSeriesAnalysis.Model;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadTSOpenDlg_Click(object sender, EventArgs e)
        {
            if (dlgOpenTS.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtLoadTS.Text = dlgOpenTS.FileName;
            }
        }

        private void btnLoadTSRead_Click(object sender, EventArgs e)
        {
            TimeSeriesEnvironment.Current.ReadFromCsv(txtLoadTS.Text);
            dgTS.DataSource = TimeSeriesEnvironment.Current.TimeSeries;
            btnShowCorrelogram.Visible = true;
        }

        private void btnSignsTest_Click(object sender, EventArgs e)
        {
            var res = RandomExcerptChecker.TestSignsMethod(
                (new TimeSeries(TimeSeriesEnvironment.Current.TimeSeries, false)).Excerpt);
            lblSignsStat.Text = string.Format("|{0}|",res.Statistics);
            lblSignsQuantile.Text = res.Quantile.ToString();
            if (res.IsRandom)
            {
                lblSignsComp.Text = "≤";
                lblSignsResult.Text = "Time series is random.";
            }
            else
            {
                lblSignsComp.Text = ">";
                lblSignsResult.Text = "Time series has trend.";
            }
            pnlSignsTest.Visible = true;
        }

        private void btnTestSpearman_Click(object sender, EventArgs e)
        {
            var res = RandomExcerptChecker.TestSpearmanMethod(
                (new TimeSeries(TimeSeriesEnvironment.Current.TimeSeries, false)).Excerpt);
            lblSpearmanStat.Text = string.Format("|{0}|", res.Statistics);
            lblSpearmanQuantile.Text = res.Quantile.ToString();
            if (res.IsRandom)
            {
                lblSpearmanComp.Text = "≤";
                lblSpearmanTest.Text = "Time series is random.";
            }
            else
            {
                lblSpearmanComp.Text = ">";
                if (res.Statistics < 0)
                {
                    lblSpearmanTest.Text = "Time series has decreasing trend.";
                }
                else
                {
                    lblSpearmanTest.Text = "Time series has increasing trend.";
                }
            }
            pnlSpearmanTest.Visible = true;
        }

        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            var series = (new TimeSeries(TimeSeriesEnvironment.Current.TimeSeries, false)).Data;
            Series hist = new Series("TS Histogram")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (var item in series)
            {
                hist.Points.AddXY(item.Time, item.Value);
            }

            chartTS.Series.Clear();
            chartTS.Series.Add(hist);
            chartTS.ResetAutoValues();
        }

        private void btnShowCorrelogram_Click(object sender, EventArgs e)
        {
            var ts = new TimeSeries(TimeSeriesEnvironment.Current.TimeSeries, false);

            int k;
            if (!int.TryParse(txtCorrelogramK.Text, out k) || k < 0 || k > ts.Count - 1)
            {
                MessageBox.Show("Incorrect K variable for processing correlogram.");
                return;
            }

            var cor = RandomExcerptChecker.GetCorrelogram(ts.Excerpt, k);

            Series crlgrm = new Series("TS Corelogram")
            {
                ChartType = SeriesChartType.Column
            };
            for (int i = 0; i < cor.Count; i++)
            {
                crlgrm.Points.AddXY(i, cor[i]);
            }

            chartTS.Series.Clear();
            chartTS.Series.Add(crlgrm);
            chartTS.ResetAutoValues();
        }
    }
}
