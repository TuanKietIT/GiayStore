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
    public partial class FrmKhachHang : Form
    {
        DataDL dt;
        tblKhachHang kh = new tblKhachHang();
        public FrmKhachHang()
        {
            dt = new DataDL();
            InitializeComponent();
        }
        public void LayDS(DataGridView dgv)
        {
            dgv.DataSource = dt.LayDSKH();
        }

        public void HienThi()
        {
            dgvKhachHang.DataSource = null;
            LayDS(dgvKhachHang);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnDong.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            reset();
        }

        public void reset()
        {
            txtMaKhachHang.Text = "KH0";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            mtbSoDienThoai.Text = "";
            dtpNgayDatHang.Value = DateTime.Now;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kh.MaKhachHang = txtMaKhachHang.Text.Trim();
            kh.TenKhachHang = txtTenKhachHang.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            kh.SoDienThoai = mtbSoDienThoai.Text.Trim();
            kh.NgayDatHang = dtpNgayDatHang.Value;
            using (DBGEntities db = new DBGEntities())
            {
                if (txtMaKhachHang.Text == "" || txtTenKhachHang.Text == "" || txtDiaChi.Text == "" || mtbSoDienThoai.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập thông tin đầy đủ!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else
                {
                    db.tblKhachHangs.Add(kh);
                    db.SaveChanges();
                    MessageBox.Show("Bạn đã lưu thông tin thành công!!");
                }
            }
            HienThi();
            reset();
            MessageBox.Show("Bạn đã lưu thông tin thành công!!");
        }


        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kh.MaKhachHang = Convert.ToString(dgvKhachHang.CurrentRow.Cells["MaKhachHang"].Value);
            using (DBGEntities db = new DBGEntities())
            {
                kh = db.tblKhachHangs.Where(k => k.MaKhachHang == kh.MaKhachHang).FirstOrDefault();
                txtMaKhachHang.Text = kh.MaKhachHang;
                txtTenKhachHang.Text = kh.TenKhachHang;
                txtDiaChi.Text = kh.DiaChi;
                mtbSoDienThoai.Text = kh.SoDienThoai;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            kh.MaKhachHang = txtMaKhachHang.Text.Trim();
            kh.TenKhachHang = txtTenKhachHang.Text.Trim();
            kh.DiaChi = txtDiaChi.Text.Trim();
            kh.SoDienThoai = mtbSoDienThoai.Text.Trim();
            kh.NgayDatHang = dtpNgayDatHang.Value;
            using (DBGEntities db = new DBGEntities())
            {
                db.Entry(kh).State = EntityState.Modified;
                db.SaveChanges();
            }
            HienThi();
            MessageBox.Show("Bạn đã lưu thông tin thành công!!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvKhachHang.CurrentRow.Index != -1)
                {
                    kh.MaKhachHang = txtMaKhachHang.Text.Trim();
                    kh.TenKhachHang = txtTenKhachHang.Text.Trim();
                    kh.DiaChi = txtDiaChi.Text.Trim();
                    kh.SoDienThoai = mtbSoDienThoai.Text.Trim();
                    kh.NgayDatHang = dtpNgayDatHang.Value;
                    using (DBGEntities db = new DBGEntities())
                    {
                        db.Entry(kh).State = EntityState.Modified;
                        db.tblKhachHangs.Remove(kh);
                        db.SaveChanges();
                        MessageBox.Show("Bạn đã lưu thông tin thành công!!");
                    }
                    HienThi();
                    reset();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
            reset();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                var KH = db.tblKhachHangs.Where(kh => kh.MaKhachHang.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (KH != null)
                {
                    dgvKhachHang.DataSource = db.tblKhachHangs.Where(k => k.MaKhachHang.Contains(txtTimKiem.Text))
                    .Select(k => new
                    {
                        k.MaKhachHang,
                        k.TenKhachHang,
                        k.DiaChi,
                        k.SoDienThoai,
                        k.NgayDatHang
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }


            }
        }
    }
}
