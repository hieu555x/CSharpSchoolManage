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
    public partial class fKetQua : Form
    {
        public fKetQua()
        {
            InitializeComponent();
            loadKetQua();
        }

        private void loadKetQua()
        {
            string query = "SELECT MaKetQua AS [Mã Kết Quả],TenKetQua AS [Tên Kết Quả] FROM dbo.KETQUA";
            dataKetQua.DataSource = new DataProvider().ExcuteQuery(query);
        }

        private void fKetQua_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaKetQua.DataBindings.Add(new Binding("Text", dataKetQua.DataSource, "Mã Kết Quả"));
            this.labelTenKetQua.DataBindings.Add(new Binding("Text", dataKetQua.DataSource, "Tên Kết Quả"));
        }

        private void clearBindings()
        {
            this.labelMaKetQua.DataBindings.Clear();
            this.labelTenKetQua.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadKetQua();
            }
            else
            {
                string query = "SELECT MaKetQua AS [Mã Kết Quả],TenKetQua AS [Tên Kết Quả] FROM dbo.KETQUA WHERE MaKetQua = '" + this.txbSeach.Text + "' OR TenKetQua = '" + this.txbSeach.Text + "'";
                dataKetQua.DataSource = new DataProvider().ExcuteQuery(query);
            }
            this.txbSeach.Text = "";
            addBindings();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemKetQua_Click(object sender, EventArgs e)
        {
            new fThemKetQua().ShowDialog();
            clearBindings();
            loadKetQua();
            addBindings();
        }

        private void btnXoaKetQua_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa kết quả này không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                clearBindings();
                string query = "DELETE dbo.KETQUA WHERE MaKetQua = '" + this.labelMaKetQua.Text + "'";
                try
                {
                    new DataProvider().ExcuteNoQuery("DELETE dbo.KQ_CA_NAM_TONG_HOP WHERE MaKetQua = '" + this.labelMaKetQua.Text + "'");
                    new DataProvider().ExcuteNoQuery(query);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ràng buộc, vui lòng kiểm tra lại", "Thông báo");
                }
                loadKetQua();
                addBindings();
            }
        }

        private void btnSuaKetQua_Click(object sender, EventArgs e)
        {
            new fSuaKetQua(this.labelMaKetQua.Text).ShowDialog();
            clearBindings();
            loadKetQua();
            addBindings();
        }
    }
}
