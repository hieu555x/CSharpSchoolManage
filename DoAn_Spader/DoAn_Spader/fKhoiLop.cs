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
    public partial class fKhoiLop : Form
    {
        public fKhoiLop()
        {
            InitializeComponent();
            loadKhoiLop();
        }

        private void loadKhoiLop()
        {
            string query = "SELECT KL.MaKhoiLop AS [Mã Khối Lớp],KL.TenKhoiLop AS [Tên Khối Lớp], [Số Lượng] = SUM(L.SiSo) FROM dbo.LOP L,dbo.KHOILOP KL WHERE KL.MaKhoiLop = L.MaKhoiLop GROUP BY KL.MaKhoiLop,KL.TenKhoiLop";
            dataKhoiLop.DataSource = new DataProvider().ExcuteQuery(query);
        }

        private void fKhoiLop_Load(object sender, EventArgs e)
        {
            addBindings();
        }

        private void addBindings()
        {
            this.labelMaKhoiLop.DataBindings.Add(new Binding("Text", dataKhoiLop.DataSource, "Mã Khối Lớp"));
            this.labelTenKhoiLop.DataBindings.Add(new Binding("Text", dataKhoiLop.DataSource, "Tên Khối Lớp"));
            this.labelSoLuong.DataBindings.Add(new Binding("Text", dataKhoiLop.DataSource, "Số Lượng"));
        }

        private void clearBindings()
        {
            this.labelMaKhoiLop.DataBindings.Clear();
            this.labelTenKhoiLop.DataBindings.Clear();
            this.labelSoLuong.DataBindings.Clear();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            clearBindings();
            if (this.txbSeach.Text == "")
            {
                loadKhoiLop();
            }
            else
            {
                string query = "SELECT KL.MaKhoiLop AS [Mã Khối Lớp],KL.TenKhoiLop AS [Tên Khối Lớp], [Số Lượng] = SUM(L.SiSo) FROM dbo.LOP L,dbo.KHOILOP KL WHERE KL.MaKhoiLop = L.MaKhoiLop AND (KL.MaKhoiLop = '" + this.txbSeach.Text + "' OR KL.TenKhoiLop = '" + this.txbSeach.Text + "') GROUP BY KL.MaKhoiLop,KL.TenKhoiLop";
                dataKhoiLop.DataSource = new DataProvider().ExcuteQuery(query);
            }
            this.txbSeach.Text = "";
            addBindings();
        }
    }
}
