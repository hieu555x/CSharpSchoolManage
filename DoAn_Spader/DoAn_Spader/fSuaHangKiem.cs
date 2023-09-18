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
    public partial class fSuaHangKiem : Form
    {
        public fSuaHangKiem(string s)
        {
            InitializeComponent();
            this.txbMaHangKiem.Text = s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txbMaHangKiem.Text == "" || this.txbTenHangKiem.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else
            {
                new DataProvider().ExcuteNoQuery("UPDATE dbo.HANHKIEM SET TenHanhKiem = N'" + this.txbTenHangKiem.Text + "' WHERE MaHanhKiem = '" + this.txbMaHangKiem.Text + "'");
                MessageBox.Show("Sửa hạng kiểm thành công", "Thông Báo");
                this.Close();
            }
        }
    }
}
