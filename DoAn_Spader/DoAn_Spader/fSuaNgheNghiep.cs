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
    public partial class fSuaNgheNghiep : Form
    {
        DataProvider data = new DataProvider();

        public fSuaNgheNghiep(string s)
        {
            InitializeComponent();
            this.txbMaNgheNghiep.Text = s;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txbTenNgheNghiep.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else
            {
                string query = "UPDATE dbo.NGHENGHIEP SET TenNghe = N'" + this.txbTenNgheNghiep.Text + "' WHERE MaNghe = '" + this.txbMaNgheNghiep.Text + "'";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Sửa thành công", "Thông báo");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
