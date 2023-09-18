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
    public partial class fBaoCaoLH : Form
    {
        public fBaoCaoLH()
        {
            InitializeComponent();
        }

        private void fBaoCaoLH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataLopHoc.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Fill(this.dataLopHoc.LOP);

            this.reportViewer1.RefreshReport();
        }
    }
}
