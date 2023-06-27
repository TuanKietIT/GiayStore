using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanGiay.Class
{
    class DataDL
    {
        DBGEntities db;

        public DataDL()
        {
            db = new DBGEntities();
        }
        public dynamic LayDSTK()
        {
            var TK = db.tblDangNhaps.Select(m => new
            {
                m.TenTaiKhoan,
                m.MatKhau
            }).ToList();
            return TK;
        }

        public dynamic LayDSTH()
        {
            var th = db.tblThuongHieux.Select(a => new
            {
                a.MaThuongHieu,
                a.TenThuongHieu
            }).ToList();
            return th;
        }
        public dynamic LayDSNV()
        {
            var nv = db.tblNhanViens.Select(b => new
            {
                b.MaNhanVien,
                b.TenNhanVien,
                b.SoDienThoai,
                b.NgaySinh,
                b.GioiTinh,
                b.DiaChi
            }).ToList();
            return nv;
        }
        public dynamic LayDSKH()
        {
            var kh = db.tblKhachHangs.Select(k => new
            {
                k.MaKhachHang,
                k.TenKhachHang,
                k.DiaChi,
                k.SoDienThoai,
                k.NgayDatHang
            }).ToList();
            return kh;
        }
        public dynamic LayDSSP()
        {
            var sp = db.tblSanPhams.Select(s => new
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
            return sp;
        }
        public dynamic LayDSHD()
        {
            var hd = db.tblHoaDons.Select(h => new
            {
                h.MaHoaDon,
                h.MaKhachHang,
                h.MaNhanVien,
                h.NgayBan,
                h.TongTien
            }).ToList();
            return hd;
        }
        public dynamic LayDSCTHD()
        {
            var hd = db.tblCTHDs.Select(c => new
            {
                c.MaHoaDon,
                c.MaSanPham,
                c.SoLuong,
                c.DonGia,
                c.GiamGia,
                c.ThanhTien
                
            }).ToList();
            return hd;
        }
        public static SqlConnection Con;

        internal static DataTable GetDataToTable(string sql)
        {
            Con = new SqlConnection(); // Khởi tao đối tượng con
            //Đường dẫn kết nối database
            Con.ConnectionString = Properties.Settings.Default.BanGiay;
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con); //Định nghĩa đối tượng thuộc lớp SqlDataAdapter
            //Khai báo đối tượng table thuộc lớp DataTable
            DataTable table = new DataTable();
            dap.Fill(table); //Đổ kết quả từ câu lệnh sql vào table
            return table;
        }
    }
}
