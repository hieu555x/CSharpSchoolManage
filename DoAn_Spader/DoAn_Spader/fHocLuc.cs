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
    public partial class fHocLuc : Form
    {
        public fHocLuc()
        {
            InitializeComponent();
            loadHocLuc();
        }

        private void loadHocLuc()
        {
            dataHocLuc.DataSource = new DataProvider().ExcuteQuery("SELECT * FROM dbo.HOCLUC");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fHocLuc_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaHocLuc.DataBindings.Add(new Binding("Text", dataHocLuc.DataSource, "MaHocLuc"));
            this.labelTenHocLuc.DataBindings.Add(new Binding("Text", dataHocLuc.DataSource, "TenHocLuc"));
            this.labelDiemCanTren.DataBindings.Add(new Binding("Text", dataHocLuc.DataSource, "DiemCanTren"));
            this.labelDiemCanDuoi.DataBindings.Add(new Binding("Text", dataHocLuc.DataSource, "DiemCanDuoi"));
            this.labelKhongChe.DataBindings.Add(new Binding("Text", dataHocLuc.DataSource, "DiemKhongChe"));
        }

        private void clearBindings()
        {
            this.labelMaHocLuc.DataBindings.Clear();
            this.labelTenHocLuc.DataBindings.Clear();
            this.labelDiemCanDuoi.DataBindings.Clear();
            this.labelDiemCanTren.DataBindings.Clear();
            this.labelKhongChe.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadHocLuc();
            }
            else
            {
                dataHocLuc.DataSource = new DataProvider().ExcuteQuery("SELECT * FROM dbo.HOCLUC WHERE MaHocLuc = '" + this.txbSeach.Text + "' OR TenHocLuc = '" + this.txbSeach.Text + "'");
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThemHocLuc_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fThemHocLuc().ShowDialog();
            loadHocLuc();
            addBindings();
        }

        private void btnXoaHocLuc_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hay không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                clearBindings();
                try
                {
                    new DataProvider().ExcuteNoQuery("DELETE dbo.KQ_HOC_KY_TONG_HOP WHERE MaHocLuc = '" + this.labelMaHocLuc.Text + "'");
                    new DataProvider().ExcuteNoQuery("DELETE dbo.KQ_CA_NAM_TONG_HOP WHERE MaHocLuc = '" + this.labelMaHocLuc.Text + "'");
                    new DataProvider().ExcuteNoQuery("DELETE dbo.HOCLUC WHERE MaHocLuc = '" + this.labelMaHocLuc.Text + "'");                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa lỗi do có ràng buộc vui lòng kiểm tra lại", "Thông báo");
                }
                loadHocLuc();
                addBindings();
            }
        }

        private void btnSuaHocLuc_Click(object sender, EventArgs e)
        {
            clearBindings();
            new fSuaHocLuc(this.labelMaHocLuc.Text).ShowDialog();
            loadHocLuc();
            addBindings();
        }
    }
}
