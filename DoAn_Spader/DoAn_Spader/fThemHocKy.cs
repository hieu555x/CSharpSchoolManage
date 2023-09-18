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
    public partial class fThemHocKy : Form
    {
        DataProvider data = new DataProvider();

        public fThemHocKy()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(this.txbMaHocKy.Text==""||this.txbTenHocKy.Text == "" || this.ddHeSo.SelectedItem == null)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if(data.ExcuteQuery("SELECT* FROM dbo.HOCKY WHERE MaHocKy = '" + this.txbMaHocKy.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Mã học kỳ đã tồn tại", "Thông Báo");
            }
            else
            {
                string query = "INSERT INTO dbo.HOCKY VALUES  ( '" + this.txbMaHocKy.Text + "',N'" + this.txbTenHocKy.Text + "'," + this.ddHeSo.SelectedItem.ToString() + ")";
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
