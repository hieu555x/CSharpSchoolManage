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
    public partial class fThemLop : Form
    {
        public fThemLop()
        {
            InitializeComponent();
        }

        private void fThemLop_Load(object sender, EventArgs e)
        {
            DataTable dataKhoiLop = new DataProvider().ExcuteQuery("SELECT * FROM dbo.KHOILOP");
            for(int i = 0; i < dataKhoiLop.Rows.Count; i++)
            {
                dropdownKhoiLop.Items.Add(dataKhoiLop.Rows[i]["TenKhoiLop"] + "_" + dataKhoiLop.Rows[i]["MaKhoiLop"]);
            }

            DataTable dataGiaoVien = new DataProvider().ExcuteQuery("SELECT * FROM dbo.GIAOVIEN");
            for(int i = 0; i < dataGiaoVien.Rows.Count; i++)
            {
                dropdownGiaoVien.Items.Add(dataGiaoVien.Rows[i]["TenGiaoVien"] + "_" + dataGiaoVien.Rows[i]["MaGiaoVien"]);
            }

            DataTable dataNamHoc = new DataProvider().ExcuteQuery("SELECT * FROM dbo.NAMHOC");
            for(int i = 0; i < dataNamHoc.Rows.Count; i++)
            {
                dropdownNamHoc.Items.Add(dataNamHoc.Rows[i]["TenNamHoc"] + "_" + dataNamHoc.Rows[i]["MaNamHoc"]);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
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
            if (this.txbMaLop.Text == "" || this.txbTenLop.Text == "" || this.dropdownKhoiLop.SelectedItem.ToString() == "" || this.dropdownGiaoVien.SelectedItem.ToString() == "" || this.dropdownNamHoc.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkSiSo)
            {
                MessageBox.Show("Sỉ số phải là số", "Thông Báo");
            }
            else if (new DataProvider().ExcuteQuery("SELECT * FROM dbo.LOP WHERE MaLop = '" + this.txbMaLop.Text + "'").Rows.Count > 0) 
            {
                MessageBox.Show("Mã lớp đã tồn tại", "Thông Báo");
            }
            else
            {
                string maLop = this.txbMaLop.Text;
                string tenLop = this.txbTenLop.Text;
                string khoiLop = this.dropdownKhoiLop.SelectedItem.ToString().Split('_')[1];
                string namHoc = this.dropdownNamHoc.SelectedItem.ToString().Split('_')[1];
                string giaoVien = this.dropdownGiaoVien.SelectedItem.ToString().Split('_')[1];

                string query = "INSERT INTO dbo.LOP VALUES  ( '" + maLop + "' ,N'" + tenLop + "' ,'" + khoiLop + "' ,'" + namHoc + "' ," + this.txbSiSo.Text + " ,'" + giaoVien + "')";
                new DataProvider().ExcuteNoQuery(query);
                MessageBox.Show("Thêm lớp mới thành công", "Thông Báo");
                this.Close();
            }
        }
    }
}
