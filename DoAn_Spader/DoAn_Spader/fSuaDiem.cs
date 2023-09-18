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
    public partial class fSuaDiem : Form
    {
        private string stt;
        DataProvider data = new DataProvider();

        public fSuaDiem(string soThuTu,string tenHS)
        {
            InitializeComponent();
            this.labelTenHS.Text = tenHS;
            this.stt = soThuTu;
        }

        private void fSuaDiem_Load(object sender, EventArgs e)
        {
            DataTable dataMonHoc = data.ExcuteQuery("SELECT * FROM dbo.MONHOC");
            for (int i = 0; i < dataMonHoc.Rows.Count; i++)
            {
                ddMonHoc.Items.Add(dataMonHoc.Rows[i]["TenMonHoc"] + "_" + dataMonHoc.Rows[i]["MaMonHoc"]);
            }

            DataTable dataHocKy = data.ExcuteQuery("SELECT * FROM dbo.HOCKY");
            for (int i = 0; i < dataHocKy.Rows.Count; i++)
            {
                ddHocKy.Items.Add(dataHocKy.Rows[i]["TenHocKy"] + "_" + dataHocKy.Rows[i]["MaHocKy"]);
            }

            DataTable dataNamHoc = data.ExcuteQuery("SELECT * FROM dbo.NAMHOC");
            for (int i = 0; i < dataNamHoc.Rows.Count; i++)
            {
                ddNamHoc.Items.Add(dataNamHoc.Rows[i]["TenNamHoc"] + "_" + dataNamHoc.Rows[i]["MaNamHoc"]);
            }

            DataTable dataLoai = data.ExcuteQuery("SELECT * FROM dbo.LOAIDIEM");
            for (int i = 0; i < dataLoai.Rows.Count; i++)
            {
                ddLoaiDiem.Items.Add(dataLoai.Rows[i]["TenLoai"] + "_" + dataLoai.Rows[i]["MaLoai"]);
            }
        }

        private bool checkDiem(string s)
        {
            try
            {
                Convert.ToDouble(s);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ddMonHoc.SelectedItem == null || this.ddHocKy.SelectedItem == null || this.ddNamHoc.SelectedItem == null || this.ddLop.SelectedItem == null || this.ddLoaiDiem.SelectedItem == null | this.txbDiem.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkDiem(this.txbDiem.Text))
            {
                MessageBox.Show("Điểm phải là số", "Thông Báo");
            }
            else
            {
                string monHoc = ddMonHoc.SelectedItem.ToString().Split('_')[1];
                string hocKy = ddHocKy.SelectedItem.ToString().Split('_')[1];
                string namHoc = ddNamHoc.SelectedItem.ToString().Split('_')[1];
                string lop = ddLop.SelectedItem.ToString().Split('_')[1];
                string loai = ddLoaiDiem.SelectedItem.ToString().Split('_')[1];
                string diem = this.txbDiem.Text;

                string query = "UPDATE dbo.DIEM SET MaMonHoc = '" + monHoc + "',MaHocKy = '" + hocKy + "',MaNamHoc = '" + namHoc + "',MaLop = '" + lop + "',MaLoai = '" + loai + "',Diem = " + diem + " WHERE STT = " + stt + "";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Sửa Thành Công", "Thông báo");
                this.Close();
            }
        }
    }
}
