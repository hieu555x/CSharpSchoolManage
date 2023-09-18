using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Spader
{
    public partial class fBaoCaoHS : Form
    {
        public fBaoCaoHS()
        {
            InitializeComponent();
        }

        private void fBaoCaoHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HocSinh.HOCSINH' table. You can move, or remove it, as needed.
            this.HOCSINHTableAdapter.Fill(this.HocSinh.HOCSINH);

            this.reportViewer1.RefreshReport();
        }
    }
}
