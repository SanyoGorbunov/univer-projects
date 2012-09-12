namespace TimeSeriesAnalysis.Model
{
    using LINQtoCSV;

    class OneColumnRecord
    {
        [CsvColumn(FieldIndex = 1)]
        public double Val { get; set; }
    }
}
