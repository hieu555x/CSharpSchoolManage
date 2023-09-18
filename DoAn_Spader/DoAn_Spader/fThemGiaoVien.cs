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
    public partial class fThemGiaoVien : Form
    {
        DataProvider data = new DataProvider();

        public fThemGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThemGiaoVien_Load(object sender, EventArgs e)
        {
            DataTable dataGiaoVien = data.ExcuteQuery("SELECT * FROM dbo.MONHOC");
            for(int i = 0; i < dataGiaoVien.Rows.Count; i++)
            {
                ddMonHoc.Items.Add(dataGiaoVien.Rows[i]["TenMonHoc"] + "_" + dataGiaoVien.Rows[i]["MaMonHoc"]);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txbMaGiaoVien.Text == "" || this.txbTenGiaoVien.Text == "" || this.txbDiaChi.Text == "" || this.txbDienThoai.Text == "" || this.ddMonHoc.SelectedItem == null)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (data.ExcuteQuery("SELECT * FROM dbo.GIAOVIEN WHERE MaGiaoVien = '" + this.txbMaGiaoVien.Text + "'").Rows.Count > 0) 
            {
                MessageBox.Show("Mã giáo viên đã tồn tại", "Thông Báo");
            }
            else
            {
                string maMon = this.ddMonHoc.SelectedItem.ToString().Split('_')[1];
                string query = "INSERT dbo.GIAOVIEN VALUES  ( '" + this.txbMaGiaoVien.Text + "' , N'" + this.txbTenGiaoVien.Text + "' , N'" + this.txbDiaChi.Text + "' , '" + this.txbDienThoai.Text + "' , '" + maMon + "' )";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Thêm mới thành công", "Thông Báo");
                this.Close();
            }
        }
    }
}
