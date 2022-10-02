namespace Lab3_CustomType_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.tbr = new System.Windows.Forms.TrackBar();
            this.tbb = new System.Windows.Forms.TrackBar();
            this.tbg = new System.Windows.Forms.TrackBar();
            this.lr = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(12, 12);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(254, 244);
            this.pbColor.TabIndex = 0;
            this.pbColor.TabStop = false;
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(272, 12);
            this.tbr.Maximum = 255;
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(156, 69);
            this.tbr.TabIndex = 1;
            this.tbr.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(272, 87);
            this.tbb.Maximum = 255;
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(156, 69);
            this.tbb.TabIndex = 2;
            this.tbb.Scroll += new System.EventHandler(this.tbb_Scroll);
            // 
            // tbg
            // 
            this.tbg.Location = new System.Drawing.Point(272, 162);
            this.tbg.Maximum = 255;
            this.tbg.Name = "tbg";
            this.tbg.Size = new System.Drawing.Size(156, 69);
            this.tbg.TabIndex = 3;
            this.tbg.Scroll += new System.EventHandler(this.tbg_Scroll);
            // 
            // lr
            // 
            this.lr.AutoSize = true;
            this.lr.Location = new System.Drawing.Point(434, 21);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(22, 25);
            this.lr.TabIndex = 4;
            this.lr.Text = "0";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(434, 97);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(22, 25);
            this.lb.TabIndex = 5;
            this.lb.Text = "0";
            // 
            // lg
            // 
            this.lg.AutoSize = true;
            this.lg.Location = new System.Drawing.Point(434, 171);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(22, 25);
            this.lg.TabIndex = 6;
            this.lg.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 285);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lr);
            this.Controls.Add(this.tbg);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.pbColor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbColor;
        private TrackBar tbr;
        private TrackBar tbb;
        private TrackBar tbg;
        private Label lr;
        private Label lb;
        private Label lg;
    }
}