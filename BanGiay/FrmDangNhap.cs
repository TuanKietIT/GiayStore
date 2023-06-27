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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (DBGEntities db = new DBGEntities())
            {
                
                    if(txtTaiKhoan.Text != string.Empty || txtMatKhau .Text != string.Empty)
                    {
                        var NguoiSuDung = db.tblDangNhaps.Where(dn => dn.TenTaiKhoan.Equals(txtTaiKhoan.Text)).FirstOrDefault();
                        if(NguoiSuDung != null)
                        {
                            if (NguoiSuDung.MatKhau.Equals(txtMatKhau.Text))
                            {
                                 FrmDanhMucQuanLy ql = new FrmDanhMucQuanLy();
                                 ql.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Bạn đẫ nhập sai mật khẩu!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn đẫ nhập sai Tài khoản!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        }  
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không hơp lệ!!", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "phantuankiet";
            txtMatKhau.Text = "123456";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
