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
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.lValueRed = new System.Windows.Forms.Label();
            this.lValueBlue = new System.Windows.Forms.Label();
            this.lValueGreen = new System.Windows.Forms.Label();
            this.lValueLight = new System.Windows.Forms.Label();
            this.lValueSaturation = new System.Windows.Forms.Label();
            this.tbLightness = new System.Windows.Forms.TrackBar();
            this.lValueHue = new System.Windows.Forms.Label();
            this.lRed = new System.Windows.Forms.Label();
            this.lGreen = new System.Windows.Forms.Label();
            this.lBlue = new System.Windows.Forms.Label();
            this.lLightness = new System.Windows.Forms.Label();
            this.lSaturation = new System.Windows.Forms.Label();
            this.tbSaturation = new System.Windows.Forms.TrackBar();
            this.lHue = new System.Windows.Forms.Label();
            this.tbHue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHue)).BeginInit();
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
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(430, 45);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(156, 69);
            this.tbRed.TabIndex = 1;
            this.tbRed.Scroll += new System.EventHandler(this.tbr_Scroll);
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(430, 200);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(156, 69);
            this.tbBlue.TabIndex = 2;
            this.tbBlue.Scroll += new System.EventHandler(this.tbb_Scroll);
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(430, 119);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(156, 69);
            this.tbGreen.TabIndex = 3;
            this.tbGreen.Scroll += new System.EventHandler(this.tbg_Scroll);
            // 
            // lValueRed
            // 
            this.lValueRed.AutoSize = true;
            this.lValueRed.Location = new System.Drawing.Point(592, 52);
            this.lValueRed.Name = "lValueRed";
            this.lValueRed.Size = new System.Drawing.Size(22, 25);
            this.lValueRed.TabIndex = 4;
            this.lValueRed.Text = "0";
            // 
            // lValueBlue
            // 
            this.lValueBlue.AutoSize = true;
            this.lValueBlue.Location = new System.Drawing.Point(592, 207);
            this.lValueBlue.Name = "lValueBlue";
            this.lValueBlue.Size = new System.Drawing.Size(22, 25);
            this.lValueBlue.TabIndex = 5;
            this.lValueBlue.Text = "0";
            // 
            // lValueGreen
            // 
            this.lValueGreen.AutoSize = true;
            this.lValueGreen.Location = new System.Drawing.Point(592, 126);
            this.lValueGreen.Name = "lValueGreen";
            this.lValueGreen.Size = new System.Drawing.Size(22, 25);
            this.lValueGreen.TabIndex = 6;
            this.lValueGreen.Text = "0";
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
            this.lValueHue.Location = new System.Drawing.Point(740, 301);
            this.lValueHue.Name = "lValueHue";
            this.lValueHue.Size = new System.Drawing.Size(22, 25);
            this.lValueHue.TabIndex = 10;
            this.lValueHue.Text = "0";
            // 
            // lRed
            // 
            this.lRed.AutoSize = true;
            this.lRed.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lRed.ForeColor = System.Drawing.Color.Red;
            this.lRed.Location = new System.Drawing.Point(353, 45);
            this.lRed.Name = "lRed";
            this.lRed.Size = new System.Drawing.Size(55, 32);
            this.lRed.TabIndex = 11;
            this.lRed.Text = "Red";
            // 
            // lGreen
            // 
            this.lGreen.AutoSize = true;
            this.lGreen.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lGreen.ForeColor = System.Drawing.Color.Lime;
            this.lGreen.Location = new System.Drawing.Point(353, 119);
            this.lGreen.Name = "lGreen";
            this.lGreen.Size = new System.Drawing.Size(78, 32);
            this.lGreen.TabIndex = 12;
            this.lGreen.Text = "Green";
            // 
            // lBlue
            // 
            this.lBlue.AutoSize = true;
            this.lBlue.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lBlue.ForeColor = System.Drawing.Color.Blue;
            this.lBlue.Location = new System.Drawing.Point(353, 200);
            this.lBlue.Name = "lBlue";
            this.lBlue.Size = new System.Drawing.Size(61, 32);
            this.lBlue.TabIndex = 13;
            this.lBlue.Text = "Blue";
            // 
            // lLightness
            // 
            this.lLightness.AutoSize = true;
            this.lLightness.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lLightness.Location = new System.Drawing.Point(628, 41);
            this.lLightness.Name = "lLightness";
            this.lLightness.Size = new System.Drawing.Size(114, 32);
            this.lLightness.TabIndex = 14;
            this.lLightness.Text = "Lightness";
            // 
            // lSaturation
            // 
            this.lSaturation.AutoSize = true;
            this.lSaturation.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSaturation.Location = new System.Drawing.Point(757, 41);
            this.lSaturation.Name = "lSaturation";
            this.lSaturation.Size = new System.Drawing.Size(123, 32);
            this.lSaturation.TabIndex = 15;
            this.lSaturation.Text = "Saturation";
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
            // lHue
            // 
            this.lHue.AutoSize = true;
            this.lHue.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHue.Location = new System.Drawing.Point(457, 295);
            this.lHue.Name = "lHue";
            this.lHue.Size = new System.Drawing.Size(58, 32);
            this.lHue.TabIndex = 17;
            this.lHue.Text = "Hue";
            // 
            // tbHue
            // 
            this.tbHue.Location = new System.Drawing.Point(521, 295);
            this.tbHue.Maximum = 360;
            this.tbHue.Name = "tbHue";
            this.tbHue.Size = new System.Drawing.Size(213, 69);
            this.tbHue.TabIndex = 18;
            this.tbHue.Scroll += new System.EventHandler(this.tbHue_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 376);
            this.Controls.Add(this.tbHue);
            this.Controls.Add(this.lHue);
            this.Controls.Add(this.tbSaturation);
            this.Controls.Add(this.lSaturation);
            this.Controls.Add(this.lLightness);
            this.Controls.Add(this.lBlue);
            this.Controls.Add(this.lGreen);
            this.Controls.Add(this.lRed);
            this.Controls.Add(this.lValueHue);
            this.Controls.Add(this.tbLightness);
            this.Controls.Add(this.lValueSaturation);
            this.Controls.Add(this.lValueLight);
            this.Controls.Add(this.lValueGreen);
            this.Controls.Add(this.lValueBlue);
            this.Controls.Add(this.lValueRed);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.pbColor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbColor;
        private TrackBar tbRed;
        private TrackBar tbBlue;
        private TrackBar tbGreen;
        private Label lValueRed;
        private Label lValueBlue;
        private Label lValueGreen;
        private Label lValueLight;
        private Label lValueSaturation;
        private TrackBar tbLightness;
        private Label lValueHue;
        private Label lRed;
        private Label lGreen;
        private Label lBlue;
        private Label lLightness;
        private Label lSaturation;
        private TrackBar tbSaturation;
        private Label lHue;
        private TrackBar tbHue;
    }
}