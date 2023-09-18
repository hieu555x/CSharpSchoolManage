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
    public partial class fSuaDanToc : Form
    {
        DataProvider data = new DataProvider();

        public fSuaDanToc(string s)
        {
            InitializeComponent();
            this.txbMaDanToc.Text = s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txbTenDanToc.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else
            {
                data.ExcuteNoQuery("UPDATE dbo.DANTOC SET TenDanToc = '" + this.txbTenDanToc.Text + "' WHERE MaDanToc = '" + this.txbMaDanToc.Text + "'");
                MessageBox.Show("Sửa thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
