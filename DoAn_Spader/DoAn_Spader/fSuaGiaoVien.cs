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
    public partial class fSuaGiaoVien : Form
    {
        DataProvider data = new DataProvider();

        public fSuaGiaoVien(string s)
        {
            InitializeComponent();
            this.txbMaGiaoVien.Text = s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSuaGiaoVien_Load(object sender, EventArgs e)
        {
            DataTable dataMonHoc = data.ExcuteQuery("SELECT * FROM dbo.MONHOC");
            for(int i = 0; i < dataMonHoc.Rows.Count; i++)
            {
                ddMonHoc.Items.Add(dataMonHoc.Rows[i]["TenMonHoc"] + "_" + dataMonHoc.Rows[i]["MaMonHoc"]);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txbTenGiaoVien.Text == "" || this.txbDienThoai.Text == "" || this.txbDiaChi.Text == "" || this.ddMonHoc.SelectedItem == null)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông Báo");
            }
            else
            {
                string maMon = this.ddMonHoc.SelectedItem.ToString().Split('_')[1];
                string query = "UPDATE dbo.GIAOVIEN SET TenGiaoVien = N'" + this.txbTenGiaoVien.Text + "',DiaChi = N'" + this.txbDiaChi.Text + "',DienThoai = '" + this.txbDienThoai.Text + "',MaMonHoc = '" + maMon + "' WHERE MaGiaoVien = '" + this.txbMaGiaoVien.Text + "'";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Sửa thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
