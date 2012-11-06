using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Common;
using QueueSystems.Model;

namespace QueueSystems
{
    public partial class Streams : Form
    {
        private Queue q;
        private List<Queue> qs; 

        public Streams(Queue q)
        {
            this.q = q;
            InitializeComponent();
        }

        private void btnDivideStreams_Click(object sender, EventArgs e)
        {
            int k;
            qs = new List<Queue>();
            if (int.TryParse(txtDivideStreams.Text, out k))
            {
                ddFirstStream.Items.Clear();
                ddSecondStream.Items.Clear();
                int n = q.Count / k;
                for (int i = 0; i < k; i++)
                {
                    qs.Add(new Queue(q.Skip(n * i).Take(n)));
                    ddFirstStream.Items.Add("Stream #" + (i + 1));
                    ddSecondStream.Items.Add("Stream #" + (i + 1));
                }
                dgStreams.FillTable(qs, "Stream");
            }
            else
            {
                MessageBox.Show("Incorrect numeric expression for number of streams.");
            }
        }

        private void btnShowIntensities_Click(object sender, EventArgs e)
        {
            dgResult.FillTable(qs.Select(x => x.Intensity));
        }

        private void btnCompareTwoStreams_Click(object sender, EventArgs e)
        {
            Queue first = qs[ddFirstStream.SelectedIndex];
            Queue second = qs[ddSecondStream.SelectedIndex];

            var res = Procedures.CompareTwoStreams(first, second);
            dgResult.FillTable(res);
        }

        private void btnCompareStreams_Click(object sender, EventArgs e)
        {
            dgResult.FillTable(Procedures.CompareStreams(qs));
        }
    }
}
