using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLT2_Chuong4_ThayDoiPhongChu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rdn9_CheckedChanged(object sender, EventArgs e)
        {
            if (rdn9.Checked)
            {
                txbNhap.ForeColor = Color.Blue;
            }
        }

        private void rdn10_CheckedChanged(object sender, EventArgs e)
        {
            if (rdn10.Checked)
            {
                txbNhap.ForeColor = Color.Red;
            }
        }

        private void rdn11_CheckedChanged(object sender, EventArgs e)
        {
            if (rdn11.Checked)
            {
                txbNhap.ForeColor = Color.Yellow;
            }
        }

        private void rdn12_CheckedChanged(object sender, EventArgs e)
        {
            if (rdn12.Checked)
            {
                txbNhap.ForeColor = Color.Purple;
            }
        }

        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            //<TênĐiềukhiển>.Font = new  Font(<TênĐiềukhiển>.Font, FontStyle.HiệuỨng) ;
            if (ckbBold.Checked)
            {
                txbNhap.Font = new Font(txbNhap.Font, txbNhap.Font.Style|FontStyle.Bold);
            }
            else
            {
                txbNhap.Font = new Font(txbNhap.Font, txbNhap.Font.Style ^FontStyle.Bold); //&~ la phu dinh cua Bold
            }
        }

        private void ckbItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbItalic.Checked)
            {
                txbNhap.Font = new Font(txbNhap.Font, txbNhap.Font.Style | FontStyle.Italic);
            }
            else
            {
                txbNhap.Font = new Font(txbNhap.Font, txbNhap.Font.Style ^FontStyle.Italic);
            }
        }

        private void ckbStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbStrikeout.Checked)
            {
                txbNhap.Font = new Font(txbNhap.Font, txbNhap.Font.Style | FontStyle.Strikeout);
            }
            else
            {
                txbNhap.Font = new Font(txbNhap.Font, txbNhap.Font.Style ^FontStyle.Strikeout);
            }
        }

        private void ckbUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbUnderline.Checked)
            {
                txbNhap.Font = new Font(txbNhap.Font, txbNhap.Font.Style | FontStyle.Underline);
            }
            else
            {
                txbNhap.Font = new Font(txbNhap.Font, txbNhap.Font.Style ^FontStyle.Underline);
            }
        }

        private void rdn1_CheckedChanged(object sender, EventArgs e)
        {
            //< TênĐiềukhiển >.Font = new Font("TênFont", Cỡchữ);
            if (rdn1.Checked)
            {
                txbNhap.Font = new Font("Times New Roman", 14);
            }
            else
            {
                txbNhap.Font = new Font(txbNhap.Font, FontStyle.Regular);
            }
        }

        private void rdn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdn2.Checked)
            {
                txbNhap.Font = new Font("Arial", 14);
            }
            else
            {
                txbNhap.Font = new Font(txbNhap.Font, FontStyle.Regular);
            }
        }

        private void rdn3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdn3.Checked)
            {
                txbNhap.Font = new Font("Calibri", 14);
            }
            else
            {
                txbNhap.Font = new Font(txbNhap.Font, FontStyle.Regular);
            }
        }

        private void rdn4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdn4.Checked)
            {
                txbNhap.Font = new Font("Tamaho", 14);
            }
            else
            {
                txbNhap.Font = new Font(txbNhap.Font, FontStyle.Regular);
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txbNhap.Text = "";
            rdn1.Checked = false;
            rdn2.Checked = false;
            rdn3.Checked = false;
            rdn4.Checked = false;
            ckbBold.Checked = false;
            ckbItalic.Checked = false;
            ckbStrikeout.Checked = false;
            ckbUnderline.Checked = false;
            rdn9.Checked = false;
            rdn10.Checked = false;
            rdn11.Checked = false;
            rdn12.Checked = false;
        }
    }
}
