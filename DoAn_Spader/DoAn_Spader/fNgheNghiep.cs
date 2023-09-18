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
    public partial class fNgheNghiep : Form
    {
        DataProvider data = new DataProvider();

        public fNgheNghiep()
        {
            InitializeComponent();
            loadNgheNghiep();
        }

        private void loadNgheNghiep()
        {
            string query = "SELECT * FROM dbo.NGHENGHIEP";
            dataNgheNghiep.DataSource = data.ExcuteQuery(query);
        }

        private void fNgheNghiep_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaNgheNghiep.DataBindings.Add(new Binding("Text", dataNgheNghiep.DataSource, "MaNghe"));
            this.labelTenNgheNghiep.DataBindings.Add(new Binding("Text", dataNgheNghiep.DataSource, "TenNghe"));
        }

        private void clearBindings()
        {
            this.labelMaNgheNghiep.DataBindings.Clear();
            this.labelTenNgheNghiep.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadNgheNghiep();
            }
            else
            {
                string query = "SELECT * FROM dbo.NGHENGHIEP WHERE MaNghe = '" + this.txbSeach.Text + "' OR TenNghe = N'" + this.txbSeach.Text + "'";
                dataNgheNghiep.DataSource = data.ExcuteQuery(query);
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThemNgheNghiep_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemNgheNghiep().ShowDialog();
            loadNgheNghiep();
            addBindings();
        }

        private void btnXoaNgheNghiep_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == dr)
            {
                clearBindings();
                string query = "DELETE dbo.NGHENGHIEP WHERE MaNghe = '" + this.labelMaNgheNghiep.Text + "'";
                data.ExcuteNoQuery(query);
                loadNgheNghiep();
                addBindings();
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
        }

        private void btnSuaNgheNghiep_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaNgheNghiep(this.labelMaNgheNghiep.Text).ShowDialog();
            loadNgheNghiep();
            addBindings();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
