using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLT2_Chuong4_SuChuyenDongCuaMatTrang
{
    public partial class frmMoon : Form
    {
        int Coquay;
        int Curmoon;

        public frmMoon()
        {
            InitializeComponent();
        }

        private void frmMoon_Load(object sender, EventArgs e)
        {
            Coquay = 0;        // Không cho phép quay
            Curmoon = 1;       // Chỉ số ảnh hiện hành
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Coquay == 0)
            {
                Coquay = 1;
                btnStart.Text = "Stop";
            }
            else
            {
                Coquay = 0;
                btnStart.Text = "Start";
            }
        }
        private void Hienthi(int index)
        {
            switch (index)
            {
                case 1:
                    pic.Image = pic1.Image;
                    break;
                case 2:
                    pic.Image = pic2.Image;
                    break;
                case 3:
                    pic.Image = pic3.Image;
                    break;
                case 4:
                    pic.Image = pic4.Image;
                    break;
                case 5:
                    pic.Image = pic5.Image;
                    break;
                case 6:
                    pic.Image = pic6.Image;
                    break;
                case 7:
                    pic.Image = pic7.Image;
                    break;
                case 8:
                    pic.Image = pic8.Image;
                    break;
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            if (Coquay == 1)
                Hienthi(Curmoon);
            Curmoon = Curmoon + 1;
            if (Curmoon == 9)
                Curmoon = 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to exit?","Question?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
