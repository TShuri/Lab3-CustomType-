using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab3_CustomType_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbr_Scroll(object sender, EventArgs e)
        {
            pbColor.BackColor = Color.FromArgb(tbr.Value, tbg.Value, tbb.Value);
            lr.Text = tbr.Value.ToString();
            llight.Text = pbColor.BackColor.GetBrightness().ToString();
            lsaturation.Text = pbColor.BackColor.GetSaturation().ToString();
            lhue.Text = pbColor.BackColor.GetHue().ToString();
        }

        private void tbb_Scroll(object sender, EventArgs e)
        {
            pbColor.BackColor = Color.FromArgb(tbr.Value, tbg.Value, tbb.Value);
            lb.Text = tbb.Value.ToString();
            llight.Text = pbColor.BackColor.GetBrightness().ToString();
            lsaturation.Text = pbColor.BackColor.GetSaturation().ToString();
            lhue.Text = pbColor.BackColor.GetHue().ToString();
        }

        private void tbg_Scroll(object sender, EventArgs e)
        {
            pbColor.BackColor = Color.FromArgb(tbr.Value, tbg.Value, tbb.Value);
            lg.Text = tbg.Value.ToString();
            llight.Text = pbColor.BackColor.GetBrightness().ToString();
            lsaturation.Text = pbColor.BackColor.GetSaturation().ToString();
            lhue.Text = pbColor.BackColor.GetHue().ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //RGB rgbColor = new RGB { red = pbColor.BackColor.R, green = pbColor.BackColor.G, blue = pbColor.BackColor.B };
            HVS hvsColor = new HVS { hue = Convert.ToDouble(lhue.Text), saturation = Convert.ToDouble(lsaturation.Text), lightness = (trackBar1.Value * 0.01) };

            llight.Text = (Math.Round(trackBar1.Value * 0.01, 2)).ToString();
            RGB rgbColor = Converting.HVStoRGB(hvsColor);
            pbColor.BackColor = Color.FromArgb(rgbColor.red, rgbColor.green, rgbColor.blue);
        }
    }
    public struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
    }
    public struct HVS
    {
        public double hue;
        public double saturation;
        public double lightness;
    }
    public class Converting
    {
        public static RGB HVStoRGB(HVS color)
        {
            RGB result;
            double tR = 0;
            double tG = 0;
            double tB = 0;
            double c = color.lightness * color.saturation;
            double x = c * ( 1 - Math.Abs( ( color.hue / 60) % 2 - 1 ) );
            double m = color.lightness - c;

            if (0 <= color.hue && color.hue < 60)
            {
                tR = c;
                tG = x;
                tB = 0;
            }
            if (60 <= color.hue && color.hue < 120)
            {
                tR = x;
                tG = c;
                tB = 0;
            }
            if (120 <= color.hue && color.hue < 180)
            {
                tR = 0;
                tG = c;
                tB = x;
            }
            if (180 <= color.hue && color.hue < 240)
            {
                tR = 0;
                tG = x;
                tB = c;
            }
            if (240 <= color.hue && color.hue < 300)
            {
                tR = x;
                tG = 0;
                tB = c;
            }
            if (300 <= color.hue && color.hue < 360)
            {
                tR = c;
                tG = x;
                tB = 0;
            }

            result.red = (byte)((tR + m) * 255);
            result.green = (byte)((tG + m) * 255);
            result.blue = (byte)((tB + m) * 255);

            return result;
        }
    }
}