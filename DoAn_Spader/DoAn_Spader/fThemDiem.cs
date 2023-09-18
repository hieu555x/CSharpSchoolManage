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
    public partial class fThemDiem : Form
    {
        DataProvider data = new DataProvider();

        public fThemDiem()
        {
            InitializeComponent();
        }

        private void fThemDiem_Load(object sender, EventArgs e)
        {
            DataTable dataHocSinh = data.ExcuteQuery("SELECT * FROM dbo.HOCSINH");
            for(int i = 0; i < dataHocSinh.Rows.Count; i++)
            {
                ddHocSinh.Items.Add(dataHocSinh.Rows[i]["HoTen"] + "_" + dataHocSinh.Rows[i]["MaHocSinh"]);
            }

            DataTable dataMonHoc = data.ExcuteQuery("SELECT * FROM dbo.MONHOC");
            for(int i = 0; i < dataMonHoc.Rows.Count; i++)
            {
                ddMonHoc.Items.Add(dataMonHoc.Rows[i]["TenMonHoc"] + "_" + dataMonHoc.Rows[i]["MaMonHoc"]);
            }

            DataTable dataHocKy = data.ExcuteQuery("SELECT * FROM dbo.HOCKY");
            for(int i = 0; i < dataHocKy.Rows.Count; i++)
            {
                ddHocKy.Items.Add(dataHocKy.Rows[i]["TenHocKy"] + "_" + dataHocKy.Rows[i]["MaHocKy"]);
            }

            DataTable dataNamHoc = data.ExcuteQuery("SELECT * FROM dbo.NAMHOC");
            for (int i = 0; i < dataNamHoc.Rows.Count; i++) 
            {
                ddNamHoc.Items.Add(dataNamHoc.Rows[i]["TenNamHoc"] + "_" + dataNamHoc.Rows[i]["MaNamHoc"]);
            }

            DataTable dataLop = data.ExcuteQuery("SELECT * FROM dbo.LOP");
            for(int i = 0; i < dataLop.Rows.Count; i++)
            {
                ddLop.Items.Add(dataLop.Rows[i]["TenLop"] + "_" + dataLop.Rows[i]["MaLop"]);
            }

            DataTable dataLoai = data.ExcuteQuery("SELECT * FROM dbo.LOAIDIEM");
            for(int i = 0; i < dataLoai.Rows.Count; i++)
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
            catch(Exception ex)
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
            if (this.ddHocSinh.SelectedItem == null || this.ddMonHoc.SelectedItem == null || this.ddHocKy.SelectedItem == null || this.ddNamHoc.SelectedItem == null || this.ddLop.SelectedItem == null || this.ddLoaiDiem.SelectedItem == null | this.txbDiem.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkDiem(this.txbDiem.Text))
            {
                MessageBox.Show("Điểm phải là số", "Thông Báo");
            }
            else
            {
                string hoTen = ddHocSinh.SelectedItem.ToString().Split('_')[1];
                string monHoc = ddMonHoc.SelectedItem.ToString().Split('_')[1];
                string hocKy = ddHocKy.SelectedItem.ToString().Split('_')[1];
                string namHoc = ddNamHoc.SelectedItem.ToString().Split('_')[1];
                string lop = ddLop.SelectedItem.ToString().Split('_')[1];
                string loai = ddLoaiDiem.SelectedItem.ToString().Split('_')[1];
                string diem = this.txbDiem.Text;

                string query = "INSERT INTO dbo.DIEM VALUES  ( '" + hoTen + "' ,'" + monHoc + "' ,'" + hocKy + "' ,'" + namHoc + "' ,'" + lop + "' ,'" + loai + "' ," + diem + ")";
                data.ExcuteNoQuery(query);
                DialogResult dr = MessageBox.Show("Thêm mới thành công,bạn có muốn thêm nữa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
