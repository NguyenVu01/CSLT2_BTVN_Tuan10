using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLT2_Chuong4_BanSachQuaMang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lbDanhSachMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHangDatMua.Items.Contains(lbDanhSachMatHang.SelectedItem))
            {
                MessageBox.Show("Bạn đã chọn cuốn " + lbDanhSachMatHang.SelectedItem.ToString() + " rồi!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbHangDatMua.Items.Add(lbDanhSachMatHang.SelectedItem.ToString());
            }
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if(txbHoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên!");
            }
            else if(txbDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!");
            }
            else if(lbHangDatMua.Items.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn cuốn sách nào!");
            }
            else if(!rdn1.Checked && !rdn2.Checked && !rdn3.Checked)
            {
                MessageBox.Show("Bạn chưa chọn phương thức thanh toán!");
            }
            else if (!ckb1.Checked && !ckb2.Checked && !ckb3.Checked)
            {
                MessageBox.Show("Bạn chưa chọn hình thức liên lạc!");
            }
            else
            {
                if (rdn1.Checked)
                {
                    if (ckb1.Checked && !ckb2.Checked && !ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn1.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text);
                    }
                    if (ckb2.Checked && !ckb1.Checked && !ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn1.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb2.Text);
                    }
                    if (ckb3.Checked && !ckb1.Checked && !ckb2.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn1.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb3.Text);
                    }
                    if (ckb1.Checked && ckb2.Checked && !ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn1.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text + ", " + ckb2.Text);
                    }
                    if (ckb2.Checked && ckb3.Checked && !ckb1.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn1.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb2.Text + ", " + ckb3.Text);
                    }
                    if (ckb1.Checked && ckb3.Checked && !ckb2.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn1.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text + ", " + ckb3.Text);
                    }
                    if (ckb1.Checked && ckb2.Checked && ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Text
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn1.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text + ", " + ckb2.Text + ", " + ckb3.Text);
                    }
                }
                if (rdn2.Checked)
                {
                    if (ckb1.Checked && !ckb2.Checked && !ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn2.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text);
                    }
                    if (ckb2.Checked && !ckb1.Checked && !ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn2.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb2.Text);
                    }
                    if (ckb3.Checked && !ckb1.Checked && !ckb2.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn2.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb3.Text);
                    }
                    if (ckb1.Checked && ckb2.Checked && !ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn2.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text + ", " + ckb2.Text);
                    }
                    if (ckb2.Checked && ckb3.Checked && !ckb1.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn2.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb2.Text + ", " + ckb3.Text);
                    }
                    if (ckb1.Checked && ckb3.Checked && !ckb2.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn2.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text + ", " + ckb3.Text);
                    }
                    if (ckb1.Checked && ckb2.Checked && ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn2.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text + ", " + ckb2.Text + ", " + ckb3.Text);
                    }
                }
                if (rdn3.Checked)
                {
                    if (ckb1.Checked && !ckb2.Checked && !ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn3.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text);
                    }
                    if (ckb2.Checked && !ckb1.Checked && !ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn3.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb2.Text);
                    }
                    if (ckb3.Checked && !ckb1.Checked && !ckb2.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn3.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb3.Text);
                    }
                    if (ckb1.Checked && ckb2.Checked && !ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn3.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text + ", " + ckb2.Text);
                    }
                    if (ckb2.Checked && ckb3.Checked && !ckb1.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn3.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb2.Text + ", " + ckb3.Text);
                    }
                    if (ckb1.Checked && ckb3.Checked && !ckb2.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn3.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text + ", " + ckb3.Text);
                    }
                    if (ckb1.Checked && ckb2.Checked && ckb3.Checked)
                    {
                        MessageBox.Show("Họ tên khách hàng: " + txbHoten.Text
                      + Environment.NewLine + "Địa chỉ: " + txbDiaChi.Text
                      + Environment.NewLine + "Hàng đặt mua: " + lbHangDatMua.Items.ToString()
                      + Environment.NewLine + "Phương thức thanh toán: " + rdn3.Text
                      + Environment.NewLine + "Hình thức liên lạc: " + ckb1.Text + ", " + ckb2.Text + ", " + ckb3.Text);
                    }
                }
            }
        }

        private void lbHangDatMua_DoubleClick(object sender, EventArgs e)
        {
            if(lbHangDatMua.Items.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa "+ lbHangDatMua.SelectedItems.ToString()+"?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    lbHangDatMua.Items.Remove(lbHangDatMua.SelectedItem);
                }
            }
        }
    }
}
