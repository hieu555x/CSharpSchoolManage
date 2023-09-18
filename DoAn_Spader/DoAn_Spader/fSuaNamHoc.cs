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
    public partial class fSuaNamHoc : Form
    {
        DataProvider data = new DataProvider();
        public fSuaNamHoc(string s)
        {
            InitializeComponent();
            this.txbMaNamHoc.Text = s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txbTenNamHoc.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else
            {
                string query = "UPDATE dbo.NAMHOC SET TenNamHoc = N'" + this.txbTenNamHoc.Text + "' WHERE MaNamHoc = '" + this.txbMaNamHoc.Text + "'";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Sửa thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
