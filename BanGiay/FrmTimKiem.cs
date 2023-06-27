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
    public partial class FrmTimKiem : Form
    {
        DataDL dt;
        public FrmTimKiem()
        {
            InitializeComponent();
            dt = new DataDL();
        }
      
       

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                var NV = db.tblNhanViens.Where(nv => nv.MaNhanVien.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (NV != null)
                {
                   dgvTimKiem.DataSource = db.tblNhanViens.Where(nv => nv.MaNhanVien.Contains(txtTimKiem.Text))
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
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
               
            }
        }

        private void btnTimHD_Click(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                var HD = db.tblHoaDons.Where(hd => hd.MaHoaDon.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (HD != null)
                {
                     dgvTimKiem.DataSource = db.tblHoaDons.Where(h => h.MaHoaDon.Contains(txtTimKiem.Text))
                     .Select(h => new
                      {
                            h.MaHoaDon,
                            h.MaKhachHang,
                            h.MaNhanVien,
                            h.NgayBan,
                            h.TongTien
                       }).ToList();
                }
                else
                {
                        MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
               
            }
           
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                var KH = db.tblKhachHangs.Where(kh => kh.MaKhachHang.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (KH != null)
                {
                    dgvTimKiem.DataSource = db.tblKhachHangs.Where(k => k.MaKhachHang.Contains(txtTimKiem.Text))
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

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                var SP = db.tblSanPhams.Where(kh => kh.MaSanPham.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (SP != null)
                {
                    string keyword = txtTimKiem.Text.Trim();
                    dgvTimKiem.DataSource = db.tblSanPhams.Where(sp => sp.MaSanPham.Contains(keyword))
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

        private void btnTimCTHD_Click(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                var CTHD = db.tblCTHDs.Where(ct => ct.MaHoaDon.Equals(txtTimKiem.Text)).FirstOrDefault();
                if (CTHD != null)
                {
                    string keyword = txtTimKiem.Text.Trim();
                    dgvTimKiem.DataSource = db.tblCTHDs.Where(ct => ct.MaHoaDon.Contains(keyword))
                    .Select(c => new
                    {
                        c.MaHoaDon,
                        c.MaSanPham,
                        c.SoLuong,
                        c.DonGia,
                        c.GiamGia,
                        c.ThanhTien
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
