using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanGiay.Class;
namespace BanGiay
{
    public partial class FrmSanPham : Form
    {
        DataDL dt;
        tblSanPham sp = new tblSanPham();
        public FrmSanPham()
        {
            InitializeComponent();
            dt = new DataDL();
        }

        public void LayDS(DataGridView dgv)
        {
            dgv.DataSource = dt.LayDSSP();
        }

        public void HienThi()
        {
            dgvSanPham.DataSource = null;
            LayDS(dgvSanPham);
        }

        public void LayGT(ComboBox cb)
        {
            cb.DataSource = dt.LayDSTH();
            cb.DisplayMember = "TenThuongHieu";
            cb.ValueMember = "MaThuongHieu";
        }
        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            HienThi();
            LayGT(cboMaThuongHieu);
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtHinhAnh.Text = dlgOpen.FileName;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Reset();
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnDong.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        private void Reset()
        {
            txtMaSanPham.Text = "SP0";
            txtTenSanPham.Text = "";
            txtKichCo.Text = "0";
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            txtHinhAnh.Text = "";
            txtGhiChu.Text = "";
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            sp.MaSanPham = txtMaSanPham.Text.Trim();
            sp.TenSanPham = txtTenSanPham.Text.Trim();
            sp.MaThuongHieu = cboMaThuongHieu.SelectedValue.ToString();
            sp.KichCo = Int32.Parse(txtKichCo.Text.Trim());
            sp.NgayNhap = dtpNgayNhap.Value;
            sp.SoLuong = float.Parse(txtSoLuong.Text.Trim());
            sp.DonGiaBan = float.Parse(txtDonGiaBan.Text.Trim());
            sp.DonGiaNhap = float.Parse(txtDonGiaBan.Text.Trim());
            sp.Anh = txtHinhAnh.Text.Trim();
            sp.GhiChu = txtGhiChu.Text.Trim();
            using (DBGEntities db = new DBGEntities())
            {
                if (txtMaSanPham.Text == "" || txtTenSanPham.Text == "" || txtKichCo.Text == "" || txtHinhAnh.Text == "" || txtDonGiaNhap.Text == "" ||
                    txtDonGiaBan.Text == "" || txtSoLuong.Text == "" || txtGhiChu.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập thông tin đầy đủ!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else
                {
                    db.tblSanPhams.Add(sp);
                    db.SaveChanges();
                    MessageBox.Show("Bạn đã lưu thông tin thành công!!");
                }

            }
            HienThi();
            Reset();
            CapNhat();

        }
        private void CapNhat()
        {
            btnDong.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;

        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sp.MaSanPham = Convert.ToString(dgvSanPham.CurrentRow.Cells["MaSanPham"].Value);
            if (dgvSanPham.CurrentRow.Index != -1)
            {
                using (DBGEntities db = new DBGEntities())
                {
                    sp = db.tblSanPhams.Where(n => n.MaSanPham == sp.MaSanPham).FirstOrDefault();
                    txtMaSanPham.Text = sp.MaSanPham;
                    txtTenSanPham.Text = sp.TenSanPham;
                    cboMaThuongHieu.SelectedValue = sp.MaThuongHieu;
                    txtKichCo.Text = sp.KichCo.ToString();
                    dtpNgayNhap.Value = sp.NgayNhap.Value;
                    txtSoLuong.Text = sp.SoLuong.ToString();
                    txtDonGiaNhap.Text = sp.DonGiaNhap.ToString();
                    txtDonGiaBan.Text = sp.DonGiaBan.ToString();
                    txtHinhAnh.Text = sp.Anh;
                    picAnh.Image = Image.FromFile(txtHinhAnh.Text);
                    txtGhiChu.Text = sp.GhiChu;

                }
                btnLuu.Text = "Lưu";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnDong.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sp.MaSanPham = txtMaSanPham.Text.Trim();
            sp.TenSanPham = txtTenSanPham.Text.Trim();
            sp.MaThuongHieu = cboMaThuongHieu.SelectedValue.ToString();
            sp.KichCo = Int32.Parse(txtKichCo.Text.Trim());
            sp.NgayNhap = dtpNgayNhap.Value;
            sp.SoLuong = float.Parse(txtSoLuong.Text.Trim());
            sp.DonGiaBan = float.Parse(txtDonGiaBan.Text.Trim());
            sp.DonGiaNhap = float.Parse(txtDonGiaBan.Text.Trim());
            sp.Anh = txtHinhAnh.Text.Trim();
            sp.GhiChu = txtGhiChu.Text.Trim();
            using (DBGEntities db = new DBGEntities())
            {
                db.Entry(sp).State = EntityState.Modified;
                db.SaveChanges();
            }
            HienThi();
            MessageBox.Show("Bạn đã Sửa thông tin thành công!!");
            Reset();
            CapNhat();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sp.MaSanPham = txtMaSanPham.Text.Trim();
                sp.TenSanPham = txtTenSanPham.Text.Trim();
                sp.MaThuongHieu = cboMaThuongHieu.SelectedValue.ToString();
                sp.KichCo = Int32.Parse(txtKichCo.Text.Trim());
                sp.NgayNhap = dtpNgayNhap.Value;
                sp.SoLuong = float.Parse(txtSoLuong.Text.Trim());
                sp.DonGiaBan = float.Parse(txtDonGiaBan.Text.Trim());
                sp.DonGiaNhap = float.Parse(txtDonGiaBan.Text.Trim());
                sp.Anh = txtHinhAnh.Text.Trim();
                sp.GhiChu = txtGhiChu.Text.Trim();
                using (DBGEntities db = new DBGEntities())
                {
                    db.Entry(sp).State = EntityState.Modified;
                    db.tblSanPhams.Remove(sp);
                    db.SaveChanges();
                    MessageBox.Show("Bạn đã Xóa thông tin thành công!!");
                }
            }
            HienThi();
            Reset();
            CapNhat();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Reset();
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnDong.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                var SP = db.tblSanPhams.Where(kh => kh.MaSanPham.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (SP != null)
                {
                    string keyword = txtTimKiem.Text.Trim();
                    dgvSanPham.DataSource = db.tblSanPhams.Where(sp => sp.MaSanPham.Contains(keyword))
                    .Select(s => new
                    {
                        s.MaSanPham,
                        s.TenSanPham,
                        s.MaThuongHieu,
                        s.KichCo,
                        s.SoLuong,
                        s.NgayNhap,
                        s.DonGiaNhap,
                        s.DonGiaBan,
                        s.GhiChu,
                        s.Anh
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
