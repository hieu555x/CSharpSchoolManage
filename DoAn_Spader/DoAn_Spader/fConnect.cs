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
    public partial class fConnect : Form
    {
        public fConnect()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=" + this.txbSever.Text + ";Initial Catalog=QLHocSinhTHPT;Integrated Security=True";
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                conn.Close();
                new ConnectionString().writeFile(@"database.txt", new ConnectionString().Encrypt(connectionString));
                this.Close();
                MessageBox.Show("Kết Nối Thành Công", "Thông Báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi vui lòng kiểm tra lại", "Thông báo");
            }
        }
    }
}
