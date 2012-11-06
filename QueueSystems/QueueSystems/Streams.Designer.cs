namespace QueueSystems
{
    partial class Streams
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
            this.pnlDivideStreams = new System.Windows.Forms.Panel();
            this.btnDivideStreams = new System.Windows.Forms.Button();
            this.lblDivideStreams = new System.Windows.Forms.Label();
            this.txtDivideStreams = new System.Windows.Forms.TextBox();
            this.dgStreams = new System.Windows.Forms.DataGridView();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.btnShowIntensities = new System.Windows.Forms.Button();
            this.pnlCompareTwoStreams = new System.Windows.Forms.Panel();
            this.ddFirstStream = new System.Windows.Forms.ComboBox();
            this.ddSecondStream = new System.Windows.Forms.ComboBox();
            this.lblFirstStream = new System.Windows.Forms.Label();
            this.lblSecondStream = new System.Windows.Forms.Label();
            this.btnCompareTwoStreams = new System.Windows.Forms.Button();
            this.btnCompareStreams = new System.Windows.Forms.Button();
            this.pnlDivideStreams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStreams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            this.pnlCompareTwoStreams.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDivideStreams
            // 
            this.pnlDivideStreams.Controls.Add(this.btnDivideStreams);
            this.pnlDivideStreams.Controls.Add(this.lblDivideStreams);
            this.pnlDivideStreams.Controls.Add(this.txtDivideStreams);
            this.pnlDivideStreams.Location = new System.Drawing.Point(363, 12);
            this.pnlDivideStreams.Name = "pnlDivideStreams";
            this.pnlDivideStreams.Size = new System.Drawing.Size(160, 28);
            this.pnlDivideStreams.TabIndex = 16;
            // 
            // btnDivideStreams
            // 
            this.btnDivideStreams.Location = new System.Drawing.Point(103, 3);
            this.btnDivideStreams.Name = "btnDivideStreams";
            this.btnDivideStreams.Size = new System.Drawing.Size(51, 23);
            this.btnDivideStreams.TabIndex = 2;
            this.btnDivideStreams.Text = "Divide";
            this.btnDivideStreams.UseVisualStyleBackColor = true;
            this.btnDivideStreams.Click += new System.EventHandler(this.btnDivideStreams_Click);
            // 
            // lblDivideStreams
            // 
            this.lblDivideStreams.AutoSize = true;
            this.lblDivideStreams.Location = new System.Drawing.Point(5, 8);
            this.lblDivideStreams.Name = "lblDivideStreams";
            this.lblDivideStreams.Size = new System.Drawing.Size(17, 13);
            this.lblDivideStreams.TabIndex = 1;
            this.lblDivideStreams.Text = "K:";
            // 
            // txtDivideStreams
            // 
            this.txtDivideStreams.Location = new System.Drawing.Point(28, 5);
            this.txtDivideStreams.Name = "txtDivideStreams";
            this.txtDivideStreams.Size = new System.Drawing.Size(69, 20);
            this.txtDivideStreams.TabIndex = 0;
            // 
            // dgStreams
            // 
            this.dgStreams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStreams.Location = new System.Drawing.Point(12, 46);
            this.dgStreams.Name = "dgStreams";
            this.dgStreams.Size = new System.Drawing.Size(511, 150);
            this.dgStreams.TabIndex = 3;
            // 
            // dgResult
            // 
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(12, 253);
            this.dgResult.Name = "dgResult";
            this.dgResult.Size = new System.Drawing.Size(511, 150);
            this.dgResult.TabIndex = 17;
            // 
            // btnShowIntensities
            // 
            this.btnShowIntensities.Location = new System.Drawing.Point(12, 202);
            this.btnShowIntensities.Name = "btnShowIntensities";
            this.btnShowIntensities.Size = new System.Drawing.Size(101, 23);
            this.btnShowIntensities.TabIndex = 18;
            this.btnShowIntensities.Text = "Show Intensities";
            this.btnShowIntensities.UseVisualStyleBackColor = true;
            this.btnShowIntensities.Click += new System.EventHandler(this.btnShowIntensities_Click);
            // 
            // pnlCompareTwoStreams
            // 
            this.pnlCompareTwoStreams.Controls.Add(this.btnCompareTwoStreams);
            this.pnlCompareTwoStreams.Controls.Add(this.lblSecondStream);
            this.pnlCompareTwoStreams.Controls.Add(this.lblFirstStream);
            this.pnlCompareTwoStreams.Controls.Add(this.ddSecondStream);
            this.pnlCompareTwoStreams.Controls.Add(this.ddFirstStream);
            this.pnlCompareTwoStreams.Location = new System.Drawing.Point(119, 202);
            this.pnlCompareTwoStreams.Name = "pnlCompareTwoStreams";
            this.pnlCompareTwoStreams.Size = new System.Drawing.Size(281, 45);
            this.pnlCompareTwoStreams.TabIndex = 19;
            // 
            // ddFirstStream
            // 
            this.ddFirstStream.FormattingEnabled = true;
            this.ddFirstStream.Location = new System.Drawing.Point(3, 21);
            this.ddFirstStream.Name = "ddFirstStream";
            this.ddFirstStream.Size = new System.Drawing.Size(103, 21);
            this.ddFirstStream.TabIndex = 0;
            // 
            // ddSecondStream
            // 
            this.ddSecondStream.FormattingEnabled = true;
            this.ddSecondStream.Location = new System.Drawing.Point(112, 21);
            this.ddSecondStream.Name = "ddSecondStream";
            this.ddSecondStream.Size = new System.Drawing.Size(103, 21);
            this.ddSecondStream.TabIndex = 1;
            // 
            // lblFirstStream
            // 
            this.lblFirstStream.AutoSize = true;
            this.lblFirstStream.Location = new System.Drawing.Point(3, 5);
            this.lblFirstStream.Name = "lblFirstStream";
            this.lblFirstStream.Size = new System.Drawing.Size(65, 13);
            this.lblFirstStream.TabIndex = 2;
            this.lblFirstStream.Text = "First Stream:";
            // 
            // lblSecondStream
            // 
            this.lblSecondStream.AutoSize = true;
            this.lblSecondStream.Location = new System.Drawing.Point(109, 5);
            this.lblSecondStream.Name = "lblSecondStream";
            this.lblSecondStream.Size = new System.Drawing.Size(83, 13);
            this.lblSecondStream.TabIndex = 3;
            this.lblSecondStream.Text = "Second Stream:";
            // 
            // btnCompareTwoStreams
            // 
            this.btnCompareTwoStreams.Location = new System.Drawing.Point(221, 21);
            this.btnCompareTwoStreams.Name = "btnCompareTwoStreams";
            this.btnCompareTwoStreams.Size = new System.Drawing.Size(57, 21);
            this.btnCompareTwoStreams.TabIndex = 4;
            this.btnCompareTwoStreams.Text = "Compare";
            this.btnCompareTwoStreams.UseVisualStyleBackColor = true;
            this.btnCompareTwoStreams.Click += new System.EventHandler(this.btnCompareTwoStreams_Click);
            // 
            // btnCompareStreams
            // 
            this.btnCompareStreams.Location = new System.Drawing.Point(416, 202);
            this.btnCompareStreams.Name = "btnCompareStreams";
            this.btnCompareStreams.Size = new System.Drawing.Size(101, 23);
            this.btnCompareStreams.TabIndex = 20;
            this.btnCompareStreams.Text = "Compare Streams";
            this.btnCompareStreams.UseVisualStyleBackColor = true;
            this.btnCompareStreams.Click += new System.EventHandler(this.btnCompareStreams_Click);
            // 
            // Streams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 406);
            this.Controls.Add(this.btnCompareStreams);
            this.Controls.Add(this.pnlCompareTwoStreams);
            this.Controls.Add(this.btnShowIntensities);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.dgStreams);
            this.Controls.Add(this.pnlDivideStreams);
            this.Name = "Streams";
            this.Text = "Streams";
            this.pnlDivideStreams.ResumeLayout(false);
            this.pnlDivideStreams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStreams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            this.pnlCompareTwoStreams.ResumeLayout(false);
            this.pnlCompareTwoStreams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDivideStreams;
        private System.Windows.Forms.Button btnDivideStreams;
        private System.Windows.Forms.Label lblDivideStreams;
        private System.Windows.Forms.TextBox txtDivideStreams;
        private System.Windows.Forms.DataGridView dgStreams;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.Button btnShowIntensities;
        private System.Windows.Forms.Panel pnlCompareTwoStreams;
        private System.Windows.Forms.Button btnCompareTwoStreams;
        private System.Windows.Forms.Label lblSecondStream;
        private System.Windows.Forms.Label lblFirstStream;
        private System.Windows.Forms.ComboBox ddSecondStream;
        private System.Windows.Forms.ComboBox ddFirstStream;
        private System.Windows.Forms.Button btnCompareStreams;
    }
}