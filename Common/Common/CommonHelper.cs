using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Common
{

    public static class CommonHelper
    {

        public static void FillTable(this DataGridView dg, IEnumerable<double> values)
        {
            dg.Columns.Clear();
            dg.Columns.Add("Index", "#");
            dg.Columns.Add("Value", "Value");

            int index = 0;
            foreach (var val in values)
            {
                index++;
                dg.Rows.Add(index, val);
            }

            dg.AutoResizeColumns();
        }
        public static void FillTable(this DataGridView dg, IEnumerable<IEnumerable<double>> values, string columnName)
        {
            dg.Columns.Clear();
            for (int i = 0; i < values.Count(); i++)
            {
                dg.Columns.Add(columnName.Replace(" ", string.Empty) + i, columnName + " " + (i + 1));
            }
            dg.Rows.Add(values.First().Count());

            for (int i = 0; i < values.Count(); i++)
            {
                var col = values.ElementAt(i);
                for (int j = 0; j < col.Count(); j++)
                {
                    dg[i, j].Value = col.ElementAt(j);
                }
            }

            dg.AutoResizeColumns();
        }
        public static void FillTable(this DataGridView dg, IDataRowConvertable res)
        {
            dg.Columns.Clear();
            foreach (var header in res.Headers)
            {
                dg.Columns.Add(header, header);
            }

            dg.Rows.Add(res.ToDataRow);

            dg.AutoResizeColumns();
        }
        public static void FillTable(this DataGridView dg, IEnumerable<IDataRowConvertable> results)
        {
            dg.Columns.Clear();
            foreach (var header in results.First().Headers)
            {
                dg.Columns.Add(header, header);
            }

            foreach (var res in results)
            {
                dg.Rows.Add(res.ToDataRow);
            }

            dg.AutoResizeColumns();
        }


        public static void AddChart(this Chart chart, string name, IEnumerable<double> values, bool clean = false)
        {
            if (clean)
            {
                chart.Series.Clear();
            }

            Series s = new Series(name);
            foreach (var val in values)
            {
                s.Points.AddY(val);
            }
            chart.Series.Add(s);

            chart.ResetAutoValues();
        }
        public static void AddConfIntervals(this Chart chart, IEnumerable<ConfidenceInterval> intervals)
        {
            chart.Series.Clear();
            Series range = new Series("Range") { ChartType = SeriesChartType.Range, Color = Color.FromArgb(40, Color.Firebrick) };
            Series values = new Series("Values") { ChartType = SeriesChartType.FastLine };

            foreach (var intrvl in intervals)
            {
                range.Points.Add(new DataPoint(intrvl.Left, new double[] { intrvl.LowerBound, intrvl.UpperBound }));
                range.Points.Add(new DataPoint(intrvl.Right, new double[] { intrvl.LowerBound, intrvl.UpperBound }));
                values.Points.AddXY(intrvl.Left, intrvl.Value);
                values.Points.AddXY(intrvl.Right, intrvl.Value);
            }

            chart.Series.Add(range);
            chart.Series.Add(values);
        }
        public static void AddChart(this Chart chart, string name, Func<double, double> f, double lft, double rgt, double step, bool clean = false)
        {
            if (clean)
            {
                chart.Series.Clear();
            }

            Series s = new Series(name) { ChartType = SeriesChartType.Spline };
            double x = lft;
            while (x <= rgt)
            {
                s.Points.AddXY(x, f(x));
                x += step;
            }

            chart.Series.Add(s);
            chart.ResetAutoValues();
        }

    }

    public interface IStringParsable
    {

        void Parse(string source);

        string ToStringSource();

    }

    public interface IDataRowConvertable
    {

        string[] Headers { get; }
        object[] ToDataRow { get; }

    }

    public static class FileIO
    {

        public static T ReadFromFile<T>(string path) where T : IStringParsable, new()
        {
            using (FileStream fs = File.OpenRead(path))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    T dest = new T();
                    dest.Parse(sr.ReadToEnd());
                    return dest;
                }
            }
        }

        public static void WriteToFile<T>(T source, string path) where T : IStringParsable
        {
            using (FileStream fs = File.Create(path))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(source.ToStringSource());
                }
            }
        }

    }

    public static class SlauSolver
    {
        public static List<double> Solve(List<double[]> a, List<double> b)
        {
            for (int j = 0; j < a.First().Length - 1; j++)
            {
                for (int i = j + 1; i < a.Count; i++)
                {
                    double cf = -a[i][j] / a[j][j];
                    a[i][j] = 0;
                    for (int k = j + 1; k < a.First().Length; k++)
                    {
                        a[i][k] += a[j][k] * cf;
                    }
                    b[i] += b[j] * cf;
                }
            }
            for (int j = a.First().Length - 1; j > 0; j--)
            {
                for (int i = j - 1; i >= 0; i--)
                {
                    double cf = -a[i][j] / a[j][j];
                    a[i][j] = 0;
                    for (int k = j - 1; k >= 0; k--)
                    {
                        a[i][k] += a[j][k] * cf;
                    }
                    b[i] += b[j] * cf;
                }
            }

            List<double> ans = new List<double>();
            for (int i = 0; i < a.First().Length; i++)
            {
                ans.Add(b[i] / a[i][i]);
            }
            return ans;
        }
    }

}
