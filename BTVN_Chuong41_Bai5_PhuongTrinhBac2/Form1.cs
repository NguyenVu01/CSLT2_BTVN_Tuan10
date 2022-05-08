namespace BTVN_Chuong41_Bai5_PhuongTrinhBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dial = MessageBox.Show("Bạn có thật sự muốn thoát?", "Lời nhắc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dial == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else if(dial == DialogResult.No)
            {
                MessageBox.Show("Mời bạn tiếp tục!","Uki bạn nhó!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGiaiPTBH_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(nudA.Value);
            float b = Convert.ToSingle(nudB.Value);
            float c = Convert.ToSingle(nudC.Value);
            float delta = Convert.ToSingle((b * b) - 4 * a * c);

            float sqrtDel = Convert.ToSingle(Math.Sqrt(delta));

            float x1 = (-b + sqrtDel) / (2 * a);
            float x2 = (-b - sqrtDel) / (2 * a);

            if(a == 0)
            {
                if(b == 0 && c!= 0)
                {
                    txbKetQua.Text = "a =  " + a.ToString() + "\r\nb =  " + b.ToString() + "\r\nc =  " + c.ToString()
                                  + " \r\nPhương trình là vô lý";
                    txbX1.Text = "";
                    txbX2.Text = "";
                }
                else if (b == 0 && c == 0)
                {
                    txbKetQua.Text = "a =  " + a.ToString() + "\r\nb =  " + b.ToString() + "\r\nc =  " + c.ToString()
                                                      + " \r\nPhương trình 0 = 0";
                    txbX1.Text = "";
                    txbX2.Text = "";
                }
                else
                {
                    txbKetQua.Text = "a =  " + a.ToString() + "\r\nb =  " + b.ToString() + "\r\nc =  " + c.ToString()
                                                      + " \r\nPhương trình bậc 1";
                    txbX1.Text = (-c / b).ToString();
                    txbX2.Text = "";
                }
            }
            else if(a != 0)
            {
                if(delta > 0)
                {
                    txbKetQua.Text = "a =  " + a.ToString() + "\r\nb =  " + b.ToString() + "\r\nc =  " + c.ToString()
                                     + "\r\nPhương trình có 2 nghiệm phân biệt";
                    txbX1.Text = ((-b + sqrtDel)/(2 * a)).ToString();
                    txbX2.Text = ((-b - sqrtDel)/(2 * a)).ToString(); 
                }
                else if(delta == 0)
                {
                    txbKetQua.Text = "a =  " + a.ToString() + "\r\nb = " + b.ToString() + "\r\nc = " + c.ToString()
                                    + "\r\nPhương trình có 2 nghiệm kép";
                    txbX1.Text = txbX2.Text = (-b / (2 * a)).ToString();
                }
                else
                {
                    txbKetQua.Text = "a =  " + a.ToString() + "\r\nb = " + b.ToString() + "\r\nc =  " + c.ToString()
                                   + "\r\nPhương trình vô nghiệm";
                    txbX1.Text = txbX2.Text = "";
                }
            }
        }
    }
}