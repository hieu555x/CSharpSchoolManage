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
    public partial class fChuyenLop : Form
    {
        public fChuyenLop()
        {
            InitializeComponent();
        }

        private void fChuyenLop_Load(object sender, EventArgs e)
        {
            DataTable dataHocSinh = new DataProvider().ExcuteQuery("SELECT	* FROM dbo.HOCSINH HS,dbo.PHANLOP PL WHERE HS.MaHocSinh = PL.MaHocSinh");
            for(int i = 0; i < dataHocSinh.Rows.Count; i++)
            {
                ddHocSinh.Items.Add(dataHocSinh.Rows[i]["HoTen"] + "_" + dataHocSinh.Rows[i]["MaHocSinh"]);
            }
            
            DataTable dataLopHoc = new DataProvider().ExcuteQuery("SELECT * FROM dbo.LOP");
            for(int i = 0; i < dataLopHoc.Rows.Count; i++)
            {
                ddLopMoi.Items.Add(dataLopHoc.Rows[i]["TenLop"] + "_" + dataLopHoc.Rows[i]["MaLop"]);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkSiSo(string maLop)
        {
            string siSo = new DataProvider().ExcuteQuery("SELECT * FROM dbo.LOP WHERE MaLop = '" + maLop + "'").Rows[0]["SiSo"].ToString();
            int phanLop = new DataProvider().ExcuteQuery("SELECT * FROM dbo.PHANLOP WHERE MaLop = '" + maLop + "'").Rows.Count;
            return phanLop < Convert.ToInt32(siSo);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ddHocSinh.SelectedItem.ToString() == "" || this.ddLopMoi.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkSiSo(this.ddLopMoi.SelectedItem.ToString().Split('_')[1]))
            {
                MessageBox.Show("Lớp đã đủ thành viên", "Thông báo");
            }
            else
            {
                string maHocSinh = this.ddHocSinh.SelectedItem.ToString().Split('_')[1];
                string maLopMoi = this.ddLopMoi.SelectedItem.ToString().Split('_')[1];
                string namHocMoi = new DataProvider().ExcuteQuery("SELECT * FROM dbo.LOP WHERE MaLop = '" + maLopMoi + "'").Rows[0]["MaNamHoc"].ToString();
                string khoiLopMoi = new DataProvider().ExcuteQuery("SELECT * FROM dbo.LOP WHERE MaLop = '" + maLopMoi + "'").Rows[0]["MaKhoiLop"].ToString();
                //xóa học sinh ở lớp cũ
                new DataProvider().ExcuteNoQuery("DELETE dbo.PHANLOP WHERE MaHocSinh = '" + maHocSinh + "'");
                //thêm học sinh vào lớp mới
                new DataProvider().ExcuteNoQuery("INSERT INTO dbo.PHANLOP VALUES  ( '" + namHocMoi + "' ,'" + khoiLopMoi + "' ,'" + maLopMoi + "' ,'" + maHocSinh + "')");
                MessageBox.Show("Chuyển lớp thành công", "Thông báo");
            }
        }
    }
}
