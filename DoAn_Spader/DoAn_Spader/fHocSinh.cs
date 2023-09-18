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
    public partial class fHocSinh : Form
    {
        public fHocSinh()
        {
            InitializeComponent();
            loadHocSinh();
        }

        private void loadHocSinh()
        {
            dataHocSinh.DataSource = new DataProvider().ExcuteQuery("SELECT HS.MaHocSinh,HS.HoTen,HS.GioiTinh,HS.NgaySinh,HS.NoiSinh,DT.TenDanToc,TG.TenTonGiao,HS.HoTenCha,C.TenNghe AS [NgheCha],HS.HoTenMe,M.TenNghe AS [NgheMe] FROM dbo.HOCSINH HS,dbo.DANTOC DT,dbo.TONGIAO TG,(SELECT HS.MaHocSinh,NN.TenNghe FROM dbo.HOCSINH HS,dbo.NGHENGHIEP NN WHERE HS.MaNNghiepCha = NN.MaNghe) C,(SELECT HS.MaHocSinh,NN.TenNghe FROM dbo.HOCSINH HS,dbo.NGHENGHIEP NN WHERE HS.MaNNghiepMe = NN.MaNghe) M WHERE HS.MaDanToc = DT.MaDanToc AND HS.MaTonGiao = TG.MaTonGiao AND HS.MaHocSinh = C.MaHocSinh AND HS.MaHocSinh = M.MaHocSinh");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fHocSinh_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaHocSinh.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "MaHocSinh"));
            this.labelTenHocSinh.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "HoTen"));
            this.labelGioiTinh.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "GioiTinh"));
            this.labelNgaySinh.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "NgaySinh"));
            this.labelNoiSinh.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "NoiSinh"));
            this.labelDanToc.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "TenDanToc"));
            this.labelTonGiao.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "TenTonGiao"));
            this.labelCha.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "HoTenCha"));
            this.labelNgheCha.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "NgheCha"));
            this.labelMe.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "HoTenMe"));
            this.labelNgheMe.DataBindings.Add(new Binding("Text", dataHocSinh.DataSource, "NgheMe"));

            if (this.labelGioiTinh.Text.Equals("False"))
            {
                this.labelGioiTinh.Text = "Nam";
            }
            else
            {
                this.labelGioiTinh.Text = "Nữ";
            }
        }

        private void dataHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (this.labelGioiTinh.Text.Equals("False"))
            {
                this.labelGioiTinh.Text = "Nam";
            }
            else
            {
                this.labelGioiTinh.Text = "Nữ";
            }
        }

        private void clearBindings()
        {
            this.labelMaHocSinh.DataBindings.Clear();
            this.labelTenHocSinh.DataBindings.Clear();
            this.labelGioiTinh.DataBindings.Clear();
            this.labelNgaySinh.DataBindings.Clear();
            this.labelNoiSinh.DataBindings.Clear();
            this.labelDanToc.DataBindings.Clear();
            this.labelTonGiao.DataBindings.Clear();
            this.labelCha.DataBindings.Clear();
            this.labelNgheCha.DataBindings.Clear();
            this.labelMe.DataBindings.Clear();
            this.labelNgheMe.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadHocSinh();
            }
            else
            {
                dataHocSinh.DataSource = new DataProvider().ExcuteQuery("SELECT HS.MaHocSinh,HS.HoTen,HS.GioiTinh,HS.NgaySinh,HS.NoiSinh,DT.TenDanToc,TG.TenTonGiao,HS.HoTenCha,C.TenNghe AS [NgheCha],HS.HoTenMe,M.TenNghe AS [NgheMe] FROM dbo.HOCSINH HS,dbo.DANTOC DT,dbo.TONGIAO TG,(SELECT HS.MaHocSinh,NN.TenNghe FROM dbo.HOCSINH HS,dbo.NGHENGHIEP NN WHERE HS.MaNNghiepCha = NN.MaNghe) C,(SELECT HS.MaHocSinh,NN.TenNghe FROM dbo.HOCSINH HS,dbo.NGHENGHIEP NN WHERE HS.MaNNghiepMe = NN.MaNghe) M WHERE HS.MaDanToc = DT.MaDanToc AND HS.MaTonGiao = TG.MaTonGiao AND HS.MaHocSinh = C.MaHocSinh AND HS.MaHocSinh = M.MaHocSinh AND (HS.MaHocSinh = '" + this.txbSeach.Text + "' OR HS.HoTen = '" + this.txbSeach.Text + "')");
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThemHocSinh_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemHocSinh().ShowDialog();
            loadHocSinh();
            addBindings();
        }

        private void btnXoaHocSinh_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                clearBindings();
                try
                {
                    DataProvider cmd = new DataProvider();
                    cmd.ExcuteNoQuery("DELETE dbo.PHANLOP WHERE MaHocSinh = '" + this.labelMaHocSinh.Text + "'");
                    cmd.ExcuteNoQuery("DELETE dbo.KQ_CA_NAM_MON_HOC WHERE MaHocSinh = '" + this.labelMaHocSinh.Text + "'");
                    cmd.ExcuteNoQuery("DELETE dbo.KQ_CA_NAM_TONG_HOP WHERE MaHocSinh = '" + this.labelMaHocSinh.Text + "'");
                    cmd.ExcuteNoQuery("DELETE dbo.KQ_HOC_KY_TONG_HOP WHERE MaHocSinh = '" + this.labelMaHocSinh.Text + "'");
                    cmd.ExcuteNoQuery("DELETE dbo.KQ_HOC_KY_MON_HOC WHERE MaHocSinh = '" + this.labelMaHocSinh.Text + "'");
                    cmd.ExcuteNoQuery("DELETE dbo.DIEM WHERE MaHocSinh = '" + this.labelMaHocSinh.Text + "'");
                    cmd.ExcuteNoQuery("DELETE dbo.HOCSINH WHERE MaHocSinh = '" + this.labelMaHocSinh.Text + "'");
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi vui lòng thử lại sau", "Thông báo");
                }
                loadHocSinh();
                addBindings();
            }
        }

        private void btnSuaHocSinh_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaHocSinh(this.labelMaHocSinh.Text).ShowDialog();
            loadHocSinh();
            addBindings();
        }
    }
}
