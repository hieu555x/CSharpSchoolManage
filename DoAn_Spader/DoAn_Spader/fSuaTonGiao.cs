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
    public partial class fSuaTonGiao : Form
    {
        public fSuaTonGiao(string s)
        {
            InitializeComponent();
            this.txbMaTonGiao.Text = s;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txbTenTonGiao.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else
            {
                string query = "UPDATE dbo.TONGIAO SET TenTonGiao = N'" + this.txbTenTonGiao.Text + "' WHERE MaTonGiao = '" + this.txbMaTonGiao.Text + "'";
                new DataProvider().ExcuteNoQuery(query);
                MessageBox.Show("Sửa Thành Công", "Thông báo");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
