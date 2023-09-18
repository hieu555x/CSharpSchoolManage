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
    public partial class fThemVaoLop : Form
    {
        public fThemVaoLop()
        {
            InitializeComponent();
        }

        private void fThemVaoLop_Load(object sender, EventArgs e)
        {
            DataTable dataLop = new DataProvider().ExcuteQuery("SELECT * FROM dbo.LOP");
            for(int i = 0; i < dataLop.Rows.Count; i++)
            {
                ddLop.Items.Add(dataLop.Rows[i]["TenLop"]+"_"+dataLop.Rows[i]["MaLop"]);
            }

            DataTable dataHocSinh = new DataProvider().ExcuteQuery("SELECT * FROM dbo.HOCSINH WHERE NOT EXISTS( SELECT MaHocSinh FROM dbo.PHANLOP WHERE dbo.HOCSINH.MaHocSinh = dbo.PHANLOP.MaHocSinh GROUP BY MaHocSinh )");
            for(int i = 0; i < dataHocSinh.Rows.Count; i++)
            {
                ddHocSinh.Items.Add(dataHocSinh.Rows[i]["HoTen"] + "_" + dataHocSinh.Rows[i]["MaHocSinh"]);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkSiSo(string maLop)
        {
            string siSo = new DataProvider().ExcuteQuery("SELECT * FROM dbo.LOP WHERE MaLop = '" + maLop + "'").Rows[0]["SiSo"].ToString();
            int phanLop = new DataProvider().ExcuteQuery("SELECT * FROM dbo.PHANLOP WHERE MaLop = '"+maLop+"'").Rows.Count;
            return phanLop < Convert.ToInt32(siSo);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (this.ddLop.SelectedItem.ToString() == "" || this.ddHocSinh.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkSiSo(this.ddLop.SelectedItem.ToString().Split('_')[1]))
            {
                MessageBox.Show("Lớp đã đủ thành viên", "Thông báo");
            }
            else
            {
                string maLop = this.ddLop.SelectedItem.ToString().Split('_')[1];
                string maHocSinh = this.ddHocSinh.SelectedItem.ToString().Split('_')[1];
                string maNam = new DataProvider().ExcuteQuery("SELECT * FROM dbo.LOP WHERE MaLop = '" + maLop + "'").Rows[0]["MaNamHoc"].ToString();
                string maKhoiLop = new DataProvider().ExcuteQuery("SELECT * FROM dbo.LOP WHERE MaLop = '" + maLop + "'").Rows[0]["MaKhoiLop"].ToString();

                string query = "INSERT INTO dbo.PHANLOP VALUES  ( '"+maNam+ "' ,'"+maKhoiLop+"' ,'"+maLop+"' ,'"+maHocSinh+"')";
                new DataProvider().ExcuteNoQuery(query);
                MessageBox.Show("Thêm học sinh vào lớp thành công", "Thông báo");
                ddHocSinh.Items.Clear();
                DataTable dataHocSinh = new DataProvider().ExcuteQuery("SELECT * FROM dbo.HOCSINH WHERE NOT EXISTS( SELECT MaHocSinh FROM dbo.PHANLOP WHERE dbo.HOCSINH.MaHocSinh = dbo.PHANLOP.MaHocSinh GROUP BY MaHocSinh )");
                for (int i = 0; i < dataHocSinh.Rows.Count; i++)
                {
                    ddHocSinh.Items.Add(dataHocSinh.Rows[i]["HoTen"] + "_" + dataHocSinh.Rows[i]["MaHocSinh"]);
                }
            }
        }
    }
}
