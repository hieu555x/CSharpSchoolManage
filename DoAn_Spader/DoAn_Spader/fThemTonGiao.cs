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
    public partial class fThemTonGiao : Form
    {
        DataProvider data = new DataProvider();

        public fThemTonGiao()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txbMaTonGiao.Text == ""||this.txbTenTonGiao.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if(data.ExcuteQuery("SELECT * FROM dbo.TONGIAO WHERE MaTonGiao = '" + this.txbMaTonGiao.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Mã tôn giáo đã tồn tại", "Thông báo");
            }
            else
            {
                string query = "INSERT INTO dbo.TONGIAO VALUES  ( '" + this.txbMaTonGiao.Text + "',N'" + this.txbTenTonGiao.Text + "')";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Thêm thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
