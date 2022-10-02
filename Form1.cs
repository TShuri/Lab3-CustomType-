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
        }

        private void tbb_Scroll(object sender, EventArgs e)
        {
            pbColor.BackColor = Color.FromArgb(tbr.Value, tbg.Value, tbb.Value);
            lb.Text = tbb.Value.ToString();
        }

        private void tbg_Scroll(object sender, EventArgs e)
        {
            pbColor.BackColor = Color.FromArgb(tbr.Value, tbg.Value, tbb.Value);
            lg.Text = tbg.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}