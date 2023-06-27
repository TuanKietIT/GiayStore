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
    public partial class FrmDanhMucNhanVien :DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FrmDanhMucNhanVien()
        {
            InitializeComponent();
        }

    
       

        private void FrmDanhMucNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void TabLienHe_Click(object sender, EventArgs e)
        {
            FrmLienHeND lh = new FrmLienHeND();
            lh.Show();
        }

        private void tabKhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang kh = new FrmKhachHang();
            kh.Show();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            FrmHoaDon hd = new FrmHoaDon();
            hd.Show();
        }

        private void tabDanhSach_Click(object sender, EventArgs e)
        {
            FrmThongKe tk = new FrmThongKe();
            tk.Show();
        }

        private void tabTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimKiem t = new FrmTimKiem();
            t.Show();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
