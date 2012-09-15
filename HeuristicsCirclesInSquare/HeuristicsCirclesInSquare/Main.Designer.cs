namespace HeuristicsCirclesInSquare
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlBenchmark = new System.Windows.Forms.Panel();
            this.txtBenchmark = new System.Windows.Forms.TextBox();
            this.lblBenchmark = new System.Windows.Forms.Label();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.dgBenchmark = new System.Windows.Forms.DataGridView();
            this.pnlHL = new System.Windows.Forms.Panel();
            this.pnlHLOptions = new System.Windows.Forms.Panel();
            this.lblHLOptions = new System.Windows.Forms.Label();
            this.lblHLK = new System.Windows.Forms.Label();
            this.txtHLK = new System.Windows.Forms.TextBox();
            this.txtHLEps = new System.Windows.Forms.TextBox();
            this.lblHLEps = new System.Windows.Forms.Label();
            this.txtHLMinEps = new System.Windows.Forms.TextBox();
            this.lblHLMinEps = new System.Windows.Forms.Label();
            this.txtHLDec = new System.Windows.Forms.TextBox();
            this.lblHLDec = new System.Windows.Forms.Label();
            this.txtHLInc = new System.Windows.Forms.TextBox();
            this.lblHLInc = new System.Windows.Forms.Label();
            this.btnHLRun = new System.Windows.Forms.Button();
            this.dgSolution = new System.Windows.Forms.DataGridView();
            this.chartFOnIteration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVisualisation = new System.Windows.Forms.Button();
            this.pnlBenchmark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBenchmark)).BeginInit();
            this.pnlHL.SuspendLayout();
            this.pnlHLOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFOnIteration)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBenchmark
            // 
            this.pnlBenchmark.Controls.Add(this.dgBenchmark);
            this.pnlBenchmark.Controls.Add(this.btnBenchmark);
            this.pnlBenchmark.Controls.Add(this.lblBenchmark);
            this.pnlBenchmark.Controls.Add(this.txtBenchmark);
            this.pnlBenchmark.Location = new System.Drawing.Point(12, 12);
            this.pnlBenchmark.Name = "pnlBenchmark";
            this.pnlBenchmark.Size = new System.Drawing.Size(195, 383);
            this.pnlBenchmark.TabIndex = 0;
            // 
            // txtBenchmark
            // 
            this.txtBenchmark.Location = new System.Drawing.Point(30, 17);
            this.txtBenchmark.Name = "txtBenchmark";
            this.txtBenchmark.Size = new System.Drawing.Size(115, 20);
            this.txtBenchmark.TabIndex = 0;
            // 
            // lblBenchmark
            // 
            this.lblBenchmark.AutoSize = true;
            this.lblBenchmark.Location = new System.Drawing.Point(3, 20);
            this.lblBenchmark.Name = "lblBenchmark";
            this.lblBenchmark.Size = new System.Drawing.Size(18, 13);
            this.lblBenchmark.TabIndex = 1;
            this.lblBenchmark.Text = "N:";
            // 
            // btnBenchmark
            // 
            this.btnBenchmark.Location = new System.Drawing.Point(151, 16);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(41, 21);
            this.btnBenchmark.TabIndex = 2;
            this.btnBenchmark.Text = "Read";
            this.btnBenchmark.UseVisualStyleBackColor = true;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);
            // 
            // dgBenchmark
            // 
            this.dgBenchmark.AllowUserToAddRows = false;
            this.dgBenchmark.AllowUserToDeleteRows = false;
            this.dgBenchmark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBenchmark.Location = new System.Drawing.Point(6, 137);
            this.dgBenchmark.Name = "dgBenchmark";
            this.dgBenchmark.ReadOnly = true;
            this.dgBenchmark.Size = new System.Drawing.Size(186, 243);
            this.dgBenchmark.TabIndex = 3;
            // 
            // pnlHL
            // 
            this.pnlHL.Controls.Add(this.btnVisualisation);
            this.pnlHL.Controls.Add(this.chartFOnIteration);
            this.pnlHL.Controls.Add(this.dgSolution);
            this.pnlHL.Controls.Add(this.pnlHLOptions);
            this.pnlHL.Location = new System.Drawing.Point(213, 12);
            this.pnlHL.Name = "pnlHL";
            this.pnlHL.Size = new System.Drawing.Size(515, 383);
            this.pnlHL.TabIndex = 1;
            // 
            // pnlHLOptions
            // 
            this.pnlHLOptions.Controls.Add(this.btnHLRun);
            this.pnlHLOptions.Controls.Add(this.txtHLDec);
            this.pnlHLOptions.Controls.Add(this.lblHLDec);
            this.pnlHLOptions.Controls.Add(this.txtHLInc);
            this.pnlHLOptions.Controls.Add(this.lblHLInc);
            this.pnlHLOptions.Controls.Add(this.txtHLMinEps);
            this.pnlHLOptions.Controls.Add(this.lblHLMinEps);
            this.pnlHLOptions.Controls.Add(this.txtHLEps);
            this.pnlHLOptions.Controls.Add(this.lblHLEps);
            this.pnlHLOptions.Controls.Add(this.txtHLK);
            this.pnlHLOptions.Controls.Add(this.lblHLK);
            this.pnlHLOptions.Controls.Add(this.lblHLOptions);
            this.pnlHLOptions.Location = new System.Drawing.Point(96, 16);
            this.pnlHLOptions.Name = "pnlHLOptions";
            this.pnlHLOptions.Size = new System.Drawing.Size(327, 92);
            this.pnlHLOptions.TabIndex = 0;
            // 
            // lblHLOptions
            // 
            this.lblHLOptions.AutoSize = true;
            this.lblHLOptions.Location = new System.Drawing.Point(13, 13);
            this.lblHLOptions.Name = "lblHLOptions";
            this.lblHLOptions.Size = new System.Drawing.Size(168, 13);
            this.lblHLOptions.TabIndex = 0;
            this.lblHLOptions.Text = "Set Hill Climbing Algorithm options:";
            // 
            // lblHLK
            // 
            this.lblHLK.AutoSize = true;
            this.lblHLK.Location = new System.Drawing.Point(13, 37);
            this.lblHLK.Name = "lblHLK";
            this.lblHLK.Size = new System.Drawing.Size(17, 13);
            this.lblHLK.TabIndex = 1;
            this.lblHLK.Text = "K:";
            // 
            // txtHLK
            // 
            this.txtHLK.Location = new System.Drawing.Point(36, 34);
            this.txtHLK.Name = "txtHLK";
            this.txtHLK.Size = new System.Drawing.Size(56, 20);
            this.txtHLK.TabIndex = 2;
            this.txtHLK.Text = "50";
            // 
            // txtHLEps
            // 
            this.txtHLEps.Location = new System.Drawing.Point(153, 34);
            this.txtHLEps.Name = "txtHLEps";
            this.txtHLEps.Size = new System.Drawing.Size(61, 20);
            this.txtHLEps.TabIndex = 4;
            this.txtHLEps.Text = "0,125";
            // 
            // lblHLEps
            // 
            this.lblHLEps.AutoSize = true;
            this.lblHLEps.Location = new System.Drawing.Point(102, 37);
            this.lblHLEps.Name = "lblHLEps";
            this.lblHLEps.Size = new System.Drawing.Size(34, 13);
            this.lblHLEps.TabIndex = 3;
            this.lblHLEps.Text = "Eps0:";
            // 
            // txtHLMinEps
            // 
            this.txtHLMinEps.Location = new System.Drawing.Point(153, 60);
            this.txtHLMinEps.Name = "txtHLMinEps";
            this.txtHLMinEps.Size = new System.Drawing.Size(61, 20);
            this.txtHLMinEps.TabIndex = 6;
            this.txtHLMinEps.Text = "0,00001";
            // 
            // lblHLMinEps
            // 
            this.lblHLMinEps.AutoSize = true;
            this.lblHLMinEps.Location = new System.Drawing.Point(102, 63);
            this.lblHLMinEps.Name = "lblHLMinEps";
            this.lblHLMinEps.Size = new System.Drawing.Size(45, 13);
            this.lblHLMinEps.TabIndex = 5;
            this.lblHLMinEps.Text = "MinEps:";
            // 
            // txtHLDec
            // 
            this.txtHLDec.Location = new System.Drawing.Point(265, 60);
            this.txtHLDec.Name = "txtHLDec";
            this.txtHLDec.Size = new System.Drawing.Size(57, 20);
            this.txtHLDec.TabIndex = 10;
            this.txtHLDec.Text = "0,5";
            // 
            // lblHLDec
            // 
            this.lblHLDec.AutoSize = true;
            this.lblHLDec.Location = new System.Drawing.Point(229, 63);
            this.lblHLDec.Name = "lblHLDec";
            this.lblHLDec.Size = new System.Drawing.Size(30, 13);
            this.lblHLDec.TabIndex = 9;
            this.lblHLDec.Text = "Dec:";
            // 
            // txtHLInc
            // 
            this.txtHLInc.Location = new System.Drawing.Point(265, 34);
            this.txtHLInc.Name = "txtHLInc";
            this.txtHLInc.Size = new System.Drawing.Size(57, 20);
            this.txtHLInc.TabIndex = 8;
            this.txtHLInc.Text = "2";
            // 
            // lblHLInc
            // 
            this.lblHLInc.AutoSize = true;
            this.lblHLInc.Location = new System.Drawing.Point(229, 37);
            this.lblHLInc.Name = "lblHLInc";
            this.lblHLInc.Size = new System.Drawing.Size(25, 13);
            this.lblHLInc.TabIndex = 7;
            this.lblHLInc.Text = "Inc:";
            // 
            // btnHLRun
            // 
            this.btnHLRun.Location = new System.Drawing.Point(265, 8);
            this.btnHLRun.Name = "btnHLRun";
            this.btnHLRun.Size = new System.Drawing.Size(57, 23);
            this.btnHLRun.TabIndex = 11;
            this.btnHLRun.Text = "Run";
            this.btnHLRun.UseVisualStyleBackColor = true;
            this.btnHLRun.Click += new System.EventHandler(this.btnHLRun_Click);
            // 
            // dgSolution
            // 
            this.dgSolution.AllowUserToAddRows = false;
            this.dgSolution.AllowUserToDeleteRows = false;
            this.dgSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSolution.Location = new System.Drawing.Point(3, 137);
            this.dgSolution.Name = "dgSolution";
            this.dgSolution.ReadOnly = true;
            this.dgSolution.Size = new System.Drawing.Size(186, 243);
            this.dgSolution.TabIndex = 4;
            // 
            // chartFOnIteration
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFOnIteration.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFOnIteration.Legends.Add(legend2);
            this.chartFOnIteration.Location = new System.Drawing.Point(195, 172);
            this.chartFOnIteration.Name = "chartFOnIteration";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFOnIteration.Series.Add(series2);
            this.chartFOnIteration.Size = new System.Drawing.Size(317, 208);
            this.chartFOnIteration.TabIndex = 5;
            this.chartFOnIteration.Text = "chart1";
            // 
            // btnVisualisation
            // 
            this.btnVisualisation.Location = new System.Drawing.Point(294, 137);
            this.btnVisualisation.Name = "btnVisualisation";
            this.btnVisualisation.Size = new System.Drawing.Size(124, 29);
            this.btnVisualisation.TabIndex = 6;
            this.btnVisualisation.Text = "Visualisation";
            this.btnVisualisation.UseVisualStyleBackColor = true;
            this.btnVisualisation.Click += new System.EventHandler(this.btnVisualisation_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 407);
            this.Controls.Add(this.pnlHL);
            this.Controls.Add(this.pnlBenchmark);
            this.Name = "Main";
            this.Text = "Heuristics";
            this.pnlBenchmark.ResumeLayout(false);
            this.pnlBenchmark.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBenchmark)).EndInit();
            this.pnlHL.ResumeLayout(false);
            this.pnlHLOptions.ResumeLayout(false);
            this.pnlHLOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFOnIteration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBenchmark;
        private System.Windows.Forms.DataGridView dgBenchmark;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.Label lblBenchmark;
        private System.Windows.Forms.TextBox txtBenchmark;
        private System.Windows.Forms.Panel pnlHL;
        private System.Windows.Forms.Panel pnlHLOptions;
        private System.Windows.Forms.TextBox txtHLMinEps;
        private System.Windows.Forms.Label lblHLMinEps;
        private System.Windows.Forms.TextBox txtHLEps;
        private System.Windows.Forms.Label lblHLEps;
        private System.Windows.Forms.TextBox txtHLK;
        private System.Windows.Forms.Label lblHLK;
        private System.Windows.Forms.Label lblHLOptions;
        private System.Windows.Forms.TextBox txtHLDec;
        private System.Windows.Forms.Label lblHLDec;
        private System.Windows.Forms.TextBox txtHLInc;
        private System.Windows.Forms.Label lblHLInc;
        private System.Windows.Forms.DataGridView dgSolution;
        private System.Windows.Forms.Button btnHLRun;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFOnIteration;
        private System.Windows.Forms.Button btnVisualisation;
    }
}

