using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLT2_Chuong4_DongChuChuyenDong
{
    public partial class frmMove : Form
    {
        bool Kt;  	
        //Kt=true chuyen dong sang phai, Kt=false chuyen dong sang trai
        public frmMove()
        {
            InitializeComponent();
        }

        private void frmMove_Load(object sender, EventArgs e)
        {
            Kt = true;
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            if (Kt)
            {
                if (lblMove.Left + lblMove.Width < this.Width)
                    lblMove.Left = lblMove.Left + 15;
                else
                    Kt = false;
            }
            if (!Kt)
            {
                if (lblMove.Left > 0)
                    lblMove.Left = lblMove.Left - 15;
                else
                    Kt = true;
            }

        }
    }
}
