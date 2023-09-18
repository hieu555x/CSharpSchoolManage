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
    public partial class fThemHocLuc : Form
    {
        public fThemHocLuc()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool checkDiem = true;
            try
            {
                Convert.ToDouble(this.txbDiemCanTren.Text);
                Convert.ToDouble(this.txbDiemCanDuoi.Text);
                Convert.ToDouble(this.txbKhongChe.Text);
            }
            catch(Exception ex)
            {
                checkDiem = false;
            }
            if (this.txbMaHocLuc.Text == "" || this.txbTenHocLuc.Text == "" || this.txbDiemCanTren.Text == "" || this.txbDiemCanDuoi.Text == "" || this.txbKhongChe.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu vui lòng kiểm tra lại", "Thông báo");
            }
            else if (!checkDiem)
            {
                MessageBox.Show("Điểm cận trên, điểm cận dưới và điểm khống chế phải là số", "Thông Báo");
            }
            else if (new DataProvider().ExcuteQuery("SELECT * FROM dbo.HOCLUC WHERE MaHocLuc = '" + this.txbMaHocLuc.Text + "'").Rows.Count > 0) 
            {
                MessageBox.Show("Mã học lực đã tồn tại", "Thông Báo");
            }
            else
            {
                new DataProvider().ExcuteNoQuery("INSERT INTO dbo.HOCLUC VALUES  ( '" + this.txbMaHocLuc.Text + "' ,N'" + this.txbTenHocLuc.Text + "' ," + this.txbDiemCanTren.Text + " ," + this.txbDiemCanDuoi.Text + " ," + this.txbKhongChe.Text + ")");
                MessageBox.Show("Thêm học lực mới thành công", "Thông Báo");
                this.Close();
            }
        }
    }
}
