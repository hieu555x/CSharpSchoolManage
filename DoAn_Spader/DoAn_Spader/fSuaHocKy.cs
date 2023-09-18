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
    public partial class fSuaHocKy : Form
    {
        DataProvider data = new DataProvider();

        public fSuaHocKy(string s)
        {
            InitializeComponent();
            this.txbMaHocKy.Text = s;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(this.txbTenHocKy.Text==""||this.ddHeSo.SelectedItem == null)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else
            {
                string query = "UPDATE dbo.HOCKY SET TenHocKy = N'" + this.txbTenHocKy.Text + "',HeSo = " + this.ddHeSo.SelectedItem.ToString() + " WHERE MaHocKy = '" + this.txbMaHocKy.Text + "'";
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
