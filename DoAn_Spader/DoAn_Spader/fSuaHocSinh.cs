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
    public partial class fSuaHocSinh : Form
    {
        public fSuaHocSinh(string s)
        {
            InitializeComponent();
            this.txbMaHocSinh.Text = s;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSuaHocSinh_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                ddNgaySinh.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                ddThangSinh.Items.Add(i);
            }

            for (int i = 1995; i <= DateTime.Now.Year; i++)
            {
                ddNamSinh.Items.Add(i);
            }

            DataTable dataDanToc = new DataProvider().ExcuteQuery("SELECT * FROM dbo.DANTOC");
            for (int i = 0; i < dataDanToc.Rows.Count; i++)
            {
                ddDanToc.Items.Add(dataDanToc.Rows[i]["TenDanToc"] + "_" + dataDanToc.Rows[i]["MaDanToc"]);
            }

            DataTable dataTonGiao = new DataProvider().ExcuteQuery("SELECT * FROM dbo.TONGIAO");
            for (int i = 0; i < dataTonGiao.Rows.Count; i++)
            {
                ddTonGiao.Items.Add(dataTonGiao.Rows[i]["TenTonGiao"] + "_" + dataTonGiao.Rows[i]["MaTonGiao"]);
            }

            DataTable dataNghe = new DataProvider().ExcuteQuery("SELECT * FROM dbo.NGHENGHIEP");
            for (int i = 0; i < dataNghe.Rows.Count; i++)
            {
                ddNgheCha.Items.Add(dataNghe.Rows[i]["TenNghe"] + "_" + dataNghe.Rows[i]["MaNghe"]);
                ddNgheMe.Items.Add(dataNghe.Rows[i]["TenNghe"] + "_" + dataNghe.Rows[i]["MaNghe"]);
            }
        }

        private bool checkDate(string day, string month, string year)
        {
            DateTime temp;
            return DateTime.TryParse(year + "-" + month + "-" + day, out temp);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.txbTenHocSinh.Text == "" || this.txbNoiSinh.Text == "" || this.txbTenCha.Text == "" || this.txbTenMe.Text == "" || this.ddNgaySinh.SelectedItem.ToString() == "" || this.ddThangSinh.SelectedItem.ToString() == "" || this.ddNamSinh.SelectedItem.ToString() == "" || this.ddDanToc.SelectedItem.ToString() == "" || this.ddTonGiao.SelectedItem.ToString() == "" || this.ddNgheCha.SelectedItem.ToString() == "" || this.ddNgheMe.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkDate(this.ddNamSinh.SelectedItem.ToString(), this.ddThangSinh.SelectedItem.ToString(), this.ddNgaySinh.SelectedItem.ToString()))
            {
                MessageBox.Show("Ngày tháng năm sinh không hợp lệ", "Thông Báo");
            }
            else
            {
                string gioiTinh = "Nam";
                if (this.ddGioiTinh.SelectedItem.ToString().Equals("Nam"))
                {
                    gioiTinh = "0";
                }
                else
                {
                    gioiTinh = "1";
                }
                string ngaySinh = this.ddNamSinh.SelectedItem.ToString() + "-" + this.ddThangSinh.SelectedItem.ToString() + "-" + this.ddNgaySinh.SelectedItem.ToString();
                string danToc = this.ddDanToc.SelectedItem.ToString().Split('_')[1];
                string tonGiao = this.ddTonGiao.SelectedItem.ToString().Split('_')[1];
                string ngheCha = this.ddNgheCha.SelectedItem.ToString().Split('_')[1];
                string ngheMe = this.ddNgheMe.SelectedItem.ToString().Split('_')[1];

                string query = "UPDATE dbo.HOCSINH SET HoTen = N'" + this.txbTenHocSinh.Text + "',GioiTinh = " + gioiTinh + ",NgaySinh = '" + ngaySinh + "',NoiSinh = N'" + this.txbNoiSinh.Text + "',MaDanToc = '" + danToc + "',MaTonGiao = '" + tonGiao + "',HoTenCha = N'" + this.txbTenCha.Text + "',MaNNghiepCha = '" + ngheCha + "',HoTenMe = N'" + this.txbTenMe.Text + "',MaNNghiepMe = '" + ngheMe + "' WHERE MaHocSinh = '" + this.txbMaHocSinh.Text + "'";
                new DataProvider().ExcuteNoQuery(query);
                MessageBox.Show("Sửa học sinh thành công", "Thông Báo");
                this.Close();
            }
        }
    }
}
