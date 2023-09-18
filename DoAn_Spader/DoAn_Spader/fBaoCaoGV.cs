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
    public partial class fBaoCaoGV : Form
    {
        public fBaoCaoGV()
        {
            InitializeComponent();
        }

        private void fBaoCaoGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataGiaoVien.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Fill(this.dataGiaoVien.GIAOVIEN);

            this.reportViewer1.RefreshReport();
        }
    }
}
