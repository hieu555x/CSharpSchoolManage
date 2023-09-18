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
    public partial class fTonGiao : Form
    {
        DataProvider data = new DataProvider();

        public fTonGiao()
        {
            InitializeComponent();
            loadTonGiao();
        }

        private void loadTonGiao()
        {
            dataTonGiao.DataSource = data.ExcuteQuery("SELECT * FROM dbo.TONGIAO");
        }

        private void fTonGiao_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaTonGiao.DataBindings.Add(new Binding("Text", dataTonGiao.DataSource, "MaTonGiao"));
            this.labelTenTonGiao.DataBindings.Add(new Binding("Text", dataTonGiao.DataSource, "TenTonGiao"));
        }
        
        private void clearBindings()
        {
            this.labelMaTonGiao.DataBindings.Clear();
            this.labelTenTonGiao.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadTonGiao();
            }
            else
            {
                dataTonGiao.DataSource = data.ExcuteQuery("SELECT * FROM dbo.TONGIAO WHERE MaTonGiao = '" + this.txbSeach.Text + "' OR TenTonGiao = '" + this.txbSeach.Text + "'");
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThemTonGiao_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemTonGiao().ShowDialog();
            loadTonGiao();
            addBindings();
        }

        private void btnXoaTonGiao_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(DialogResult.OK == dr)
            {
                clearBindings();
                data.ExcuteNoQuery("DELETE dbo.HOCSINH WHERE MaTonGiao = '" + this.labelMaTonGiao.Text + "'");
                data.ExcuteNoQuery("DELETE dbo.TONGIAO WHERE MaTonGiao = '" + this.labelMaTonGiao.Text + "'");
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadTonGiao();
                addBindings();
            }
        }

        private void btnSuaTonGiao_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaTonGiao(this.labelMaTonGiao.Text).ShowDialog();
            loadTonGiao();
            addBindings();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
