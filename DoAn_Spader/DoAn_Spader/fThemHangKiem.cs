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
    public partial class fThemHangKiem : Form
    {
        public fThemHangKiem()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txbMaHangKiem.Text == "" || this.txbTenHangKiem.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if(new DataProvider().ExcuteQuery("SELECT * FROM dbo.HANHKIEM WHERE MaHanhKiem = '" + this.txbMaHangKiem.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Mã hạng kiểm đã tồn tại", "Thông Báo");
            }
            else
            {
                new DataProvider().ExcuteNoQuery("INSERT INTO dbo.HANHKIEM VALUES  ( '" + this.txbMaHangKiem.Text + "',N'" + this.txbTenHangKiem.Text + "')");
                MessageBox.Show("Thêm hạng kiểm mới thành công", "Thông Báo");
                this.Close();
            }
        }
    }
}
