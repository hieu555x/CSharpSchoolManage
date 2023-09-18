using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_Spader.DAO;

namespace DoAn_Spader
{
    public partial class fDoiMatKhau : Form
    {
        public fDoiMatKhau()
        {
            InitializeComponent();
        }

        private void txbMatKhauCu_TextChange(object sender, EventArgs e)
        {
            if (this.txbMatKhauCu.Text != "")
            {
                this.txbMatKhauCu.UseSystemPasswordChar = true;
            }
            else
            {
                this.txbMatKhauCu.UseSystemPasswordChar = false;
            }
        }

        private void txbMatKhauMoi_TextChange(object sender, EventArgs e)
        {
            if (this.txbMatKhauMoi.Text != "")
            {
                this.txbMatKhauMoi.UseSystemPasswordChar = true;
            }
            else
            {
                this.txbMatKhauMoi.UseSystemPasswordChar = false;
            }
        }

        private void txbXacNhan_TextChange(object sender, EventArgs e)
        {
            if (this.txbXacNhan.Text != "")
            {
                this.txbXacNhan.UseSystemPasswordChar = true;
            }
            else
            {
                this.txbXacNhan.UseSystemPasswordChar = false;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (new DataProvider().ExcuteQuery("SELECT * FROM dbo.NGUOIDUNG WHERE TenDNhap = '" + User.UserID + "' AND MatKhau = '" + this.txbMatKhauCu.Text + "'").Rows.Count == 0) 
            {
                MessageBox.Show("Mật khẩu cũ nhập vào không đúng vui lòng kiểm tra lại", "Thông Báo");
            }
            else if (!this.txbMatKhauMoi.Text.Equals(this.txbXacNhan.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng vui lòng kiểm tra lại", "Thông Báo");
            }
            else
            {
                string query = "UPDATE dbo.NGUOIDUNG SET MatKhau = '" + this.txbMatKhauMoi.Text + "' WHERE TenDNhap = '" + User.UserID + "'";
                new DataProvider().ExcuteNoQuery(query);
                MessageBox.Show("Mật khẩu đã được đổi", "Thông Báo");
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
