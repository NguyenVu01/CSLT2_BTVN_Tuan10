namespace BTVN_Chuong4_Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EmptyOption()
        {
            rd9.Checked = false;
            rd4.Checked = false;
            rd8.Checked = false;
            rd6.Checked = false;
            rd7.Checked = false;
            rd5.Checked = false;
            rd3.Checked = false;
            rd2.Checked = false;
            rd1.Checked = false;
            rd10.Checked = false;
        }
        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked)
            {
                EmptyOption();
                lblHienThi.Text = "Hãy chọn thành phố cho " + radio.Text;
            } 
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdn1.Checked)
            {
                if (rd1.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn1.Text + " là " + rd1.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn1.Text + " rồi!";
            }
            else if (rdn2.Checked)
            {
                if(rd2.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn2.Text + " là " + rd2.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn2.Text + " rồi!";
            }
            else if (rdn3.Checked)
            {
                if(rd3.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn3.Text + " là " + rd3.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn3.Text + " rồi!";
            }
            else if (rdn4.Checked)
            {
                if(rd4.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn4.Text + " là " + rd4.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn4.Text + " rồi!";
            }
            else if (rdn5.Checked)
            {
                if(rd5.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn5.Text + " là " + rd5.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn5.Text + " rồi!";
            }
            else if (rdn6.Checked)
            {
                if(rd6.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn6.Text + " là " + rd6.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn6.Text + " rồi!";
            }
            else if (rdn7.Checked)
            {
                if(rd7.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn7.Text + " là " + rd7.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn7.Text + " rồi!";
            }
            else if (rdn8.Checked)
            {
                if(rd8.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn8.Text + " là " + rd8.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn8.Text + " rồi!";
            }
            else if (rdn9.Checked)
            {
                if(rd9.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn9.Text + " là " + rd9.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn9.Text + " rồi!";
            }
            else if (rdn10.Checked)
            {
                if(rd10.Checked)
                    lblHienThi.Text = "Chúc mừng bạn, thủ đô của " + rdn10.Text + " là " + rd10.Text;
                else lblHienThi.Text = "Bạn chọn sai thủ đô của " + rdn10.Text + " rồi!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            DialogResult dialog = MessageBox.Show("Bạn có thực sự muốn thoát?", "Câu hỏi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với ứng dụng đất nước và thủ đô");
        }
    }
}