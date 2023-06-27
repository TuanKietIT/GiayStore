using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay
{
    public partial class FrmGiaoDien : Form
    {
        public FrmGiaoDien()
        {
            InitializeComponent();
        }

        private void NhanVien_Click(object sender, EventArgs e)
        {
            FrmDanhMucNhanVien nv = new FrmDanhMucNhanVien();
            nv.Show();
        }

        private void QuanLy_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.Show();
        }
    }
}
