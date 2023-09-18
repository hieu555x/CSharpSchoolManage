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
    public partial class fBaoCaoCNMH : Form
    {
        public fBaoCaoCNMH()
        {
            InitializeComponent();
        }

        private void fBaoCaoCNMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataCNMH.KQ_CA_NAM_MON_HOC' table. You can move, or remove it, as needed.
            this.KQ_CA_NAM_MON_HOCTableAdapter.Fill(this.dataCNMH.KQ_CA_NAM_MON_HOC);

            this.reportViewer1.RefreshReport();
        }
    }
}
