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
    public partial class fThemPhanCong : Form
    {
        DataProvider data = new DataProvider();

        public fThemPhanCong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fThemPhanCong_Load(object sender, EventArgs e)
        {
            DataTable dataDropDown = data.ExcuteQuery("SELECT * FROM dbo.GIAOVIEN");
            for(int i = 0; i < dataDropDown.Rows.Count; i++)
            {
                ddGiaoVien.Items.Add(dataDropDown.Rows[i]["TenGiaoVien"] + "_" + dataDropDown.Rows[i]["MaGiaoVien"]);
            }

            dataDropDown = data.ExcuteQuery("SELECT * FROM dbo.LOP");
            for(int i = 0; i < dataDropDown.Rows.Count; i++)
            {
                ddLop.Items.Add(dataDropDown.Rows[i]["TenLop"] + "_" + dataDropDown.Rows[i]["MaLop"]);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (ddGiaoVien.SelectedItem == null || ddLop.SelectedItem == null )
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (data.ExcuteQuery("SELECT * FROM dbo.PHANCONG WHERE MaLop = '" + ddLop.SelectedItem.ToString().Split('_')[1] + "' AND MaGiaoVien = '" + ddGiaoVien.SelectedItem.ToString().Split('_')[1] + "'").Rows.Count > 0) 
            {
                MessageBox.Show("Đã có người dạy lớp này của môn này vui lòng kiểm tra lại", "Thông báo");
            }
            else
            {
                string maGiaoVien = ddGiaoVien.SelectedItem.ToString().Split('_')[1];
                string maLop = ddLop.SelectedItem.ToString().Split('_')[1];
                string maNamHoc = data.ExcuteQuery("SELECT * FROM dbo.LOP WHERE MaLop = '" + maLop + "'").Rows[0]["MaNamHoc"].ToString();
                string maMonHoc = data.ExcuteQuery("SELECT * FROM dbo.GIAOVIEN WHERE MaGiaoVien = '" + maGiaoVien + "'").Rows[0]["MaMonHoc"].ToString();
                string query = "INSERT dbo.PHANCONG VALUES  ( '" + maNamHoc + "' , '" + maLop + "' , '" + maMonHoc + "' , '" + maGiaoVien + "' )";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Thêm thành công", "Thông Báo");
                this.Close();
            }
        }
    }
}
