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
    public partial class fLop : Form
    {

        private bool checkAdd = false;

        public fLop()
        {
            InitializeComponent();
            loadLop();
        }

        private void loadLop()
        {
            string query = "SELECT MaLop,TenLop,KL.TenKhoiLop,NH.TenNamHoc,SiSo,GV.TenGiaoVien FROM dbo.LOP L,dbo.KHOILOP KL,dbo.NAMHOC NH,dbo.GIAOVIEN GV WHERE L.MaKhoiLop = KL.MaKhoiLop AND L.MaNamHoc = NH.MaNamHoc AND L.MaGiaoVien = GV.MaGiaoVien";
            dataLopHoc.DataSource = new DataProvider().ExcuteQuery(query);
        }

        private void fLop_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaLop.DataBindings.Add(new Binding("Text", dataLopHoc.DataSource, "MaLop"));
            this.labelTenLop.DataBindings.Add(new Binding("Text", dataLopHoc.DataSource, "TenLop"));
            this.labelKhoiLop.DataBindings.Add(new Binding("Text", dataLopHoc.DataSource, "TenKhoiLop"));
            this.labelNamHoc.DataBindings.Add(new Binding("Text", dataLopHoc.DataSource, "TenNamHoc"));
            this.labelSiSo.DataBindings.Add(new Binding("Text", dataLopHoc.DataSource, "SiSo"));
            this.labelGVChuNhiem.DataBindings.Add(new Binding("Text", dataLopHoc.DataSource, "TenGiaoVien"));
        }

        private void clearBindings()
        {
            this.labelMaLop.DataBindings.Clear();
            this.labelTenLop.DataBindings.Clear();
            this.labelKhoiLop.DataBindings.Clear();
            this.labelNamHoc.DataBindings.Clear();
            this.labelSiSo.DataBindings.Clear();
            this.labelGVChuNhiem.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadLop();
            }
            else
            {
                string query = "SELECT MaLop,TenLop,KL.TenKhoiLop,NH.TenNamHoc,SiSo,GV.TenGiaoVien FROM dbo.LOP L,dbo.KHOILOP KL,dbo.NAMHOC NH,dbo.GIAOVIEN GV WHERE L.MaKhoiLop = KL.MaKhoiLop AND L.MaNamHoc = NH.MaNamHoc AND L.MaGiaoVien = GV.MaGiaoVien AND ( l.MaLop = '" + this.txbSeach.Text + "' OR l.TenLop = '" + this.txbSeach.Text + "')";
                dataLopHoc.DataSource = new DataProvider().ExcuteQuery(query);
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemLop().ShowDialog();
            loadLop();
            addBindings();
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                clearBindings();
                try
                {
                    string query1 = "DELETE dbo.LOP WHERE MaLop = '" + this.labelMaLop.Text + "'";
                    string query2 = "DELETE dbo.KQ_CA_NAM_MON_HOC WHERE MaLop = '" + this.labelMaLop.Text + "'";
                    string query3 = "DELETE dbo.KQ_CA_NAM_TONG_HOP WHERE MaLop = '" + this.labelMaLop.Text + "'";
                    string query4 = "DELETE dbo.KQ_HOC_KY_MON_HOC WHERE MaLop = '" + this.labelMaLop.Text + "'";
                    string query5 = "DELETE dbo.KQ_HOC_KY_TONG_HOP WHERE MaLop = '" + this.labelMaLop.Text + "'";
                    string query6 = "DELETE dbo.PHANCONG WHERE MaLop = '" + this.labelMaLop.Text + "'";
                    string query7 = "DELETE dbo.PHANLOP WHERE MaLop = '" + this.labelMaLop.Text + "'";
                    string query8 = "DELETE dbo.DIEM WHERE MaLop = '" + this.labelMaLop.Text + "'";

                    new DataProvider().ExcuteNoQuery(query2);
                    new DataProvider().ExcuteNoQuery(query3);
                    new DataProvider().ExcuteNoQuery(query4);
                    new DataProvider().ExcuteNoQuery(query5);
                    new DataProvider().ExcuteNoQuery(query6);
                    new DataProvider().ExcuteNoQuery(query7);
                    new DataProvider().ExcuteNoQuery(query8);
                    new DataProvider().ExcuteNoQuery(query1);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    loadLop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lỗi do có ràng buộc vui lòng kiểm tra lại", "Thông báo");
                }
		        loadLop();
                addBindings();
            }
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            new fSuaLop(this.labelMaLop.Text).ShowDialog();
            loadLop();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
