using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Spader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Application.Run(new fThemLop());
            //Application.Run(new fLop());
            //Application.Run(new fKhoiLop());
            //Application.Run(new fKetQua());
            //Application.Run(new fHocLuc());
            //Application.Run(new fHangKiem());
            //Application.Run(new fHocSinh());
            //Application.Run(new fPhanLop());
            //Application.Run(new fDanToc());
            //Application.Run(new fTonGiao());
            //Application.Run(new fNgheNghiep());
            //Application.Run(new fHocKy());
            //Application.Run(new fDiem());
        }
    }
}
