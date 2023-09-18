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
    public partial class fThemMonHoc : Form
    {
        DataProvider data = new DataProvider();

        public fThemMonHoc()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool checkSoTiet = true;
            try
            {
                Convert.ToInt32(this.txbSoTiet.Text);
            }
            catch (Exception ex)
            {
                checkSoTiet = false;
            }

            if (this.txbMaMonHoc.Text == "" || this.txbTenMonHoc.Text == "" || this.ddHeSo.SelectedItem == null || this.txbSoTiet.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkSoTiet)
            {
                MessageBox.Show("Số tiết phải là số", "Thông Báo");
            }
            else if (data.ExcuteQuery("SELECT * FROM dbo.MONHOC WHERE MaMonHoc = '" + this.txbMaMonHoc.Text + "'").Rows.Count > 0) 
            {
                MessageBox.Show("Mã môn học đã tồn tại", "Thông Báo");
            }
            else
            {
                string query = "INSERT INTO dbo.MONHOC VALUES  ( '"+this.txbMaMonHoc.Text+ "', N'" + this.txbTenMonHoc.Text + "', " + this.txbSoTiet.Text + ", " + this.ddHeSo.SelectedItem.ToString() + " )";
                data.ExcuteNoQuery(query);
                MessageBox.Show("Thêm mới thành công", "Thông Báo");
                this.Close();
            }
        }
    }
}
