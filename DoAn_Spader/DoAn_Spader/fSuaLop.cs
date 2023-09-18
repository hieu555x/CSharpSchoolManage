using DoAn_Spader.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Spader
{
    public partial class fSuaLop : Form
    {
        private string MaLop = "";
        public fSuaLop(string s)
        {
            InitializeComponent();
            MaLop = s;
            this.txbMaLop.Text = MaLop;
        }

        private void fSuaLop_Load(object sender, EventArgs e)
        {
            DataTable dataKhoiLop = new DataProvider().ExcuteQuery("SELECT * FROM dbo.KHOILOP");
            for (int i = 0; i < dataKhoiLop.Rows.Count; i++)
            {
                dropdownKhoiLop.Items.Add(dataKhoiLop.Rows[i]["TenKhoiLop"] + "_" + dataKhoiLop.Rows[i]["MaKhoiLop"]);
            }

            DataTable dataGiaoVien = new DataProvider().ExcuteQuery("SELECT * FROM dbo.GIAOVIEN");
            for (int i = 0; i < dataGiaoVien.Rows.Count; i++)
            {
                dropdownGiaoVien.Items.Add(dataGiaoVien.Rows[i]["TenGiaoVien"] + "_" + dataGiaoVien.Rows[i]["MaGiaoVien"]);
            }

            DataTable dataNamHoc = new DataProvider().ExcuteQuery("SELECT * FROM dbo.NAMHOC");
            for (int i = 0; i < dataNamHoc.Rows.Count; i++)
            {
                dropdownNamHoc.Items.Add(dataNamHoc.Rows[i]["TenNamHoc"] + "_" + dataNamHoc.Rows[i]["MaNamHoc"]);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool checkSiSo = true;
            try
            {
                Convert.ToInt32(this.txbSiSo.Text);
            }
            catch(Exception ex)
            {
                checkSiSo = false;
            }
            if (this.txbTenLop.Text == "" || this.txbSiSo.Text == "" || this.dropdownGiaoVien.SelectedItem.ToString() == "" || this.dropdownKhoiLop.SelectedItem.ToString() == "" || this.dropdownNamHoc.SelectedItem.ToString() == "") 
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkSiSo)
            {
                MessageBox.Show("Sỉ số phải là số", "Thông Báo");
            }
            else
            {
                string tenLop = this.txbTenLop.Text;
                string khoiLop = this.dropdownKhoiLop.SelectedItem.ToString().Split('_')[1];
                string namHoc = this.dropdownNamHoc.SelectedItem.ToString().Split('_')[1];
                string siSo = this.txbSiSo.Text;
                string giaoVien = this.dropdownGiaoVien.SelectedItem.ToString().Split('_')[1];
                string query = "UPDATE dbo.LOP SET TenLop = '" + tenLop + "',MaKhoiLop = '" + khoiLop + "',MaNamHoc = '" + namHoc + "',SiSo = " + siSo + ",MaGiaoVien = '" + giaoVien + "' WHERE MaLop = '" + MaLop + "'";
                new DataProvider().ExcuteNoQuery(query);
                MessageBox.Show("Sửa Thành Công","Thông báo");
                this.Close();
            }
        }
    }
}
