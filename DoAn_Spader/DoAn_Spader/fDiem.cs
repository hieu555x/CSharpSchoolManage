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
    public partial class fDiem : Form
    {
        DataProvider data = new DataProvider();

        public fDiem()
        {
            InitializeComponent();
            loadDiem();
        }

        private void loadDiem()
        {
            string query = "SELECT D.STT,HS.HoTen,MH.TenMonHoc,HK.TenHocKy,NH.TenNamHoc,L.TenLop,LD.TenLoai,D.Diem FROM dbo.DIEM D, dbo.HOCSINH HS,dbo.MONHOC MH,dbo.HOCKY HK,dbo.NAMHOC NH,LOP L,dbo.LOAIDIEM LD WHERE D.MaHocSinh = HS.MaHocSinh AND D.MaMonHoc = MH.MaMonHoc AND D.MaHocKy = HK.MaHocKy AND D.MaNamHoc = NH.MaNamHoc AND D.MaLop = L.MaLop AND D.MaLoai = LD.MaLoai";
            dataDiem.DataSource = data.ExcuteQuery(query);
        }

        private void fDiem_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelSoThuTu.DataBindings.Add(new Binding("Text", dataDiem.DataSource, "STT"));
            this.labelTenHS.DataBindings.Add(new Binding("Text", dataDiem.DataSource, "HoTen"));
            this.labelTenMonHoc.DataBindings.Add(new Binding("Text", dataDiem.DataSource, "TenMonHoc"));
            this.labelTenHocKy.DataBindings.Add(new Binding("Text", dataDiem.DataSource, "TenHocKy"));
            this.labelTenNamHoc.DataBindings.Add(new Binding("Text", dataDiem.DataSource, "TenNamHoc"));
            this.labelTenLop.DataBindings.Add(new Binding("Text", dataDiem.DataSource, "TenLop"));
            this.labelTenLoai.DataBindings.Add(new Binding("Text", dataDiem.DataSource, "TenLoai"));
            this.labelDiem.DataBindings.Add(new Binding("Text", dataDiem.DataSource, "Diem"));
        }

        private void clearBindings()
        {
            this.labelSoThuTu.DataBindings.Clear();
            this.labelTenHS.DataBindings.Clear();
            this.labelTenMonHoc.DataBindings.Clear();
            this.labelTenHocKy.DataBindings.Clear();
            this.labelTenNamHoc.DataBindings.Clear();
            this.labelTenLop.DataBindings.Clear();
            this.labelTenLoai.DataBindings.Clear();
            this.labelDiem.DataBindings.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadDiem();
            }
            else
            {
                string query = "SELECT D.STT,HS.HoTen,MH.TenMonHoc,HK.TenHocKy,NH.TenNamHoc,L.TenLop,LD.TenLoai,D.Diem FROM dbo.DIEM D, dbo.HOCSINH HS,dbo.MONHOC MH,dbo.HOCKY HK,dbo.NAMHOC NH,LOP L,dbo.LOAIDIEM LD WHERE D.MaHocSinh = HS.MaHocSinh AND D.MaMonHoc = MH.MaMonHoc AND D.MaHocKy = HK.MaHocKy AND D.MaNamHoc = NH.MaNamHoc AND D.MaLop = L.MaLop AND D.MaLoai = LD.MaLoai AND HS.HoTen = '" + this.txbSeach.Text + "'";
                dataDiem.DataSource = data.ExcuteQuery(query);
            }
            addBindings();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemDiem().ShowDialog();
            loadDiem();
            addBindings();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                clearBindings();
                string query = "DELETE dbo.DIEM WHERE STT = '" + this.labelSoThuTu.Text + "'";
                data.ExcuteNoQuery(query);

                loadDiem();
                addBindings();
                MessageBox.Show("Xóa thành công");
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaDiem(this.labelSoThuTu.Text,this.labelTenHS.Text).ShowDialog();
            loadDiem();
            addBindings();
        }
    }
}
