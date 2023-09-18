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
    public partial class fThemNgheNghiep : Form
    {
        DataProvider data = new DataProvider();

        public fThemNgheNghiep()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txbMaNgheNghiep.Text == "" || this.txbTenNgheNghiep.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if(data.ExcuteQuery("SELECT * FROM dbo.NGHENGHIEP WHERE MaNghe = '" + this.txbMaNgheNghiep.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Mã nghề đã tồn tại", "Thông báo");
            }
            else
            {
                string query = "INSERT INTO dbo.NGHENGHIEP VALUES  ( '" + this.txbMaNgheNghiep.Text + "',N'" + this.txbTenNgheNghiep.Text + "')";
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
