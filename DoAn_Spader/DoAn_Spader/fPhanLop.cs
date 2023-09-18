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
    public partial class fPhanLop : Form
    {
        public fPhanLop()
        {
            InitializeComponent();
            loadPhanLop();
        }

        private void loadPhanLop()
        {
            dataPhanLop.DataSource = new DataProvider().ExcuteQuery("SELECT L.TenLop,KL.TenKhoiLop,NH.TenNamHoc,COUNT(PL.MaHocSinh) AS [DangCo] FROM dbo.PHANLOP PL,dbo.LOP L,dbo.KHOILOP KL,dbo.NAMHOC NH WHERE PL.MaLop = L.MaLop AND PL.MaKhoiLop = KL.MaKhoiLop AND PL.MaNamHoc = NH.MaNamHoc GROUP BY L.TenLop,KL.TenKhoiLop,NH.TenNamHoc");
        }

        private void fPhanLop_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelTenLop.DataBindings.Add(new Binding("Text", dataPhanLop.DataSource, "TenLop"));
            this.labelTenKhoiLop.DataBindings.Add(new Binding("Text", dataPhanLop.DataSource, "TenKhoiLop"));
            this.labelNamHoc.DataBindings.Add(new Binding("Text", dataPhanLop.DataSource, "TenNamHoc"));
        }

        private void clearBindings()
        {
            this.labelTenLop.DataBindings.Clear();
            this.labelTenKhoiLop.DataBindings.Clear();
            this.labelNamHoc.DataBindings.Clear();
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
                loadPhanLop();
            }
            else
            {
                dataPhanLop.DataSource = new DataProvider().ExcuteQuery("SELECT L.TenLop,KL.TenKhoiLop,NH.TenNamHoc FROM dbo.PHANLOP PL,dbo.LOP L,dbo.KHOILOP KL,dbo.NAMHOC NH WHERE PL.MaLop = L.MaLop AND PL.MaKhoiLop = KL.MaKhoiLop AND PL.MaNamHoc = NH.MaNamHoc AND L.TenLop = '" + this.txbSeach.Text + "' GROUP BY L.TenLop,KL.TenKhoiLop,NH.TenNamHoc");
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemVaoLop().ShowDialog();
            loadPhanLop();
            addBindings();
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fChuyenLop().ShowDialog();
            loadPhanLop();
            addBindings();
        }
    }
}
