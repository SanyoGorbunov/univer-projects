using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeSeriesAnalysis
{
    using LINQtoCSV;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //CsvFileDescription desc = new CsvFileDescription
                //{
                //    SeparatorChar = ','
                //};
                CsvContext context = new CsvContext();
                IEnumerable<DataRow> rows = context.Read<DataRow>(dialog.FileName);
                foreach (var row in rows)
                {
                    
                }
            }
        }
    }
}
