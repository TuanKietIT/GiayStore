using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay.Class;
namespace BanGiay
{
    public partial class FrmThongKe : Form
    {
        DataDL dt;
        public FrmThongKe()
        {
            InitializeComponent();
            dt = new DataDL();
        }
        public void LayDSSP(DataGridView dgv)
        {
            dgv.DataSource = dt.LayDSSP();
        }
        public void HienThi()
        {
            dgvDanhSach.DataSource = null;
            LayDSSP(dgvDanhSach);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            HienThi();
        }
        public void LayDSNV(DataGridView dgv)
        {
            dgv.DataSource = dt.LayDSNV();
        }
        public void HienThiDSNV()
        {
            dgvDanhSach.DataSource = null;
            LayDSNV(dgvDanhSach);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            HienThiDSNV();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            HienThiDSNV();
        }
        public void LayDSHD(DataGridView dgv)
        {
            dgv.DataSource = dt.LayDSHD();
        }
        public void HienThiDSHD()
        {
            dgvDanhSach.DataSource = null;
            LayDSHD(dgvDanhSach);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            HienThiDSHD();
        }
        public void LayDSKH(DataGridView dgv)
        {
            dgv.DataSource = dt.LayDSKH();
        }
        public void HienThiDSKH()
        {
            dgvDanhSach.DataSource = null;
            LayDSKH(dgvDanhSach);
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            HienThiDSKH();
        }
        public void LayDSCTHD(DataGridView dgv)
        {
            dgv.DataSource = dt.LayDSCTHD();
        }
        public void HienThiDSCTHD()
        {
            dgvDanhSach.DataSource = null;
            LayDSCTHD(dgvDanhSach);
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            HienThiDSCTHD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
