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
    public partial class fGiaoVien : Form
    {
        DataProvider data = new DataProvider();

        public fGiaoVien()
        {
            InitializeComponent();
            loadGiaoVien();
        }

        private void loadGiaoVien()
        {
            string query = "SELECT gv.MaGiaoVien,gv.TenGiaoVien,gv.DiaChi,gv.DienThoai,mh.TenMonHoc FROM dbo.GIAOVIEN gv,dbo.MONHOC mh WHERE mh.MaMonHoc = gv.MaMonHoc";
            dataGiaoVien.DataSource = data.ExcuteQuery(query);
        }

        private void fGiaoVien_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaGV.DataBindings.Add(new Binding("Text", dataGiaoVien.DataSource, "MaGiaoVien"));
            this.labelTenGiaoVien.DataBindings.Add(new Binding("Text", dataGiaoVien.DataSource, "TenGiaoVien"));
            this.labelDiaChi.DataBindings.Add(new Binding("Text", dataGiaoVien.DataSource, "DiaChi"));
            this.labelDienThoai.DataBindings.Add(new Binding("Text", dataGiaoVien.DataSource, "DienThoai"));
            this.labelMonHoc.DataBindings.Add(new Binding("Text", dataGiaoVien.DataSource, "TenMonHoc"));
        }

        private void clearBindings()
        {
            this.labelMaGV.DataBindings.Clear();
            this.labelTenGiaoVien.DataBindings.Clear();
            this.labelDiaChi.DataBindings.Clear();
            this.labelDienThoai.DataBindings.Clear();
            this.labelMonHoc.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadGiaoVien();
            }
            else
            {
                string query = "SELECT gv.MaGiaoVien,gv.TenGiaoVien,gv.DiaChi,gv.DienThoai,mh.TenMonHoc FROM dbo.GIAOVIEN gv,dbo.MONHOC mh WHERE mh.MaMonHoc = gv.MaMonHoc AND gv.TenGiaoVien = N'" + this.txbSeach.Text + "'";
                dataGiaoVien.DataSource = data.ExcuteQuery(query);
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemGiaoVien().ShowDialog();
            loadGiaoVien();
            addBindings();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            clearBindings();
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                string maLop = data.ExcuteQuery("SELECT * FROM dbo.LOP WHERE MaGiaoVien = '" + this.labelMaGV.Text + "'").Rows[0]["MaLop"].ToString();
                string query2 = "DELETE dbo.KQ_CA_NAM_MON_HOC WHERE MaLop = '" + maLop + "'";
                string query3 = "DELETE dbo.KQ_CA_NAM_TONG_HOP WHERE MaLop = '" + maLop + "'";
                string query4 = "DELETE dbo.KQ_HOC_KY_MON_HOC WHERE MaLop = '" + maLop + "'";
                string query5 = "DELETE dbo.KQ_HOC_KY_TONG_HOP WHERE MaLop = '" + maLop + "'";
                string query6 = "DELETE dbo.PHANCONG WHERE MaLop = '" + maLop + "'";
                string query7 = "DELETE dbo.PHANLOP WHERE MaLop = '" + maLop + "'";
                string query8 = "DELETE dbo.DIEM WHERE MaLop = '" + maLop + "'";

                new DataProvider().ExcuteNoQuery(query2);
                new DataProvider().ExcuteNoQuery(query3);
                new DataProvider().ExcuteNoQuery(query4);
                new DataProvider().ExcuteNoQuery(query5);
                new DataProvider().ExcuteNoQuery(query6);
                new DataProvider().ExcuteNoQuery(query7);
                new DataProvider().ExcuteNoQuery(query8);

                data.ExcuteNoQuery("DELETE dbo.LOP WHERE MaGiaoVien = '" + this.labelMaGV.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.PHANCONG WHERE MaGiaoVien = '" + this.labelMaGV.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.GIAOVIEN WHERE MaGiaoVien = '" + this.labelMaGV.Text + "'");
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            loadGiaoVien();
            addBindings();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaGiaoVien(this.labelMaGV.Text).ShowDialog();
            loadGiaoVien();
            addBindings();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
