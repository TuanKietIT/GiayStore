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
    public partial class FrmNhanVien : Form
    {
        tblNhanVien nv = new tblNhanVien();
        DataDL dt;
        public FrmNhanVien()
        {
            InitializeComponent();
            dt = new DataDL();
        }

        
        public void LayDS(DataGridView dgv)
        {
            dgv.DataSource = dt.LayDSNV();
        }

        public void HienThi()
        {
            dgvNhanVien.DataSource = null;
            LayDS(dgvNhanVien);
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        public void reset()
        {
            txtMaNhanVien.Text = "NV0";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            mtbSoDienThoai.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            reset();
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = false;
        }
       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            nv.MaNhanVien = txtMaNhanVien.Text.Trim();
            nv.TenNhanVien = txtTenNhanVien.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.GioiTinh = txtGioiTinh.Text.Trim();
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.SoDienThoai = mtbSoDienThoai.Text.Trim();
            using (DBGEntities db = new DBGEntities())
            {
                if (txtMaNhanVien.Text == "" || txtTenNhanVien.Text == "" || txtDiaChi.Text == "" || txtGioiTinh.Text == "" || mtbSoDienThoai.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập thông tin đầy đủ!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.tblNhanViens.Add(nv);
                    db.SaveChanges();
                    MessageBox.Show("Bạn đã lưu thông tin thành công!!");
                }
            }
            HienThi();
            reset();
        }
        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nv.MaNhanVien = Convert.ToString(dgvNhanVien.CurrentRow.Cells["MaNhanVien"].Value);
            if (dgvNhanVien.CurrentRow.Index != -1)
            {
                using (DBGEntities db = new DBGEntities())
                {
                    nv = db.tblNhanViens.Where(n => n.MaNhanVien == nv.MaNhanVien).FirstOrDefault();
                    txtMaNhanVien.Text = nv.MaNhanVien;
                    txtTenNhanVien.Text = nv.TenNhanVien;
                    txtDiaChi.Text = nv.DiaChi;
                    txtGioiTinh.Text = nv.GioiTinh;
                    mtbSoDienThoai.Text = nv.SoDienThoai;
                    dtpNgaySinh.Value = nv.NgaySinh;
                }
                btnLuu.Text = "Lưu";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnDong.Enabled = true;
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            nv.MaNhanVien = txtMaNhanVien.Text.Trim();
            nv.TenNhanVien = txtTenNhanVien.Text.Trim();
            nv.DiaChi = txtDiaChi.Text.Trim();
            nv.GioiTinh = txtGioiTinh.Text.Trim();
            nv.NgaySinh = dtpNgaySinh.Value;
            nv.SoDienThoai = mtbSoDienThoai.Text.Trim();
            using (DBGEntities db = new DBGEntities())
            {
                db.Entry(nv).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Bạn đã sửa thông tin thành công!!");
            }
            HienThi();
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa dữ liệu hay không !!!", "Thong bao!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nv.MaNhanVien = txtMaNhanVien.Text.Trim();
                nv.TenNhanVien = txtTenNhanVien.Text.Trim();
                nv.DiaChi = txtDiaChi.Text.Trim();
                nv.GioiTinh = txtGioiTinh.Text.Trim();
                nv.NgaySinh = dtpNgaySinh.Value;
                nv.SoDienThoai = mtbSoDienThoai.Text.Trim();
                using (DBGEntities db = new DBGEntities())
                {
                    db.Entry(nv).State = EntityState.Modified;
                    db.tblNhanViens.Remove(nv);
                    db.SaveChanges();
                    MessageBox.Show("Bạn đã xóa thông tin thành công!!");
                }
                HienThi();
                reset();
            }
        }

       

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            reset();
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
            HienThi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                var NV = db.tblNhanViens.Where(nv => nv.MaNhanVien.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (NV != null)
                {
                    dgvNhanVien.DataSource = db.tblNhanViens.Where(nv => nv.MaNhanVien.Contains(txtTimKiem.Text))
                   .Select(nv => new
                   {
                       nv.MaNhanVien,
                       nv.TenNhanVien,
                       nv.SoDienThoai,
                       nv.NgaySinh,
                       nv.GioiTinh,
                       nv.DiaChi
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
