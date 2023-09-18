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
    public partial class fSuaKetQua : Form
    {
        public fSuaKetQua(string s)
        {
            InitializeComponent();
            this.txbMaKetQua.Text = s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txbTenKetQua.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else
            {
                new DataProvider().ExcuteNoQuery("UPDATE dbo.KETQUA SET TenKetQua = N'" + this.txbTenKetQua.Text + "' WHERE MaKetQua = '" + this.txbMaKetQua.Text + "'");
                this.Close();
            }
        }
    }
}
