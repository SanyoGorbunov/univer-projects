using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using LINQtoCSV;

namespace TimeSeriesAnalysis.Model
{
    using ltc = LINQtoCSV;

    public class TimeSeriesEnvironment
    {
        private static TimeSeriesEnvironment _current;
        public static TimeSeriesEnvironment Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new TimeSeriesEnvironment()
                    {
                        Alpha = 0.05
                    };
                }
                return _current;
            }
        }

        public double Alpha { get; set; }
        public DataTable TimeSeries { get; set; }

        public void ReadFromCsv(string filename)
        {
            TimeSeries = new DataTable();
            CsvContext context = new CsvContext();
            IEnumerable<ltc.DataRow> tsRows = context.Read<ltc.DataRow>(filename);

            foreach (var tsRow in tsRows)
            {
                if (tsRow.Count > TimeSeries.Columns.Count)
                {
                    for (int i = 0; i < tsRow.Count - TimeSeries.Columns.Count; i++)
                    {
                        TimeSeries.Columns.Add();
                    }
                }
                var newRow = TimeSeries.NewRow();
                for (int i = 0; i < tsRow.Count; i++)
                {
                    newRow[i] = double.Parse(tsRow[i].Value);
                }
                TimeSeries.Rows.Add(newRow);
            }
        }
    }
}
