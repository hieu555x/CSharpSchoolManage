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
    public partial class fBaoCaoHKLH : Form
    {
        DataProvider data = new DataProvider();

        public fBaoCaoHKLH()
        {
            InitializeComponent();
        }

        private void fBaoCaoHKLH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HKLH.KQ_HOC_KY_TONG_HOP' table. You can move, or remove it, as needed.
            this.KQ_HOC_KY_TONG_HOPTableAdapter.Fill(this.dataHKLH.KQ_HOC_KY_TONG_HOP);

            this.reportViewer1.RefreshReport();
        }
    }
}
