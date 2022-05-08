using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLT2_Chuong4_TimKiemHinhAnh
{
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.gif) |*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\Baigiang";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn hình ảnh để hiển thị";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
            else
                MessageBox.Show("You clicked Cancel", "Open Dialog", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void frmPicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
