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
    public partial class fPhanCong : Form
    {
        DataProvider data = new DataProvider();

        public fPhanCong()
        {
            InitializeComponent();
            loadPhanCong();
        }

        private void loadPhanCong()
        {
            string query = "SELECT NH.TenNamHoc,L.TenLop,MH.TenMonHoc,GV.TenGiaoVien FROM dbo.PHANCONG PC,dbo.NAMHOC NH,dbo.LOP L,dbo.MONHOC MH,dbo.GIAOVIEN GV WHERE PC.MaNamHoc = NH.MaNamHoc AND PC.MaLop = L.MaLop AND PC.MaMonHoc = MH.MaMonHoc AND PC.MaGiaoVien = GV.MaGiaoVien";
            dataPhanCong.DataSource = data.ExcuteQuery(query);
        }

        private void fPhanCong_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelNamHoc.DataBindings.Add(new Binding("Text", dataPhanCong.DataSource, "TenNamHoc"));
            this.labelLop.DataBindings.Add(new Binding("Text", dataPhanCong.DataSource, "TenLop"));
            this.labelMonHoc.DataBindings.Add(new Binding("Text", dataPhanCong.DataSource, "TenMonHoc"));
            this.labelGiaoVien.DataBindings.Add(new Binding("Text", dataPhanCong.DataSource, "TenGiaoVien"));
        }

        private void clearBindings()
        {
            this.labelNamHoc.DataBindings.Clear();
            this.labelLop.DataBindings.Clear();
            this.labelMonHoc.DataBindings.Clear();
            this.labelGiaoVien.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadPhanCong();
            }
            else
            {
                string query = "SELECT NH.TenNamHoc,L.TenLop,MH.TenMonHoc,GV.TenGiaoVien FROM dbo.PHANCONG PC,dbo.NAMHOC NH,dbo.LOP L,dbo.MONHOC MH,dbo.GIAOVIEN GV WHERE PC.MaNamHoc = NH.MaNamHoc AND PC.MaLop = L.MaLop AND PC.MaMonHoc = MH.MaMonHoc AND PC.MaGiaoVien = GV.MaGiaoVien AND GV.TenGiaoVien = N'" + this.txbSeach.Text + "'";
                dataPhanCong.DataSource = data.ExcuteQuery(query);
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemPhanCong().ShowDialog();
            loadPhanCong();
            addBindings();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            clearBindings();
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(DialogResult.OK == dr)
            {
                string maNamHoc = data.ExcuteQuery("SELECT NH.MaNamHoc,L.MaLop,MH.MaMonHoc,GV.MaGiaoVien FROM dbo.PHANCONG PC,dbo.NAMHOC NH,dbo.LOP L,dbo.MONHOC MH,dbo.GIAOVIEN GV WHERE PC.MaNamHoc = NH.MaNamHoc AND PC.MaLop = L.MaLop AND PC.MaMonHoc = MH.MaMonHoc AND PC.MaGiaoVien = GV.MaGiaoVien AND NH.TenNamHoc = N'" + this.labelNamHoc.Text + "' AND L.TenLop = N'" + this.labelLop.Text + "' AND MH.TenMonHoc = N'" + this.labelMonHoc.Text + "' AND GV.TenGiaoVien = N'" + this.labelGiaoVien.Text + "'").Rows[0]["MaNamHoc"].ToString();
                string maLop = data.ExcuteQuery("SELECT NH.MaNamHoc,L.MaLop,MH.MaMonHoc,GV.MaGiaoVien FROM dbo.PHANCONG PC,dbo.NAMHOC NH,dbo.LOP L,dbo.MONHOC MH,dbo.GIAOVIEN GV WHERE PC.MaNamHoc = NH.MaNamHoc AND PC.MaLop = L.MaLop AND PC.MaMonHoc = MH.MaMonHoc AND PC.MaGiaoVien = GV.MaGiaoVien AND NH.TenNamHoc = N'" + this.labelNamHoc.Text + "' AND L.TenLop = N'" + this.labelLop.Text + "' AND MH.TenMonHoc = N'" + this.labelMonHoc.Text + "' AND GV.TenGiaoVien = N'" + this.labelGiaoVien.Text + "'").Rows[0]["MaLop"].ToString();
                string maMonHoc = data.ExcuteQuery("SELECT NH.MaNamHoc,L.MaLop,MH.MaMonHoc,GV.MaGiaoVien FROM dbo.PHANCONG PC,dbo.NAMHOC NH,dbo.LOP L,dbo.MONHOC MH,dbo.GIAOVIEN GV WHERE PC.MaNamHoc = NH.MaNamHoc AND PC.MaLop = L.MaLop AND PC.MaMonHoc = MH.MaMonHoc AND PC.MaGiaoVien = GV.MaGiaoVien AND NH.TenNamHoc = N'" + this.labelNamHoc.Text + "' AND L.TenLop = N'" + this.labelLop.Text + "' AND MH.TenMonHoc = N'" + this.labelMonHoc.Text + "' AND GV.TenGiaoVien = N'" + this.labelGiaoVien.Text + "'").Rows[0]["MaMonHoc"].ToString();
                string maGiaoVien = data.ExcuteQuery("SELECT NH.MaNamHoc,L.MaLop,MH.MaMonHoc,GV.MaGiaoVien FROM dbo.PHANCONG PC,dbo.NAMHOC NH,dbo.LOP L,dbo.MONHOC MH,dbo.GIAOVIEN GV WHERE PC.MaNamHoc = NH.MaNamHoc AND PC.MaLop = L.MaLop AND PC.MaMonHoc = MH.MaMonHoc AND PC.MaGiaoVien = GV.MaGiaoVien AND NH.TenNamHoc = N'" + this.labelNamHoc.Text + "' AND L.TenLop = N'" + this.labelLop.Text + "' AND MH.TenMonHoc = N'" + this.labelMonHoc.Text + "' AND GV.TenGiaoVien = N'" + this.labelGiaoVien.Text + "'").Rows[0]["MaGiaoVien"].ToString();
                string query = "DELETE dbo.PHANCONG WHERE MaNamHoc = '"+maNamHoc+ "' AND MaLop = '" + maLop + "' AND MaMonHoc = '" + maMonHoc + "' AND MaGiaoVien = '" + maGiaoVien + "'";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Xoá thành công", "Thông báo");
            }
            loadPhanCong();
            addBindings();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
