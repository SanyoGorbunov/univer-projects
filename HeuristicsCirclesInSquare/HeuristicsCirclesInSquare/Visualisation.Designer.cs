namespace HeuristicsCirclesInSquare
{
    partial class Visualisation
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
            this.pbSquare = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSquare)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSquare
            // 
            this.pbSquare.Location = new System.Drawing.Point(12, 12);
            this.pbSquare.Name = "pbSquare";
            this.pbSquare.Size = new System.Drawing.Size(450, 450);
            this.pbSquare.TabIndex = 0;
            this.pbSquare.TabStop = false;
            this.pbSquare.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSquare_Paint);
            // 
            // Visualisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 474);
            this.Controls.Add(this.pbSquare);
            this.Name = "Visualisation";
            this.Text = "Visualisation";
            this.Activated += new System.EventHandler(this.Visualisation_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pbSquare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSquare;
    }
}