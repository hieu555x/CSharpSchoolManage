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
    public partial class fHocKy : Form
    {
        DataProvider data = new DataProvider();

        public fHocKy()
        {
            InitializeComponent();
            loadHocKy();
        }

        private void loadHocKy()
        {
            string query = "SELECT* FROM dbo.HOCKY";
            dataHocKy.DataSource = data.ExcuteQuery(query);
        }

        private void fHocKy_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaHocKy.DataBindings.Add(new Binding("Text", dataHocKy.DataSource, "MaHocKy"));
            this.labelTenHocKy.DataBindings.Add(new Binding("Text", dataHocKy.DataSource, "TenHocKy"));
            this.labelHeSo.DataBindings.Add(new Binding("Text", dataHocKy.DataSource, "HeSo"));
        }

        private void clearBindings()
        {
            this.labelMaHocKy.DataBindings.Clear();
            this.labelTenHocKy.DataBindings.Clear();
            this.labelHeSo.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadHocKy();
            }
            else
            {
                string query = "SELECT* FROM dbo.HOCKY WHERE MaHocKy = '" + this.txbSeach.Text + "' OR TenHocKy = N'" + this.txbSeach.Text + "'";
                dataHocKy.DataSource = data.ExcuteQuery(query);
            }
            addBindings();
        }

        private void btnThemHocKy_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemHocKy().ShowDialog();
            loadHocKy();
            addBindings();
        }

        private void btnXoaHocKy_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dr)
            {
                clearBindings();
                data.ExcuteNoQuery("DELETE dbo.DIEM WHERE MaHocKy = '" + this.labelMaHocKy.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.KQ_HOC_KY_MON_HOC WHERE MaHocKy = '" + this.labelMaHocKy.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.KQ_HOC_KY_TONG_HOP WHERE MaHocKy = '" + this.labelMaHocKy.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.HOCKY WHERE MaHocKy = '" + this.labelMaHocKy.Text + "'");
                loadHocKy();
                addBindings();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }

        private void btnSuaHocKy_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaHocKy(this.labelMaHocKy.Text).ShowDialog();
            loadHocKy();
            addBindings();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
