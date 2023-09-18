using DoAn_Spader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Spader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkConnect();
        }

        private void checkConnect()
        {
            string connectString = new ConnectionString().connectString(@"database.txt");
            SqlConnection conn = new SqlConnection(new ConnectionString().Decrypt(connectString));
            try
            {
                conn.Open();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối Đến Cơ Sở Dữ Liệu Vui Lòng Kiểm Tra Lại", "Thông Báo");
                new fConnect().ShowDialog();

            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
            this.labelUser.Text = User.UserName;
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labelUser.Text = User.UserID;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void setLabelUser(string s)
        {
            this.labelUser.Text = s;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông Báo");
            }
            else
            {
                this.labelUser.Text = "";
                User.UserName = "";
                User.UserID = "";
                MessageBox.Show("Đăng xuất thành công", "Thông Báo");
            }
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập vui lòng đăng nhập trước", "Thông Báo");
            }
            else
            {
                this.Hide();
                new fLop().ShowDialog();
                this.Show();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông Báo");
            }
            else
            {
                this.Hide();
                new fDoiMatKhau().ShowDialog();
                this.Show();
            }
        }

        private void btnKhoiLop_Click(object sender, EventArgs e)
        {
            if(User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông Báo");
            }
            else
            {
                this.Hide();
                new fKhoiLop().ShowDialog();
                this.Show();
            }
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông Báo");
            }
            else
            {
                this.Hide();
                new fKetQua().ShowDialog();
                this.Show();
            }
        }

        private void btnHocLuc_Click(object sender, EventArgs e)
        {
            if(User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fHocLuc().ShowDialog();
                this.Show();
            }
        }

        private void btnHangKiem_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fHangKiem().ShowDialog();
                this.Show();
            }
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fHocSinh().ShowDialog();
                this.Show();
            }
        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fPhanLop().ShowDialog();
                this.Show();
            }
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fDanToc().ShowDialog();
                this.Show();
            }
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fTonGiao().ShowDialog();
                this.Show();
            }
        }

        private void btnNgheNghiep_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fNgheNghiep().ShowDialog();
                this.Show();
            }
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fHocKy().ShowDialog();
                this.Show();
            }
        }

        private void btnNamHoc_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fNamHoc().ShowDialog();
                this.Show();
            }
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fMonHoc().ShowDialog();
                this.Show();
            }
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            if (User.UserID == "")
            {
                MessageBox.Show("Chưa đăng nhập", "Thông báo");
            }
            else
            {
                this.Hide();
                new fDiem().ShowDialog();
                this.Show();
            }
        }
    }
}
