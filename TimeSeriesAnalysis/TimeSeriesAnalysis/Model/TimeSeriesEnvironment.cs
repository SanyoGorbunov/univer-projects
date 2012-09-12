using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

using LINQtoCSV;

namespace TimeSeriesAnalysis.Model
{

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

        private CsvFileDescription CsvDesc = new CsvFileDescription
        {
            FirstLineHasColumnNames = false,
            EnforceCsvColumnAttribute = true,
            SeparatorChar = ','
        };
        public void ReadFromCsv(string filename)
        {
            TimeSeries = new DataTable();
            CsvContext context = new CsvContext();
            var tsRows = context.Read<OneColumnRecord>(filename, CsvDesc);

            foreach (var tsRow in tsRows)
            {
                if (TimeSeries.Columns.Count < 1)
                {
                    TimeSeries.Columns.Add();
                }
                var newRow = TimeSeries.NewRow();
                newRow[0] = tsRow.Val;
                TimeSeries.Rows.Add(newRow);
            }
        }
        public void SaveToCsv(string filename)
        {
            var rows = TimeSeries.AsEnumerable().Select(
                sdr => new OneColumnRecord { Val = double.Parse(sdr[0].ToString()) });

            CsvContext context = new CsvContext();
            context.Write(rows, filename, CsvDesc);
        }
    }
}
