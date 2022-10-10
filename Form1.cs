using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_CustomType_
{
    public partial class Form1 : Form
    {
        public HSV currColorHSV = new HSV { hue = 0, saturation = 0, lightness = 0 };
        public RGB currColorRGB = new RGB { red = 0, green = 0, blue = 0 };
        public Form1()
        {
            InitializeComponent();
            //HSV currColorHSV = new HSV { hue = 0, saturation = 0, lightness = 0 };
            //currColorRGB = new RGB { red = 0, green = 0, blue = 0 };
        }
        
        private void UpdatePbColor() // Отображение цвета по RGB
        {
            pbColor.BackColor = Color.FromArgb(currColorRGB.red, currColorRGB.green, currColorRGB.blue);
        }

        private void UpdateDateRGB() // Функция обновления данных по RGB
        {
            // Отображение значений по RGB
            lValueRed.Text = currColorRGB.red.ToString();
            lValueGreen.Text = currColorRGB.green.ToString();
            lValueBlue.Text = currColorRGB.blue.ToString();

            // Обновление положения ползунков
            tbRed.Value = currColorRGB.red;
            tbGreen.Value = currColorRGB.green;
            tbBlue.Value = currColorRGB.blue;
        }
        private void UpdateDateHSV() // Функция обновления данных по HSV
        {
            // Обновление HSV значений для текущего цвета
            //currColorHSV.lightness = pbColor.BackColor.GetBrightness();
            //currColorHSV.saturation = pbColor.BackColor.GetSaturation();
            //currColorHSV.hue = pbColor.BackColor.GetHue();

            // Отображение значений по HSV
            //lValueLight.Text = currColorHSV.lightness.ToString();
            lValueLight.Text = Math.Round(currColorHSV.lightness * 100).ToString();
            lValueSaturation.Text = Math.Round(currColorHSV.saturation * 100).ToString();
            lValueHue.Text = Math.Round(currColorHSV.hue).ToString();

            // Обновление положения ползунков
            //tbLightness.Value = (int)Math.Round(currColorHSV.lightness * 200);
            tbLightness.Value = (int)Math.Round(currColorHSV.lightness * 100);
            tbSaturation.Value = (int)Math.Round(currColorHSV.saturation * 100);
            tbHue.Value = (int)Math.Round(currColorHSV.hue);
        }

        private void tbr_Scroll(object sender, EventArgs e) // Ползунок для красного цвета
        {
            currColorRGB.red = (byte)tbRed.Value;
            //currColorHSV = RGB.RGBtoHSV(currColorRGB);
            currColorRGB.RGBtoHSV(ref currColorHSV);
            UpdatePbColor();
            lValueRed.Text = tbRed.Value.ToString();
            UpdateDateHSV();
        }

        private void tbb_Scroll(object sender, EventArgs e) // Ползунок для синего цвета
        {
            currColorRGB.blue = (byte)tbBlue.Value;
            //currColorHSV = RGB.RGBtoHSV(currColorRGB);
            currColorRGB.RGBtoHSV(ref currColorHSV);
            UpdatePbColor();
            lValueBlue.Text = tbBlue.Value.ToString();
            UpdateDateHSV();
        }

        private void tbg_Scroll(object sender, EventArgs e) // Ползунок для зеленого цвета
        {
            currColorRGB.green = (byte)tbGreen.Value;
            //currColorHSV = RGB.RGBtoHSV(currColorRGB);
            currColorRGB.RGBtoHSV(ref currColorHSV);
            UpdatePbColor();
            lValueGreen.Text = tbGreen.Value.ToString();
            UpdateDateHSV();
        }

        private void tbLightness_Scroll(object sender, EventArgs e) // Ползунок для яркости
        {
            currColorHSV.lightness = tbLightness.Value * 0.01;
            //currColorRGB = HSV.HSVtoRGB(currColorHSV);
            currColorHSV.HSVtoRGB(ref currColorRGB);
            UpdatePbColor();
            lValueLight.Text = tbLightness.Value.ToString();
            UpdateDateRGB();
        }

        private void tbSaturation_Scroll(object sender, EventArgs e) // Ползунок для насыщенности
        {
            currColorHSV.saturation = tbSaturation.Value * 0.01;
            //currColorRGB = HSV.HSVtoRGB(currColorHSV);
            currColorHSV.HSVtoRGB(ref currColorRGB);
            UpdatePbColor();
            lValueSaturation.Text = tbSaturation.Value.ToString();
            UpdateDateRGB();
        }

        private void tbHue_Scroll(object sender, EventArgs e) // Ползунок для тона
        {
            currColorHSV.hue = tbHue.Value;
            currColorHSV.HSVtoRGB(ref currColorRGB);
            //currColorRGB = HSV.HSVtoRGB(currColorHSV);
            UpdatePbColor();
            lValueHue.Text = tbHue.Value.ToString();
            UpdateDateRGB();
        }
    }


    public class RGB
    {
        public byte red;
        public byte green;
        public byte blue;

        // Можно добавить функцию преобразования из RGB в HSV
        public void RGBtoHSV(ref HSV xref)
        {
            HSV result = xref;
            //HSV result = new HSV { hue = 0, saturation = 0, lightness = 0 };
            double tR = (double)(this.red) / 255;
            double tG = (double)(this.green) / 255;
            double tB = (double)(this.blue) / 255;
            double[] arr = { tR, tG, tB };
            double cMax = arr.Max();
            double cMin = arr.Min();
            double delta = cMax - cMin;

            if (delta == 0) // Определение hue ////////////////
            {
                result.hue = 0;
            }
            if (cMax == tR)
            {
                result.hue = 60 * ( ( (tG - tB) / delta ) % 6);
            }
            if (cMax == tG)
            {
                result.hue = 60 * ( ( (tB - tR) / delta ) + 2);
            }
            if (cMax == tB)
            {
                result.hue = 60 * ( ( (tR - tG) / delta ) + 4);
            } /////////////////////////////////////////////////

            if (cMax == 0) // Определение saturation
            {
                result.saturation = 0;
            }
            else
            {
                result.saturation = delta / cMax;
            } ///////////////////////////////////

            result.lightness = cMax; // Определение lightness

            //return result;
        }
    }
    public class HSV
    {
        public double hue;
        public double saturation;
        public double lightness;

        public void HSVtoRGB(ref RGB xref) // Преобразование из HSV в RGB
        {
            RGB result = xref;
            //RGB result = new RGB { red = 0, blue = 0, green = 0 };
            double tR = 0;
            double tG = 0;
            double tB = 0;
            double c = this.lightness * this.saturation;
            double x = c * (1 - Math.Abs((this.hue / 60) % 2 - 1));
            double m = this.lightness - c;

            if (0 <= this.hue && this.hue < 60)
            {
                tR = c;
                tG = x;
                tB = 0;
            }
            if (60 <= this.hue && this.hue < 120)
            {
                tR = x;
                tG = c;
                tB = 0;
            }
            if (120 <= this.hue && this.hue < 180)
            {
                tR = 0;
                tG = c;
                tB = x;
            }
            if (180 <= this.hue && this.hue < 240)
            {
                tR = 0;
                tG = x;
                tB = c;
            }
            if (240 <= this.hue && this.hue < 300)
            {
                tR = x;
                tG = 0;
                tB = c;
            }
            if (300 <= this.hue && this.hue < 360)
            {
                tR = c;
                tG = x;
                tB = 0;
            }

            result.red = (byte)((tR + m) * 255);
            result.green = (byte)((tG + m) * 255);
            result.blue = (byte)((tB + m) * 255);

            //return result;
        }
    }
}