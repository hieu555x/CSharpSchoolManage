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
    public partial class fThemKetQua : Form
    {
        public fThemKetQua()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txbMaKetQua.Text == "" || this.txbTenKetQua.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if(new DataProvider().ExcuteQuery("SELECT * FROM dbo.KETQUA WHERE MaKetQua = '" + this.txbMaKetQua.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Mã kết quả đã tồn tại", "Thông Báo");
            }
            else
            {
                string query = "INSERT INTO dbo.KETQUA VALUES  ( '" + this.txbMaKetQua.Text + "',N'" + this.txbTenKetQua.Text + "')";
                new DataProvider().ExcuteNoQuery(query);
                MessageBox.Show("Thêm kết quả mới thành công", "Thông Báo");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
