namespace TimeSeriesAnalysis
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
            this.pnlLoadTS = new System.Windows.Forms.Panel();
            this.lblLoadTS = new System.Windows.Forms.Label();
            this.txtLoadTS = new System.Windows.Forms.TextBox();
            this.btnLoadTSOpenDlg = new System.Windows.Forms.Button();
            this.btnLoadTSRead = new System.Windows.Forms.Button();
            this.dgTS = new System.Windows.Forms.DataGridView();
            this.dlgOpenTS = new System.Windows.Forms.OpenFileDialog();
            this.pnlSigns = new System.Windows.Forms.Panel();
            this.lblSigns = new System.Windows.Forms.Label();
            this.btnSignsTest = new System.Windows.Forms.Button();
            this.lblSignsStat = new System.Windows.Forms.Label();
            this.pnlSignsTest = new System.Windows.Forms.Panel();
            this.lblSignsQuantile = new System.Windows.Forms.Label();
            this.lblSignsComp = new System.Windows.Forms.Label();
            this.lblSignsResult = new System.Windows.Forms.Label();
            this.pnlSpearman = new System.Windows.Forms.Panel();
            this.pnlSpearmanTest = new System.Windows.Forms.Panel();
            this.lblSpearmanTest = new System.Windows.Forms.Label();
            this.lblSpearmanStat = new System.Windows.Forms.Label();
            this.lblSpearmanQuantile = new System.Windows.Forms.Label();
            this.lblSpearmanComp = new System.Windows.Forms.Label();
            this.btnTestSpearman = new System.Windows.Forms.Button();
            this.lblSpearman = new System.Windows.Forms.Label();
            this.chartTS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowHistogram = new System.Windows.Forms.Button();
            this.btnShowCorrelogram = new System.Windows.Forms.Button();
            this.pnlCorrelogram = new System.Windows.Forms.Panel();
            this.lblCorrelogram = new System.Windows.Forms.Label();
            this.txtCorrelogramK = new System.Windows.Forms.TextBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.btnSetAlpha = new System.Windows.Forms.Button();
            this.pnlLoadTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTS)).BeginInit();
            this.pnlSigns.SuspendLayout();
            this.pnlSignsTest.SuspendLayout();
            this.pnlSpearman.SuspendLayout();
            this.pnlSpearmanTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTS)).BeginInit();
            this.pnlCorrelogram.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoadTS
            // 
            this.pnlLoadTS.Controls.Add(this.dgTS);
            this.pnlLoadTS.Controls.Add(this.btnLoadTSRead);
            this.pnlLoadTS.Controls.Add(this.btnLoadTSOpenDlg);
            this.pnlLoadTS.Controls.Add(this.txtLoadTS);
            this.pnlLoadTS.Controls.Add(this.lblLoadTS);
            this.pnlLoadTS.Location = new System.Drawing.Point(12, 12);
            this.pnlLoadTS.Name = "pnlLoadTS";
            this.pnlLoadTS.Size = new System.Drawing.Size(232, 379);
            this.pnlLoadTS.TabIndex = 0;
            // 
            // lblLoadTS
            // 
            this.lblLoadTS.AutoSize = true;
            this.lblLoadTS.Location = new System.Drawing.Point(3, 0);
            this.lblLoadTS.Name = "lblLoadTS";
            this.lblLoadTS.Size = new System.Drawing.Size(91, 13);
            this.lblLoadTS.TabIndex = 0;
            this.lblLoadTS.Text = "Open Time Series";
            // 
            // txtLoadTS
            // 
            this.txtLoadTS.Location = new System.Drawing.Point(6, 16);
            this.txtLoadTS.Name = "txtLoadTS";
            this.txtLoadTS.Size = new System.Drawing.Size(129, 20);
            this.txtLoadTS.TabIndex = 1;
            // 
            // btnLoadTSOpenDlg
            // 
            this.btnLoadTSOpenDlg.Location = new System.Drawing.Point(141, 16);
            this.btnLoadTSOpenDlg.Name = "btnLoadTSOpenDlg";
            this.btnLoadTSOpenDlg.Size = new System.Drawing.Size(26, 20);
            this.btnLoadTSOpenDlg.TabIndex = 2;
            this.btnLoadTSOpenDlg.Text = "...";
            this.btnLoadTSOpenDlg.UseVisualStyleBackColor = true;
            this.btnLoadTSOpenDlg.Click += new System.EventHandler(this.btnLoadTSOpenDlg_Click);
            // 
            // btnLoadTSRead
            // 
            this.btnLoadTSRead.Location = new System.Drawing.Point(173, 16);
            this.btnLoadTSRead.Name = "btnLoadTSRead";
            this.btnLoadTSRead.Size = new System.Drawing.Size(56, 20);
            this.btnLoadTSRead.TabIndex = 3;
            this.btnLoadTSRead.Text = "Load";
            this.btnLoadTSRead.UseVisualStyleBackColor = true;
            this.btnLoadTSRead.Click += new System.EventHandler(this.btnLoadTSRead_Click);
            // 
            // dgTS
            // 
            this.dgTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTS.Location = new System.Drawing.Point(6, 42);
            this.dgTS.Name = "dgTS";
            this.dgTS.Size = new System.Drawing.Size(223, 334);
            this.dgTS.TabIndex = 4;
            // 
            // dlgOpenTS
            // 
            this.dlgOpenTS.FileName = "openFileDialog1";
            // 
            // pnlSigns
            // 
            this.pnlSigns.Controls.Add(this.pnlSignsTest);
            this.pnlSigns.Controls.Add(this.btnSignsTest);
            this.pnlSigns.Controls.Add(this.lblSigns);
            this.pnlSigns.Location = new System.Drawing.Point(250, 12);
            this.pnlSigns.Name = "pnlSigns";
            this.pnlSigns.Size = new System.Drawing.Size(589, 64);
            this.pnlSigns.TabIndex = 1;
            // 
            // lblSigns
            // 
            this.lblSigns.AutoSize = true;
            this.lblSigns.Location = new System.Drawing.Point(3, 0);
            this.lblSigns.Name = "lblSigns";
            this.lblSigns.Size = new System.Drawing.Size(72, 13);
            this.lblSigns.TabIndex = 0;
            this.lblSigns.Text = "Signs Method";
            // 
            // btnSignsTest
            // 
            this.btnSignsTest.Location = new System.Drawing.Point(6, 16);
            this.btnSignsTest.Name = "btnSignsTest";
            this.btnSignsTest.Size = new System.Drawing.Size(69, 23);
            this.btnSignsTest.TabIndex = 1;
            this.btnSignsTest.Text = "Test";
            this.btnSignsTest.UseVisualStyleBackColor = true;
            this.btnSignsTest.Click += new System.EventHandler(this.btnSignsTest_Click);
            // 
            // lblSignsStat
            // 
            this.lblSignsStat.AutoSize = true;
            this.lblSignsStat.Location = new System.Drawing.Point(3, 0);
            this.lblSignsStat.Name = "lblSignsStat";
            this.lblSignsStat.Size = new System.Drawing.Size(35, 13);
            this.lblSignsStat.TabIndex = 2;
            this.lblSignsStat.Text = "label1";
            // 
            // pnlSignsTest
            // 
            this.pnlSignsTest.Controls.Add(this.lblSignsResult);
            this.pnlSignsTest.Controls.Add(this.lblSignsComp);
            this.pnlSignsTest.Controls.Add(this.lblSignsQuantile);
            this.pnlSignsTest.Controls.Add(this.lblSignsStat);
            this.pnlSignsTest.Location = new System.Drawing.Point(81, 3);
            this.pnlSignsTest.Name = "pnlSignsTest";
            this.pnlSignsTest.Size = new System.Drawing.Size(505, 52);
            this.pnlSignsTest.TabIndex = 3;
            this.pnlSignsTest.Visible = false;
            // 
            // lblSignsQuantile
            // 
            this.lblSignsQuantile.AutoSize = true;
            this.lblSignsQuantile.Location = new System.Drawing.Point(379, 0);
            this.lblSignsQuantile.Name = "lblSignsQuantile";
            this.lblSignsQuantile.Size = new System.Drawing.Size(35, 13);
            this.lblSignsQuantile.TabIndex = 3;
            this.lblSignsQuantile.Text = "label1";
            // 
            // lblSignsComp
            // 
            this.lblSignsComp.AutoSize = true;
            this.lblSignsComp.Location = new System.Drawing.Point(244, 0);
            this.lblSignsComp.Name = "lblSignsComp";
            this.lblSignsComp.Size = new System.Drawing.Size(35, 13);
            this.lblSignsComp.TabIndex = 4;
            this.lblSignsComp.Text = "label1";
            // 
            // lblSignsResult
            // 
            this.lblSignsResult.Location = new System.Drawing.Point(6, 23);
            this.lblSignsResult.Name = "lblSignsResult";
            this.lblSignsResult.Size = new System.Drawing.Size(496, 23);
            this.lblSignsResult.TabIndex = 5;
            this.lblSignsResult.Text = "label1";
            this.lblSignsResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSpearman
            // 
            this.pnlSpearman.Controls.Add(this.pnlSpearmanTest);
            this.pnlSpearman.Controls.Add(this.btnTestSpearman);
            this.pnlSpearman.Controls.Add(this.lblSpearman);
            this.pnlSpearman.Location = new System.Drawing.Point(250, 82);
            this.pnlSpearman.Name = "pnlSpearman";
            this.pnlSpearman.Size = new System.Drawing.Size(589, 64);
            this.pnlSpearman.TabIndex = 2;
            // 
            // pnlSpearmanTest
            // 
            this.pnlSpearmanTest.Controls.Add(this.lblSpearmanTest);
            this.pnlSpearmanTest.Controls.Add(this.lblSpearmanStat);
            this.pnlSpearmanTest.Controls.Add(this.lblSpearmanQuantile);
            this.pnlSpearmanTest.Controls.Add(this.lblSpearmanComp);
            this.pnlSpearmanTest.Location = new System.Drawing.Point(110, 3);
            this.pnlSpearmanTest.Name = "pnlSpearmanTest";
            this.pnlSpearmanTest.Size = new System.Drawing.Size(476, 52);
            this.pnlSpearmanTest.TabIndex = 3;
            this.pnlSpearmanTest.Visible = false;
            // 
            // lblSpearmanTest
            // 
            this.lblSpearmanTest.Location = new System.Drawing.Point(3, 30);
            this.lblSpearmanTest.Name = "lblSpearmanTest";
            this.lblSpearmanTest.Size = new System.Drawing.Size(470, 22);
            this.lblSpearmanTest.TabIndex = 5;
            this.lblSpearmanTest.Text = "label1";
            this.lblSpearmanTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpearmanStat
            // 
            this.lblSpearmanStat.AutoSize = true;
            this.lblSpearmanStat.Location = new System.Drawing.Point(3, 0);
            this.lblSpearmanStat.Name = "lblSpearmanStat";
            this.lblSpearmanStat.Size = new System.Drawing.Size(35, 13);
            this.lblSpearmanStat.TabIndex = 4;
            this.lblSpearmanStat.Text = "label1";
            // 
            // lblSpearmanQuantile
            // 
            this.lblSpearmanQuantile.AutoSize = true;
            this.lblSpearmanQuantile.Location = new System.Drawing.Point(350, 0);
            this.lblSpearmanQuantile.Name = "lblSpearmanQuantile";
            this.lblSpearmanQuantile.Size = new System.Drawing.Size(35, 13);
            this.lblSpearmanQuantile.TabIndex = 3;
            this.lblSpearmanQuantile.Text = "label1";
            // 
            // lblSpearmanComp
            // 
            this.lblSpearmanComp.AutoSize = true;
            this.lblSpearmanComp.Location = new System.Drawing.Point(215, 0);
            this.lblSpearmanComp.Name = "lblSpearmanComp";
            this.lblSpearmanComp.Size = new System.Drawing.Size(35, 13);
            this.lblSpearmanComp.TabIndex = 2;
            this.lblSpearmanComp.Text = "label1";
            // 
            // btnTestSpearman
            // 
            this.btnTestSpearman.Location = new System.Drawing.Point(6, 16);
            this.btnTestSpearman.Name = "btnTestSpearman";
            this.btnTestSpearman.Size = new System.Drawing.Size(98, 23);
            this.btnTestSpearman.TabIndex = 1;
            this.btnTestSpearman.Text = "Test";
            this.btnTestSpearman.UseVisualStyleBackColor = true;
            this.btnTestSpearman.Click += new System.EventHandler(this.btnTestSpearman_Click);
            // 
            // lblSpearman
            // 
            this.lblSpearman.AutoSize = true;
            this.lblSpearman.Location = new System.Drawing.Point(3, 0);
            this.lblSpearman.Name = "lblSpearman";
            this.lblSpearman.Size = new System.Drawing.Size(101, 13);
            this.lblSpearman.TabIndex = 0;
            this.lblSpearman.Text = "Spearman\'s Method";
            // 
            // chartTS
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTS.Legends.Add(legend2);
            this.chartTS.Location = new System.Drawing.Point(250, 193);
            this.chartTS.Name = "chartTS";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTS.Series.Add(series2);
            this.chartTS.Size = new System.Drawing.Size(589, 245);
            this.chartTS.TabIndex = 3;
            this.chartTS.Text = "chart1";
            // 
            // btnShowHistogram
            // 
            this.btnShowHistogram.Location = new System.Drawing.Point(250, 164);
            this.btnShowHistogram.Name = "btnShowHistogram";
            this.btnShowHistogram.Size = new System.Drawing.Size(104, 23);
            this.btnShowHistogram.TabIndex = 4;
            this.btnShowHistogram.Text = "Show Histogram";
            this.btnShowHistogram.UseVisualStyleBackColor = true;
            this.btnShowHistogram.Click += new System.EventHandler(this.btnShowHistogram_Click);
            // 
            // btnShowCorrelogram
            // 
            this.btnShowCorrelogram.Location = new System.Drawing.Point(6, 12);
            this.btnShowCorrelogram.Name = "btnShowCorrelogram";
            this.btnShowCorrelogram.Size = new System.Drawing.Size(104, 23);
            this.btnShowCorrelogram.TabIndex = 5;
            this.btnShowCorrelogram.Text = "Show Correlogram";
            this.btnShowCorrelogram.UseVisualStyleBackColor = true;
            this.btnShowCorrelogram.Click += new System.EventHandler(this.btnShowCorrelogram_Click);
            // 
            // pnlCorrelogram
            // 
            this.pnlCorrelogram.Controls.Add(this.txtCorrelogramK);
            this.pnlCorrelogram.Controls.Add(this.lblCorrelogram);
            this.pnlCorrelogram.Controls.Add(this.btnShowCorrelogram);
            this.pnlCorrelogram.Location = new System.Drawing.Point(360, 152);
            this.pnlCorrelogram.Name = "pnlCorrelogram";
            this.pnlCorrelogram.Size = new System.Drawing.Size(237, 35);
            this.pnlCorrelogram.TabIndex = 6;
            this.pnlCorrelogram.Visible = false;
            // 
            // lblCorrelogram
            // 
            this.lblCorrelogram.AutoSize = true;
            this.lblCorrelogram.Location = new System.Drawing.Point(116, 17);
            this.lblCorrelogram.Name = "lblCorrelogram";
            this.lblCorrelogram.Size = new System.Drawing.Size(58, 13);
            this.lblCorrelogram.TabIndex = 6;
            this.lblCorrelogram.Text = "K Variable:";
            // 
            // txtCorrelogramK
            // 
            this.txtCorrelogramK.Location = new System.Drawing.Point(180, 14);
            this.txtCorrelogramK.Name = "txtCorrelogramK";
            this.txtCorrelogramK.Size = new System.Drawing.Size(54, 20);
            this.txtCorrelogramK.TabIndex = 7;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnSetAlpha);
            this.pnlSettings.Controls.Add(this.txtAlpha);
            this.pnlSettings.Controls.Add(this.lblAlpha);
            this.pnlSettings.Location = new System.Drawing.Point(12, 394);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(232, 44);
            this.pnlSettings.TabIndex = 7;
            // 
            // lblAlpha
            // 
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(3, 0);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(56, 13);
            this.lblAlpha.TabIndex = 0;
            this.lblAlpha.Text = "Set Alpha:";
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(6, 16);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.Size = new System.Drawing.Size(100, 20);
            this.txtAlpha.TabIndex = 1;
            this.txtAlpha.Text = "0.05";
            // 
            // btnSetAlpha
            // 
            this.btnSetAlpha.Location = new System.Drawing.Point(108, 13);
            this.btnSetAlpha.Name = "btnSetAlpha";
            this.btnSetAlpha.Size = new System.Drawing.Size(73, 24);
            this.btnSetAlpha.TabIndex = 2;
            this.btnSetAlpha.Text = "Set";
            this.btnSetAlpha.UseVisualStyleBackColor = true;
            this.btnSetAlpha.Click += new System.EventHandler(this.btnSetAlpha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlCorrelogram);
            this.Controls.Add(this.btnShowHistogram);
            this.Controls.Add(this.chartTS);
            this.Controls.Add(this.pnlSpearman);
            this.Controls.Add(this.pnlSigns);
            this.Controls.Add(this.pnlLoadTS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlLoadTS.ResumeLayout(false);
            this.pnlLoadTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTS)).EndInit();
            this.pnlSigns.ResumeLayout(false);
            this.pnlSigns.PerformLayout();
            this.pnlSignsTest.ResumeLayout(false);
            this.pnlSignsTest.PerformLayout();
            this.pnlSpearman.ResumeLayout(false);
            this.pnlSpearman.PerformLayout();
            this.pnlSpearmanTest.ResumeLayout(false);
            this.pnlSpearmanTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTS)).EndInit();
            this.pnlCorrelogram.ResumeLayout(false);
            this.pnlCorrelogram.PerformLayout();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoadTS;
        private System.Windows.Forms.DataGridView dgTS;
        private System.Windows.Forms.Button btnLoadTSRead;
        private System.Windows.Forms.Button btnLoadTSOpenDlg;
        private System.Windows.Forms.TextBox txtLoadTS;
        private System.Windows.Forms.Label lblLoadTS;
        private System.Windows.Forms.OpenFileDialog dlgOpenTS;
        private System.Windows.Forms.Panel pnlSigns;
        private System.Windows.Forms.Panel pnlSignsTest;
        private System.Windows.Forms.Label lblSignsStat;
        private System.Windows.Forms.Button btnSignsTest;
        private System.Windows.Forms.Label lblSigns;
        private System.Windows.Forms.Label lblSignsResult;
        private System.Windows.Forms.Label lblSignsComp;
        private System.Windows.Forms.Label lblSignsQuantile;
        private System.Windows.Forms.Panel pnlSpearman;
        private System.Windows.Forms.Panel pnlSpearmanTest;
        private System.Windows.Forms.Label lblSpearmanTest;
        private System.Windows.Forms.Label lblSpearmanStat;
        private System.Windows.Forms.Label lblSpearmanQuantile;
        private System.Windows.Forms.Label lblSpearmanComp;
        private System.Windows.Forms.Button btnTestSpearman;
        private System.Windows.Forms.Label lblSpearman;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTS;
        private System.Windows.Forms.Button btnShowHistogram;
        private System.Windows.Forms.Button btnShowCorrelogram;
        private System.Windows.Forms.Panel pnlCorrelogram;
        private System.Windows.Forms.TextBox txtCorrelogramK;
        private System.Windows.Forms.Label lblCorrelogram;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnSetAlpha;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.Label lblAlpha;
    }
}

