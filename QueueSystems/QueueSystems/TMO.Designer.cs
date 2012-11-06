namespace QueueSystems
{
    partial class TMO
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgQueue = new System.Windows.Forms.DataGridView();
            this.chtQueue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.btnExpIntervals = new System.Windows.Forms.Button();
            this.pnlAlpha = new System.Windows.Forms.Panel();
            this.btnSetAlpha = new System.Windows.Forms.Button();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.btnHasTrend = new System.Windows.Forms.Button();
            this.pnlClasses = new System.Windows.Forms.Panel();
            this.lblClasses = new System.Windows.Forms.Label();
            this.txtClasses = new System.Windows.Forms.TextBox();
            this.btnStatEstimation = new System.Windows.Forms.Button();
            this.btnPieceConstIntensity = new System.Windows.Forms.Button();
            this.btnOLS = new System.Windows.Forms.Button();
            this.btnShowDF = new System.Windows.Forms.Button();
            this.btnProbPieceConstIntensity = new System.Windows.Forms.Button();
            this.btnShowProbDF = new System.Windows.Forms.Button();
            this.btnShowStreams = new System.Windows.Forms.Button();
            this.lblExpIntervals = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatEstimation = new System.Windows.Forms.Label();
            this.lblPieceConstIntensity = new System.Windows.Forms.Label();
            this.lblOLS = new System.Windows.Forms.Label();
            this.lblProbPieceConstIntensity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.pnlAlpha.SuspendLayout();
            this.pnlClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            this.dlgOpen.InitialDirectory = "/";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 66);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(240, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Queue";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgQueue
            // 
            this.dgQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQueue.Location = new System.Drawing.Point(12, 95);
            this.dgQueue.Name = "dgQueue";
            this.dgQueue.Size = new System.Drawing.Size(240, 394);
            this.dgQueue.TabIndex = 1;
            // 
            // chtQueue
            // 
            chartArea1.Name = "ChartArea1";
            this.chtQueue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtQueue.Legends.Add(legend1);
            this.chtQueue.Location = new System.Drawing.Point(258, 95);
            this.chtQueue.Name = "chtQueue";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtQueue.Series.Add(series1);
            this.chtQueue.Size = new System.Drawing.Size(722, 217);
            this.chtQueue.TabIndex = 2;
            this.chtQueue.Text = "chtQueue";
            // 
            // dgResult
            // 
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(258, 318);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(722, 171);
            this.dgResult.TabIndex = 3;
            // 
            // btnExpIntervals
            // 
            this.btnExpIntervals.Location = new System.Drawing.Point(177, 10);
            this.btnExpIntervals.Name = "btnExpIntervals";
            this.btnExpIntervals.Size = new System.Drawing.Size(75, 23);
            this.btnExpIntervals.TabIndex = 4;
            this.btnExpIntervals.Text = "Check";
            this.btnExpIntervals.UseVisualStyleBackColor = true;
            this.btnExpIntervals.Click += new System.EventHandler(this.btnExpIntervals_Click);
            // 
            // pnlAlpha
            // 
            this.pnlAlpha.Controls.Add(this.btnSetAlpha);
            this.pnlAlpha.Controls.Add(this.lblAlpha);
            this.pnlAlpha.Controls.Add(this.txtAlpha);
            this.pnlAlpha.Location = new System.Drawing.Point(258, 7);
            this.pnlAlpha.Name = "pnlAlpha";
            this.pnlAlpha.Size = new System.Drawing.Size(181, 28);
            this.pnlAlpha.TabIndex = 5;
            // 
            // btnSetAlpha
            // 
            this.btnSetAlpha.Location = new System.Drawing.Point(123, 3);
            this.btnSetAlpha.Name = "btnSetAlpha";
            this.btnSetAlpha.Size = new System.Drawing.Size(51, 23);
            this.btnSetAlpha.TabIndex = 2;
            this.btnSetAlpha.Text = "Set";
            this.btnSetAlpha.UseVisualStyleBackColor = true;
            this.btnSetAlpha.Click += new System.EventHandler(this.btnSetAlpha_Click);
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(5, 8);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(37, 13);
            this.lblAlpha.TabIndex = 1;
            this.lblAlpha.Text = "Alpha:";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(48, 5);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(69, 20);
            this.txtAlpha.TabIndex = 0;
            // 
            // btnHasTrend
            // 
            this.btnHasTrend.Location = new System.Drawing.Point(177, 36);
            this.btnHasTrend.Name = "btnHasTrend";
            this.btnHasTrend.Size = new System.Drawing.Size(75, 23);
            this.btnHasTrend.TabIndex = 6;
            this.btnHasTrend.Text = "Check";
            this.btnHasTrend.UseVisualStyleBackColor = true;
            this.btnHasTrend.Click += new System.EventHandler(this.btnHasTrend_Click);
            // 
            // pnlClasses
            // 
            this.pnlClasses.Controls.Add(this.lblClasses);
            this.pnlClasses.Controls.Add(this.txtClasses);
            this.pnlClasses.Location = new System.Drawing.Point(445, 7);
            this.pnlClasses.Name = "pnlClasses";
            this.pnlClasses.Size = new System.Drawing.Size(125, 28);
            this.pnlClasses.TabIndex = 7;
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(5, 8);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(46, 13);
            this.lblClasses.TabIndex = 1;
            this.lblClasses.Text = "Classes:";
            // 
            // txtClasses
            // 
            this.txtClasses.Location = new System.Drawing.Point(57, 5);
            this.txtClasses.Name = "txtClasses";
            this.txtClasses.Size = new System.Drawing.Size(60, 20);
            this.txtClasses.TabIndex = 0;
            // 
            // btnStatEstimation
            // 
            this.btnStatEstimation.Location = new System.Drawing.Point(445, 36);
            this.btnStatEstimation.Name = "btnStatEstimation";
            this.btnStatEstimation.Size = new System.Drawing.Size(75, 23);
            this.btnStatEstimation.TabIndex = 8;
            this.btnStatEstimation.Text = "Estimate";
            this.btnStatEstimation.UseVisualStyleBackColor = true;
            this.btnStatEstimation.Click += new System.EventHandler(this.btnStatEstimation_Click);
            // 
            // btnPieceConstIntensity
            // 
            this.btnPieceConstIntensity.Location = new System.Drawing.Point(445, 69);
            this.btnPieceConstIntensity.Name = "btnPieceConstIntensity";
            this.btnPieceConstIntensity.Size = new System.Drawing.Size(75, 23);
            this.btnPieceConstIntensity.TabIndex = 9;
            this.btnPieceConstIntensity.Text = "Estimate";
            this.btnPieceConstIntensity.UseVisualStyleBackColor = true;
            this.btnPieceConstIntensity.Click += new System.EventHandler(this.btnPieceConstIntensity_Click);
            // 
            // btnOLS
            // 
            this.btnOLS.Location = new System.Drawing.Point(739, 6);
            this.btnOLS.Name = "btnOLS";
            this.btnOLS.Size = new System.Drawing.Size(75, 23);
            this.btnOLS.TabIndex = 10;
            this.btnOLS.Text = "Execute";
            this.btnOLS.UseVisualStyleBackColor = true;
            this.btnOLS.Click += new System.EventHandler(this.btnOLS_Click);
            // 
            // btnShowDF
            // 
            this.btnShowDF.Location = new System.Drawing.Point(820, 7);
            this.btnShowDF.Name = "btnShowDF";
            this.btnShowDF.Size = new System.Drawing.Size(160, 21);
            this.btnShowDF.TabIndex = 11;
            this.btnShowDF.Text = "Show Distribution Function";
            this.btnShowDF.UseVisualStyleBackColor = true;
            this.btnShowDF.Click += new System.EventHandler(this.btnShowDF_Click);
            // 
            // btnProbPieceConstIntensity
            // 
            this.btnProbPieceConstIntensity.Location = new System.Drawing.Point(739, 35);
            this.btnProbPieceConstIntensity.Name = "btnProbPieceConstIntensity";
            this.btnProbPieceConstIntensity.Size = new System.Drawing.Size(75, 23);
            this.btnProbPieceConstIntensity.TabIndex = 12;
            this.btnProbPieceConstIntensity.Text = "Execute";
            this.btnProbPieceConstIntensity.UseVisualStyleBackColor = true;
            this.btnProbPieceConstIntensity.Click += new System.EventHandler(this.btnProbPieceConstIntensity_Click);
            // 
            // btnShowProbDF
            // 
            this.btnShowProbDF.Location = new System.Drawing.Point(820, 34);
            this.btnShowProbDF.Name = "btnShowProbDF";
            this.btnShowProbDF.Size = new System.Drawing.Size(160, 24);
            this.btnShowProbDF.TabIndex = 13;
            this.btnShowProbDF.Text = "Show Distribution Function";
            this.btnShowProbDF.UseVisualStyleBackColor = true;
            this.btnShowProbDF.Click += new System.EventHandler(this.btnShowProbDF_Click);
            // 
            // btnShowStreams
            // 
            this.btnShowStreams.Location = new System.Drawing.Point(579, 66);
            this.btnShowStreams.Name = "btnShowStreams";
            this.btnShowStreams.Size = new System.Drawing.Size(401, 23);
            this.btnShowStreams.TabIndex = 14;
            this.btnShowStreams.Text = "Working with Streams";
            this.btnShowStreams.UseVisualStyleBackColor = true;
            this.btnShowStreams.Click += new System.EventHandler(this.btnShowStreams_Click);
            // 
            // lblExpIntervals
            // 
            this.lblExpIntervals.AutoSize = true;
            this.lblExpIntervals.Location = new System.Drawing.Point(12, 15);
            this.lblExpIntervals.Name = "lblExpIntervals";
            this.lblExpIntervals.Size = new System.Drawing.Size(153, 13);
            this.lblExpIntervals.TabIndex = 15;
            this.lblExpIntervals.Text = "Intervals have exp. distribution:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Intervals have trend:";
            // 
            // lblStatEstimation
            // 
            this.lblStatEstimation.AutoSize = true;
            this.lblStatEstimation.Location = new System.Drawing.Point(303, 41);
            this.lblStatEstimation.Name = "lblStatEstimation";
            this.lblStatEstimation.Size = new System.Drawing.Size(109, 13);
            this.lblStatEstimation.TabIndex = 17;
            this.lblStatEstimation.Text = "Utilization by partition:";
            // 
            // lblPieceConstIntensity
            // 
            this.lblPieceConstIntensity.Location = new System.Drawing.Point(263, 66);
            this.lblPieceConstIntensity.Name = "lblPieceConstIntensity";
            this.lblPieceConstIntensity.Size = new System.Drawing.Size(176, 26);
            this.lblPieceConstIntensity.TabIndex = 18;
            this.lblPieceConstIntensity.Text = "Intensities (piece-constant function) by partition:";
            this.lblPieceConstIntensity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOLS
            // 
            this.lblOLS.AutoSize = true;
            this.lblOLS.Location = new System.Drawing.Point(576, 12);
            this.lblOLS.Name = "lblOLS";
            this.lblOLS.Size = new System.Drawing.Size(114, 13);
            this.lblOLS.TabIndex = 19;
            this.lblOLS.Text = "Approximation by OLS:";
            // 
            // lblProbPieceConstIntensity
            // 
            this.lblProbPieceConstIntensity.AutoSize = true;
            this.lblProbPieceConstIntensity.Location = new System.Drawing.Point(576, 41);
            this.lblProbPieceConstIntensity.Name = "lblProbPieceConstIntensity";
            this.lblProbPieceConstIntensity.Size = new System.Drawing.Size(159, 13);
            this.lblProbPieceConstIntensity.TabIndex = 20;
            this.lblProbPieceConstIntensity.Text = "Find prob. piece-const. intensity:";
            // 
            // TMO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 501);
            this.Controls.Add(this.lblProbPieceConstIntensity);
            this.Controls.Add(this.lblOLS);
            this.Controls.Add(this.lblPieceConstIntensity);
            this.Controls.Add(this.lblStatEstimation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExpIntervals);
            this.Controls.Add(this.btnShowStreams);
            this.Controls.Add(this.btnShowProbDF);
            this.Controls.Add(this.btnProbPieceConstIntensity);
            this.Controls.Add(this.btnShowDF);
            this.Controls.Add(this.btnOLS);
            this.Controls.Add(this.btnPieceConstIntensity);
            this.Controls.Add(this.btnStatEstimation);
            this.Controls.Add(this.pnlClasses);
            this.Controls.Add(this.btnHasTrend);
            this.Controls.Add(this.pnlAlpha);
            this.Controls.Add(this.btnExpIntervals);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.chtQueue);
            this.Controls.Add(this.dgQueue);
            this.Controls.Add(this.btnLoad);
            this.Name = "TMO";
            this.Text = "Queue Systems";
            ((System.ComponentModel.ISupportInitialize)(this.dgQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.pnlAlpha.ResumeLayout(false);
            this.pnlAlpha.PerformLayout();
            this.pnlClasses.ResumeLayout(false);
            this.pnlClasses.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgQueue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtQueue;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.Button btnExpIntervals;
        private System.Windows.Forms.Panel pnlAlpha;
        private System.Windows.Forms.Button btnSetAlpha;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Button btnHasTrend;
        private System.Windows.Forms.Panel pnlClasses;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.TextBox txtClasses;
        private System.Windows.Forms.Button btnStatEstimation;
        private System.Windows.Forms.Button btnPieceConstIntensity;
        private System.Windows.Forms.Button btnOLS;
        private System.Windows.Forms.Button btnShowDF;
        private System.Windows.Forms.Button btnProbPieceConstIntensity;
        private System.Windows.Forms.Button btnShowProbDF;
        private System.Windows.Forms.Button btnShowStreams;
        private System.Windows.Forms.Label lblExpIntervals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatEstimation;
        private System.Windows.Forms.Label lblPieceConstIntensity;
        private System.Windows.Forms.Label lblOLS;
        private System.Windows.Forms.Label lblProbPieceConstIntensity;

    }
}

