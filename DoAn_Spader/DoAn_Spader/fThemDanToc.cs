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
    public partial class fThemDanToc : Form
    {
        public fThemDanToc()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txbMaDanToc.Text == "" || this.txbTenDanToc.Text == "") 
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if(new DataProvider().ExcuteQuery("SELECT * FROM dbo.DANTOC WHERE MaDanToc = '" + this.txbMaDanToc.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Mã dân tộc đã tồn tại", "Thông Báo");
            }
            else
            {
                string query = "INSERT INTO dbo.DANTOC VALUES  ( '" + this.txbMaDanToc.Text + "',N'" + this.txbTenDanToc.Text + "')";
                new DataProvider().ExcuteNoQuery(query);
                MessageBox.Show("Thêm dân tộc mới thành công", "Thông Báo");
                this.Close();
            }
        }
    }
}
