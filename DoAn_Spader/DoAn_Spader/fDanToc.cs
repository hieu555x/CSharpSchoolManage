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
    public partial class fDanToc : Form
    {
        public fDanToc()
        {
            InitializeComponent();
            loadDanToc();
        }

        private void loadDanToc()
        {
            dataDanToc.DataSource = new DataProvider().ExcuteQuery("SELECT * FROM dbo.DANTOC");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fDanToc_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaDanToc.DataBindings.Add("Text", dataDanToc.DataSource, "MaDanToc");
            this.labelTenDanToc.DataBindings.Add("Text", dataDanToc.DataSource, "TenDanToc");
        }

        private void clearBindings()
        {
            this.labelMaDanToc.DataBindings.Clear();
            this.labelTenDanToc.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadDanToc();
            }
            else
            {
                dataDanToc.DataSource = new DataProvider().ExcuteQuery("SELECT * FROM dbo.DANTOC WHERE MaDanToc = '" + this.txbSeach.Text + "' OR TenDanToc = N'" + this.txbSeach.Text + "'");
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThemDanToc_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemDanToc().ShowDialog();
            loadDanToc();
            addBindings();
        }

        private void btnXoaDanToc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                clearBindings();
                new DataProvider().ExcuteNoQuery("DELETE dbo.HOCSINH WHERE MaDanToc = '" + this.labelMaDanToc.Text + "'");
                new DataProvider().ExcuteNoQuery("DELETE dbo.DANTOC WHERE MaDanToc = '" + this.labelMaDanToc.Text + "'");
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadDanToc();
                addBindings();
            }
        }

        private void btnSuaDanToc_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaDanToc(this.labelMaDanToc.Text).ShowDialog();
            loadDanToc();
            addBindings();
        }
    }
}
