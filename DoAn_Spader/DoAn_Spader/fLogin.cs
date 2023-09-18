using DoAn_Spader.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Spader
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tendn = this.txbTenDN.Text, matkhau = this.txbMatKhau.Text;
            string query = "SELECT * FROM dbo.NGUOIDUNG WHERE TenDNhap = '" + tendn + "' AND MatKhau = '" + matkhau + "'";
            if((new DataProvider().ExcuteQuery(query).Rows.Count) == 1)
            {
                User.UserID = this.txbTenDN.Text;
                User.UserName = new DataProvider().ExcuteQuery("SELECT * FROM dbo.NGUOIDUNG WHERE TenDNhap = '" + tendn + "' AND MatKhau = '" + matkhau + "'").Rows[0]["TenND"].ToString();
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai vui lòng kiểm tra lại", "Thông Báo");
            }
        }
    }
}
