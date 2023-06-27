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
    public partial class FrmDanhMucQuanLy :DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrmDanhMucQuanLy()
        {
            InitializeComponent();
        }

        private void FrmDanhMucQuanLy_Load(object sender, EventArgs e)
        {

        }
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            FrmDanhMucQuanLy ql = new FrmDanhMucQuanLy();
            ql.Show();
        }

        private void tadDangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.Show();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabThuongHieu_Click(object sender, EventArgs e)
        {
            FrmThuongHieu th = new FrmThuongHieu();
            th.Show();
        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            nv.Show();
        }

        private void tabKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang kh = new FrmKhachHang();
            kh.Show();
        }

        private void tabSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham sp = new FrmSanPham();
            sp.Show();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            FrmHoaDon hd = new FrmHoaDon();
            hd.Show();
        }

        private void tabTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimKiem tk = new FrmTimKiem();
            tk.Show();
        }

        private void tabDanhSach_Click(object sender, EventArgs e)
        {
            FrmThongKe tk = new FrmThongKe();
            tk.Show();
        }

        private void TabLienHe_Click(object sender, EventArgs e)
        {
            FrmLienHeND lh = new FrmLienHeND();
            lh.Show();
        }

        private void TabThayDoi_Click(object sender, EventArgs e)
        {
            FrmDangKy dk = new FrmDangKy();
            dk.Show();
        }
    }
}
