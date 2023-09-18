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
    public partial class fNamHoc : Form
    {
        DataProvider data = new DataProvider();

        public fNamHoc()
        {
            InitializeComponent();
            loadNamHoc();
        }

        private void loadNamHoc()
        {
            string query = "SELECT * FROM dbo.NAMHOC";
            dataNamHoc.DataSource = data.ExcuteQuery(query);
        }

        private void fNamHoc_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaNamHoc.DataBindings.Add(new Binding("Text", dataNamHoc.DataSource, "MaNamHoc"));
            this.labelTenNamHoc.DataBindings.Add(new Binding("Text", dataNamHoc.DataSource, "TenNamHoc"));
        }
        
        private void clearBindings()
        {
            this.labelMaNamHoc.DataBindings.Clear();
            this.labelTenNamHoc.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadNamHoc();
            }
            else
            {
                string query = "SELECT * FROM dbo.NAMHOC WHERE MaNamHoc = '" + this.txbSeach.Text + "' OR TenNamHoc = N'" + this.txbSeach.Text + "'";
                dataNamHoc.DataSource = data.ExcuteQuery(query);
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemNamHoc().ShowDialog();
            loadNamHoc();
            addBindings();
        }

        private void btnXoaNamHoc_Click(object sender, EventArgs e)
        {
            clearBindings();
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                data.ExcuteNoQuery("DELETE dbo.PHANLOP WHERE MaNamHoc = '" + this.labelMaNamHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.KQ_CA_NAM_MON_HOC WHERE MaNamHoc = '" + this.labelMaNamHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.KQ_CA_NAM_TONG_HOP WHERE MaNamHoc = '" + this.labelMaNamHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.KQ_HOC_KY_TONG_HOP WHERE MaNamHoc = '" + this.labelMaNamHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.KQ_HOC_KY_MON_HOC WHERE MaNamHoc = '" + this.labelMaNamHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.DIEM WHERE MaNamHoc = '" + this.labelMaNamHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.PHANCONG WHERE MaNamHoc = '" + this.labelMaNamHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.LOP WHERE MaNamHoc = '" + this.labelMaNamHoc.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.NAMHOC WHERE MaNamHoc = '" + this.labelMaNamHoc.Text + "'");
                MessageBox.Show("Xóa Thành Công");
            }
            loadNamHoc();
            addBindings();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaNamHoc(this.labelTenNamHoc.Text).ShowDialog();
            loadNamHoc();
            addBindings();
        }
    }
}
