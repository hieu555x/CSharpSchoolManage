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
    public partial class fThemNamHoc : Form
    {
        DataProvider data = new DataProvider();

        public fThemNamHoc()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txbMaNamHoc.Text == "" || this.txbTenNamHoc.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if(data.ExcuteQuery("SELECT * FROM dbo.NAMHOC WHERE MaNamHoc = '" + this.txbMaNamHoc.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Mã nghề nghiệp đã tồn tại", "Thông báo");
            }
            else
            {
                string query = "INSERT INTO dbo.NAMHOC VALUES  ( '" + this.txbMaNamHoc.Text + "', '" + this.txbMaNamHoc.Text + "' )";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Thêm thành công", "Thông báo");
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
