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
    public partial class fBaoCaoHKyMH : Form
    {
        public fBaoCaoHKyMH()
        {
            InitializeComponent();
        }

        private void fBaoCaoHKyMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fBaoCaoHKMH.KQ_HOC_KY_MON_HOC' table. You can move, or remove it, as needed.
            this.KQ_HOC_KY_MON_HOCTableAdapter.Fill(this.fBaoCaoHKMH.KQ_HOC_KY_MON_HOC);

            this.reportViewer1.RefreshReport();
        }
    }
}
