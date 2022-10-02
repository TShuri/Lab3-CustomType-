namespace Lab3_CustomType_
{
    partial class Form1
    {
        HVS currentColor;
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
            this.lValueLight = new System.Windows.Forms.Label();
            this.lValueSaturation = new System.Windows.Forms.Label();
            this.tbLightness = new System.Windows.Forms.TrackBar();
            this.lValueHue = new System.Windows.Forms.Label();
            this.lred = new System.Windows.Forms.Label();
            this.lgreen = new System.Windows.Forms.Label();
            this.lblue = new System.Windows.Forms.Label();
            this.llightness = new System.Windows.Forms.Label();
            this.lsaturation = new System.Windows.Forms.Label();
            this.tbSaturation = new System.Windows.Forms.TrackBar();
            this.lhue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).BeginInit();
            this.SuspendLayout();
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(12, 24);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(340, 340);
            this.pbColor.TabIndex = 0;
            this.pbColor.TabStop = false;
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(430, 45);
            this.tbr.Maximum = 255;
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(156, 69);
            this.tbr.TabIndex = 1;
            this.tbr.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(430, 120);
            this.tbb.Maximum = 255;
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(156, 69);
            this.tbb.TabIndex = 2;
            this.tbb.Scroll += new System.EventHandler(this.tbb_Scroll);
            // 
            // tbg
            // 
            this.tbg.Location = new System.Drawing.Point(430, 200);
            this.tbg.Maximum = 255;
            this.tbg.Name = "tbg";
            this.tbg.Size = new System.Drawing.Size(156, 69);
            this.tbg.TabIndex = 3;
            this.tbg.Scroll += new System.EventHandler(this.tbg_Scroll);
            // 
            // lr
            // 
            this.lr.AutoSize = true;
            this.lr.Location = new System.Drawing.Point(592, 51);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(22, 25);
            this.lr.TabIndex = 4;
            this.lr.Text = "0";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(592, 126);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(22, 25);
            this.lb.TabIndex = 5;
            this.lb.Text = "0";
            // 
            // lg
            // 
            this.lg.AutoSize = true;
            this.lg.Location = new System.Drawing.Point(592, 206);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(22, 25);
            this.lg.TabIndex = 6;
            this.lg.Text = "0";
            // 
            // lValueLight
            // 
            this.lValueLight.AutoSize = true;
            this.lValueLight.Location = new System.Drawing.Point(680, 239);
            this.lValueLight.Name = "lValueLight";
            this.lValueLight.Size = new System.Drawing.Size(22, 25);
            this.lValueLight.TabIndex = 7;
            this.lValueLight.Text = "0";
            // 
            // lValueSaturation
            // 
            this.lValueSaturation.AutoSize = true;
            this.lValueSaturation.Location = new System.Drawing.Point(802, 239);
            this.lValueSaturation.Name = "lValueSaturation";
            this.lValueSaturation.Size = new System.Drawing.Size(22, 25);
            this.lValueSaturation.TabIndex = 8;
            this.lValueSaturation.Text = "0";
            // 
            // tbLightness
            // 
            this.tbLightness.Location = new System.Drawing.Point(663, 80);
            this.tbLightness.Maximum = 100;
            this.tbLightness.Name = "tbLightness";
            this.tbLightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbLightness.Size = new System.Drawing.Size(69, 156);
            this.tbLightness.TabIndex = 9;
            this.tbLightness.Scroll += new System.EventHandler(this.tbLightness_Scroll);
            // 
            // lValueHue
            // 
            this.lValueHue.AutoSize = true;
            this.lValueHue.Location = new System.Drawing.Point(521, 272);
            this.lValueHue.Name = "lValueHue";
            this.lValueHue.Size = new System.Drawing.Size(22, 25);
            this.lValueHue.TabIndex = 10;
            this.lValueHue.Text = "0";
            // 
            // lred
            // 
            this.lred.AutoSize = true;
            this.lred.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lred.ForeColor = System.Drawing.Color.Red;
            this.lred.Location = new System.Drawing.Point(353, 45);
            this.lred.Name = "lred";
            this.lred.Size = new System.Drawing.Size(55, 32);
            this.lred.TabIndex = 11;
            this.lred.Text = "Red";
            // 
            // lgreen
            // 
            this.lgreen.AutoSize = true;
            this.lgreen.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lgreen.ForeColor = System.Drawing.Color.Lime;
            this.lgreen.Location = new System.Drawing.Point(353, 119);
            this.lgreen.Name = "lgreen";
            this.lgreen.Size = new System.Drawing.Size(78, 32);
            this.lgreen.TabIndex = 12;
            this.lgreen.Text = "Green";
            // 
            // lblue
            // 
            this.lblue.AutoSize = true;
            this.lblue.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblue.ForeColor = System.Drawing.Color.Blue;
            this.lblue.Location = new System.Drawing.Point(353, 200);
            this.lblue.Name = "lblue";
            this.lblue.Size = new System.Drawing.Size(61, 32);
            this.lblue.TabIndex = 13;
            this.lblue.Text = "Blue";
            // 
            // llightness
            // 
            this.llightness.AutoSize = true;
            this.llightness.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llightness.Location = new System.Drawing.Point(628, 41);
            this.llightness.Name = "llightness";
            this.llightness.Size = new System.Drawing.Size(114, 32);
            this.llightness.TabIndex = 14;
            this.llightness.Text = "Lightness";
            // 
            // lsaturation
            // 
            this.lsaturation.AutoSize = true;
            this.lsaturation.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lsaturation.Location = new System.Drawing.Point(757, 41);
            this.lsaturation.Name = "lsaturation";
            this.lsaturation.Size = new System.Drawing.Size(123, 32);
            this.lsaturation.TabIndex = 15;
            this.lsaturation.Text = "Saturation";
            // 
            // tbSaturation
            // 
            this.tbSaturation.Location = new System.Drawing.Point(788, 80);
            this.tbSaturation.Maximum = 100;
            this.tbSaturation.Name = "tbSaturation";
            this.tbSaturation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbSaturation.Size = new System.Drawing.Size(69, 156);
            this.tbSaturation.TabIndex = 16;
            this.tbSaturation.Scroll += new System.EventHandler(this.tbSaturation_Scroll);
            // 
            // lhue
            // 
            this.lhue.AutoSize = true;
            this.lhue.Location = new System.Drawing.Point(471, 272);
            this.lhue.Name = "lhue";
            this.lhue.Size = new System.Drawing.Size(44, 25);
            this.lhue.TabIndex = 17;
            this.lhue.Text = "Hue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 376);
            this.Controls.Add(this.lhue);
            this.Controls.Add(this.tbSaturation);
            this.Controls.Add(this.lsaturation);
            this.Controls.Add(this.llightness);
            this.Controls.Add(this.lblue);
            this.Controls.Add(this.lgreen);
            this.Controls.Add(this.lred);
            this.Controls.Add(this.lValueHue);
            this.Controls.Add(this.tbLightness);
            this.Controls.Add(this.lValueSaturation);
            this.Controls.Add(this.lValueLight);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).EndInit();
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
        private Label lValueLight;
        private Label lValueSaturation;
        private TrackBar tbLightness;
        private Label lValueHue;
        private Label lred;
        private Label lgreen;
        private Label lblue;
        private Label llightness;
        private Label lsaturation;
        private TrackBar tbSaturation;
        private Label lhue;
    }
}