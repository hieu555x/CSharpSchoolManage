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
    public partial class fSuaMonHoc : Form
    {
        DataProvider data = new DataProvider();

        public fSuaMonHoc(string s)
        {
            InitializeComponent();
            this.txbMaMonHoc.Text = s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool checkSoTiet = true;
            try
            {
                Convert.ToInt32(this.txbSoTiet.Text);
            }
            catch (Exception ex)
            {
                checkSoTiet = false;
            }
            if (this.txbTenMonHoc.Text == "" || this.txbSoTiet.Text == "" || this.ddHeSo.SelectedItem == null)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkSoTiet)
            {
                MessageBox.Show("Số tiết phải là số", "Thông Báo");
            }
            else
            {
                string query = "UPDATE dbo.MONHOC SET TenMonHoc = N'" + this.txbTenMonHoc.Text + "',SoTiet = " + this.txbSoTiet.Text + ",HeSo = " + this.ddHeSo.SelectedItem.ToString() + " WHERE MaMonHoc = '" + this.txbMaMonHoc.Text + "'";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Sửa thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
