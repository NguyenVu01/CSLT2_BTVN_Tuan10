namespace BTVN_Chuong4_Bai8_ColorDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng đến với ứng dụng ColorDialog!");
        }

        private void bar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblRed.Text = bar1.Value.ToString();
            BackColor = Color.FromArgb(bar1.Value, bar2.Value, bar3.Value);

        }

        private void bar2_Scroll(object sender, ScrollEventArgs e)
        {
            lblGreen.Text = bar2.Value.ToString();
            BackColor = Color.FromArgb(bar1.Value, bar2.Value, bar3.Value);
        }

        private void bar3_Scroll(object sender, ScrollEventArgs e)
        {
            lblBlue.Text = bar3.Value.ToString();
            BackColor = Color.FromArgb(bar1.Value, bar2.Value, bar3.Value);
        }

    }
}