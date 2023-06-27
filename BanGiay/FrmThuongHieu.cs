using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay.Class;
namespace BanGiay
{
    public partial class FrmThuongHieu : Form
    {
        DataDL dt;
        tblThuongHieu th = new tblThuongHieu();
        public FrmThuongHieu()
        {
            InitializeComponent();
            dt = new DataDL();
        }

        public void LayDS(DataGridView dvg)
        {
            dvg.DataSource = dt.LayDSTH();
        }

        public void HienThi()
        {
            dgvThuongHieu.DataSource = null;
            LayDS(dgvThuongHieu);
        }

        private void FrmThuongHieu_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void dgvThuongHieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            th.MaThuongHieu = Convert.ToString(dgvThuongHieu.CurrentRow.Cells["MaThuongHieu"].Value);
            if (dgvThuongHieu.CurrentRow.Index != -1)
            {
                using (DBGEntities db = new DBGEntities())
                {
                    th = db.tblThuongHieux.Where(t => t.MaThuongHieu == th.MaThuongHieu).FirstOrDefault();
                    txtMaThuongHieu.Text = th.MaThuongHieu;
                    txtTenThuongHieu.Text = th.TenThuongHieu;
                }
                btnLuu.Text = "Lưu";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnDong.Enabled = true;
            }
        }
        public void capnhat()
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
        }
        public void reset()
        {
            txtMaThuongHieu.Text = "TH0";
            txtTenThuongHieu.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnDong.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        
      

        private void btnLuu_Click(object sender, EventArgs e)
        {
            th.MaThuongHieu = txtMaThuongHieu.Text.Trim();
            th.TenThuongHieu = txtTenThuongHieu.Text.Trim();
            using (DBGEntities db = new DBGEntities())
            {
                if (txtMaThuongHieu.Text == "" || txtTenThuongHieu.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập thông tin!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else
                {
                    db.tblThuongHieux.Add(th);
                    db.SaveChanges();
                    MessageBox.Show("Bạn đã thêm thành công!!");
                }

            }
            HienThi();
            reset();
            capnhat();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            th.MaThuongHieu = txtMaThuongHieu.Text.Trim();
            th.TenThuongHieu = txtTenThuongHieu.Text.Trim();
            using (DBGEntities db = new DBGEntities())
            {
                db.Entry(th).State = EntityState.Modified;
                db.SaveChanges();
            }
            MessageBox.Show("Bạn đã sửa thành công!!");
            HienThi();
        }




        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            reset();
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                th.MaThuongHieu = txtMaThuongHieu.Text.Trim();
                th.TenThuongHieu = txtTenThuongHieu.Text.Trim();
                using (DBGEntities db = new DBGEntities())
                {
                    db.Entry(th).State = EntityState.Modified;
                    db.tblThuongHieux.Remove(th);
                    db.SaveChanges();
                }
                MessageBox.Show("Bạn đã xóa thành công!!");
                HienThi();
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                var TH = db.tblThuongHieux.Where(th => th.MaThuongHieu.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (TH != null)
                {
                    dgvThuongHieu.DataSource = db.tblThuongHieux.Where(th => th.MaThuongHieu.Contains(txtTimKiem.Text))
                   .Select(th => new
                   {
                       th.MaThuongHieu,
                       th.TenThuongHieu
                   }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
