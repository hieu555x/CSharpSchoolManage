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
    public partial class fHangKiem : Form
    {
        public fHangKiem()
        {
            InitializeComponent();
            loadHangKiem();
        }

        private void loadHangKiem()
        {
            dataHangKiem.DataSource = new DataProvider().ExcuteQuery("SELECT * FROM dbo.HANHKIEM");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fHangKiem_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaHangKiem.DataBindings.Add(new Binding("Text", dataHangKiem.DataSource, "MaHanhKiem"));
            this.labelTenHangKiem.DataBindings.Add(new Binding("Text", dataHangKiem.DataSource, "TenHanhKiem"));
        }
        
        private void clearBindings()
        {
            this.labelMaHangKiem.DataBindings.Clear();
            this.labelTenHangKiem.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadHangKiem();
            }
            else
            {
                dataHangKiem.DataSource = new DataProvider().ExcuteQuery("SELECT * FROM dbo.HANHKIEM WHERE MaHanhKiem = '" + this.txbSeach.Text + "' OR TenHanhKiem = '" + this.txbSeach.Text + "'");
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThemHangKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemHangKiem().ShowDialog();
            loadHangKiem();
            addBindings();
        }

        private void btnXoaHangKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                new DataProvider().ExcuteNoQuery("DELETE dbo.KQ_HOC_KY_TONG_HOP WHERE MaHanhKiem = '" + this.labelMaHangKiem.Text + "'");
                new DataProvider().ExcuteNoQuery("DELETE dbo.KQ_CA_NAM_TONG_HOP WHERE MaHanhKiem = '" + this.labelMaHangKiem.Text + "'");
                new DataProvider().ExcuteNoQuery("DELETE dbo.HANHKIEM WHERE MaHanhKiem = '" + this.labelMaHangKiem.Text + "'");
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            loadHangKiem();
            addBindings();
        }

        private void btnSuaHangKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaHangKiem(this.labelMaHangKiem.Text).ShowDialog();
            loadHangKiem();
            addBindings();
        }
    }
}
