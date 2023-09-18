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
    public partial class fMonHoc : Form
    {
        DataProvider data = new DataProvider();

        public fMonHoc()
        {
            InitializeComponent();
            loadMonHoc();
        }

        private void loadMonHoc()
        {
            dataMonHoc.DataSource = data.ExcuteQuery("SELECT * FROM dbo.MONHOC");
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fMonHoc_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaMonHoc.DataBindings.Add(new Binding("Text", dataMonHoc.DataSource, "MaMonHoc"));
            this.labelTenMonHoc.DataBindings.Add(new Binding("Text", dataMonHoc.DataSource, "TenMonHoc"));
            this.labelSoTiet.DataBindings.Add(new Binding("Text", dataMonHoc.DataSource, "SoTiet"));
            this.labelHeSo.DataBindings.Add(new Binding("Text", dataMonHoc.DataSource, "HeSo"));
        }

        private void clearBindings()
        {
            this.labelMaMonHoc.DataBindings.Clear();
            this.labelTenMonHoc.DataBindings.Clear();
            this.labelSoTiet.DataBindings.Clear();
            this.labelHeSo.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadMonHoc();
            }
            else
            {
                string query = "SELECT * FROM dbo.MONHOC WHERE MaMonHoc = '" + this.txbSeach.Text + "' OR TenMonHoc = N'" + this.txbSeach.Text + "'";
                dataMonHoc.DataSource = data.ExcuteQuery(query);
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemMonHoc().ShowDialog();
            loadMonHoc();
            addBindings();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string maGV = data.ExcuteQuery("SELECT * FROM dbo.GIAOVIEN WHERE MaMonHoc = '" + this.labelMaMonHoc.Text + "'").Rows[0]["MaGiaoVien"].ToString();
                clearBindings();
                data.ExcuteNoQuery("DELETE dbo.LOP WHERE MaGiaoVien = '" + maGV + "'");
                data.ExcuteNoQuery("DELETE dbo.PHANCONG WHERE MaMonHoc = '" + this.labelMaMonHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.GIAOVIEN WHERE MaMonHoc = '" + this.labelMaMonHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.KQ_CA_NAM_MON_HOC WHERE MaMonHoc = '" + this.labelMaMonHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.DIEM WHERE MaMonHoc = '" + this.labelMaMonHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.KQ_HOC_KY_MON_HOC WHERE MaMonHoc = '" + this.labelMaMonHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.MONHOC WHERE MaMonHoc = '" + this.labelMaMonHoc.Text + "'");
                loadMonHoc();
                addBindings();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaMonHoc(this.labelMaMonHoc.Text).ShowDialog();
            loadMonHoc();
            addBindings();
        }
    }
}
